using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class CharacterController3D : MonoBehaviour
{
    #region F/P
    const float GROUNDEDRADIUS = .2f;
    const float CEILINGRADIUS = .02f;
    [SerializeField]
    bool canAirControl = false;
    public bool CanAirControl { get { return canAirControl; } }
    [SerializeField]
    bool isGrounded;
    public bool IsGrounded { get { return isGrounded; } }
    bool wasCrouching = false;
    [Range(0, 1)]
    [SerializeField]
    float crouchSpeed = 1;
    [SerializeField]
    float jumpForce = 100f;
    [SerializeField, Range(0, .3f)]
    float movementSmoothing = .05f;
    [SerializeField, Range(.1f, 50)]
    float moveSpeed = 7;
    [SerializeField]
    LayerMask whatIsGround;
    [SerializeField]
    Rigidbody rigidbodyPlayer;
    [SerializeField]
    Vector3 ceilingCheck;
    [SerializeField]
    Vector3 groundCheck;
    [SerializeField]
    Vector3 velocity = Vector3.zero;
    [Header("Events")]
    [Space]
    public UnityEvent OnLandEvent;
    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }
    public BoolEvent OnCrouchEvent;
    #endregion

    #region Meths
    public void MovePlayer(float _move, bool _isCrouch, bool _isJump)
    {
        if (!_isCrouch)
        {
            if (Physics.OverlapSphere(ceilingCheck, CEILINGRADIUS, whatIsGround).Length > 0)
            {
                _isCrouch = true;
            }
        }

        if (isGrounded || canAirControl)
        {

            if (_isCrouch)
            {
                if (!wasCrouching)
                {
                    wasCrouching = true;
                    OnCrouchEvent.Invoke(true);
                }
                _move *= crouchSpeed;              
            }
            else
            {
                if (wasCrouching)
                {
                    wasCrouching = false;
                    OnCrouchEvent.Invoke(false);
                }
            }            
            if (wasCrouching) return;
            Vector3 targetVelocity = new Vector3(_move * 10f * moveSpeed * Time.fixedDeltaTime, rigidbodyPlayer.velocity.y);
            rigidbodyPlayer.velocity = Vector3.SmoothDamp(rigidbodyPlayer.velocity, targetVelocity, ref velocity, movementSmoothing);
        }
        if (isGrounded && _isJump)
        {
            isGrounded = false;
            rigidbodyPlayer.AddForce(new Vector2(0f, jumpForce));
        }
    }
    #endregion

    #region UniMeths
    void Awake()
    {
        if (OnLandEvent == null)
            OnLandEvent = new UnityEvent();
    }
    void FixedUpdate()
    {
        bool _wasGrounded = isGrounded;
        isGrounded = false;

        Collider[] _colliders = Physics.OverlapSphere(groundCheck, GROUNDEDRADIUS, whatIsGround);
        for (int i = 0; i < _colliders.Length; i++)
        {
            if (_colliders[i].gameObject != gameObject)
            {
                isGrounded = true;
                if (!_wasGrounded)
                    OnLandEvent.Invoke();
            }
        }
    }
    void Start()
    {
        if(!rigidbodyPlayer)
        {
            rigidbodyPlayer = GetComponent<Rigidbody>();
        }
    }
    #endregion
}