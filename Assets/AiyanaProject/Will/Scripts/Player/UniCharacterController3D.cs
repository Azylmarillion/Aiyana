using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(Animator))]
public class UniCharacterController3D : MonoBehaviour
{
    #region F/P
    [SerializeField] float movingTurnSpeed = 360;
    [SerializeField] float stationaryTurnSpeed = 180;
    [SerializeField] float jumpPower = 12f;
    [Range(1f, 4f)] [SerializeField] float gravityMultiplier = 2f;
    //[SerializeField] float runCycleLegOffset = 0.2f; 
    //[SerializeField] float moveSpeedMultiplier = 1f;
    //[SerializeField] float animSpeedMultiplier = 1f;
    [SerializeField] float groundCheckDistance = 0.1f;

    Rigidbody rigidbodyPlayer;
    Animator animatorPlayer;
    public bool IsGrounded;
    float origGroundCheckDistance;
    const float HALF = 0.5f;
    float turnAmount;
    float forwardAmount;
    Vector3 groundNormal;
    float capsuleHeight;
    Vector3 capsuleCenter;
    CapsuleCollider capsule;
    bool isCrouching;
    #endregion

    #region Meths
    void ApplyExtraTurnRotation()
    {
        // help the character turn faster (this is in addition to root rotation in the animation)
        float turnSpeed = Mathf.Lerp(stationaryTurnSpeed, movingTurnSpeed, forwardAmount);
        transform.Rotate(0, turnAmount * turnSpeed * Time.deltaTime, 0);
    }

    void CheckGroundStatus()
    {
        RaycastHit hitInfo;
#if UNITY_EDITOR
        // helper to visualise the ground check ray in the scene view
        Debug.DrawLine(transform.position + (Vector3.up * 0.1f), transform.position + (Vector3.up * 0.1f) + (Vector3.down * groundCheckDistance));
#endif
        // 0.1f is a small offset to start the ray from inside the character
        // it is also good to note that the transform position in the sample assets is at the base of the character
        if (Physics.Raycast(transform.position + (Vector3.up * 0.1f), Vector3.down, out hitInfo, groundCheckDistance))
        {
            groundNormal = hitInfo.normal;
            IsGrounded = true;
            animatorPlayer.applyRootMotion = true;
        }
        else
        {
            IsGrounded = false;
            groundNormal = Vector3.up;
            animatorPlayer.applyRootMotion = false;
        }
    }

    void HandleAirborneMovement()
    {
        // apply extra gravity from multiplier:
        Vector3 extraGravityForce = (Physics.gravity * gravityMultiplier) - Physics.gravity;
        rigidbodyPlayer.AddForce(extraGravityForce);

        groundCheckDistance = rigidbodyPlayer.velocity.y < 0 ? origGroundCheckDistance : 0.01f;
    }
    
    void HandleGroundedMovement(bool crouch, bool jump)
    {
        // check whether conditions are right to allow a jump:
        if (jump && !crouch && animatorPlayer.GetCurrentAnimatorStateInfo(0).IsName("Grounded"))
        {
            // jump!
            rigidbodyPlayer.velocity = new Vector3(rigidbodyPlayer.velocity.x, jumpPower, rigidbodyPlayer.velocity.z);
            IsGrounded = false;
            animatorPlayer.applyRootMotion = false;
            groundCheckDistance = 0.1f;
        }
    }

    void Init()
    {
       
    }

    public void Move(Vector3 move, bool crouch, bool jump)
    {

        // convert the world relative moveInput vector into a local-relative
        // turn amount and forward amount required to head in the desired
        // direction.
        if (move.magnitude > 1f) move.Normalize();
        move = transform.InverseTransformDirection(move);
        CheckGroundStatus();
        move = Vector3.ProjectOnPlane(move, groundNormal);
        turnAmount = Mathf.Atan2(move.x, move.z);
        forwardAmount = move.z;

        ApplyExtraTurnRotation();

        // control and velocity handling is different when grounded and airborne:
        if (IsGrounded)
        {
            HandleGroundedMovement(crouch, jump);
        }
        else
        {
            HandleAirborneMovement();
        }

        ScaleCapsuleForCrouching(crouch);
        PreventStandingInLowHeadroom();

        // send input and other state parameters to the animator
        //UpdateAnimator(move);
    }

    void PreventStandingInLowHeadroom()
    {
        // prevent standing up in crouch-only zones
        if (!isCrouching)
        {
            Ray crouchRay = new Ray(rigidbodyPlayer.position + Vector3.up * capsule.radius * HALF, Vector3.up);
            float crouchRayLength = capsuleHeight - capsule.radius * HALF;
            if (Physics.SphereCast(crouchRay, capsule.radius * HALF, crouchRayLength, Physics.AllLayers, QueryTriggerInteraction.Ignore))
            {
                isCrouching = true;
            }
        }
    }

    void ScaleCapsuleForCrouching(bool crouch)
    {
        if (IsGrounded && crouch)
        {
            if (isCrouching) return;
            capsule.height = capsule.height / 2f;
            capsule.center = capsule.center / 2f;
            isCrouching = true;
        }
        else
        {
            Ray crouchRay = new Ray(rigidbodyPlayer.position + Vector3.up * capsule.radius * HALF, Vector3.up);
            float crouchRayLength = capsuleHeight - capsule.radius * HALF;
            if (Physics.SphereCast(crouchRay, capsule.radius * HALF, crouchRayLength, Physics.AllLayers, QueryTriggerInteraction.Ignore))
            {
                isCrouching = true;
                return;
            }
            capsule.height = capsuleHeight;
            capsule.center = capsuleCenter;
            isCrouching = false;
        }
    }

    //void UpdateAnimator(Vector3 move)
    //{
    //    // update the animator parameters
    //    animatorPlayer.SetFloat("Forward", forwardAmount, 0.1f, Time.deltaTime);
    //    animatorPlayer.SetFloat("Turn", turnAmount, 0.1f, Time.deltaTime);
    //    animatorPlayer.SetBool("Crouch", isCrouching);
    //    animatorPlayer.SetBool("OnGround", IsGrounded);
    //    if (!IsGrounded)
    //    {
    //        animatorPlayer.SetFloat("Jump", rigidbodyPlayer.velocity.y);
    //    }

    //    // calculate which leg is behind, so as to leave that leg trailing in the jump animation
    //    // (This code is reliant on the specific run cycle offset in our animations,
    //    // and assumes one leg passes the other at the normalized clip times of 0.0 and 0.5)
    //    float runCycle =
    //        Mathf.Repeat(
    //            animatorPlayer.GetCurrentAnimatorStateInfo(0).normalizedTime + runCycleLegOffset, 1);
    //    float jumpLeg = (runCycle < HALF ? 1 : -1) * forwardAmount;
    //    if (IsGrounded)
    //    {
    //        animatorPlayer.SetFloat("JumpLeg", jumpLeg);
    //    }

    //    // the anim speed multiplier allows the overall speed of walking/running to be tweaked in the inspector,
    //    // which affects the movement speed because of the root motion.
    //    if (IsGrounded && move.magnitude > 0)
    //    {
    //        animatorPlayer.speed = animSpeedMultiplier;
    //    }
    //    else
    //    {
    //        // don't use that while airborne
    //        animatorPlayer.speed = 1;
    //    }
    //}
    #endregion

    #region UniMeths
    //public void OnAnimatorMove()
    //{
    //    // we implement this function to override the default root motion.
    //    // this allows us to modify the positional speed before it's applied.
    //    if (IsGrounded && Time.deltaTime > 0)
    //    {
    //        Vector3 v = (animatorPlayer.deltaPosition * moveSpeedMultiplier) / Time.deltaTime;

    //        // we preserve the existing y part of the current velocity.
    //        v.y = rigidbodyPlayer.velocity.y;
    //        rigidbodyPlayer.velocity = v;
    //    }
    //}

    void Start()
    {
        if (!animatorPlayer)
            animatorPlayer = GetComponent<Animator>();
        if (!rigidbodyPlayer)
            rigidbodyPlayer = GetComponent<Rigidbody>();
        if (!capsule)
            capsule = GetComponent<CapsuleCollider>();
        capsuleHeight = capsule.height;
        capsuleCenter = capsule.center;

        rigidbodyPlayer.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        origGroundCheckDistance = groundCheckDistance;
    }
    #endregion
}
