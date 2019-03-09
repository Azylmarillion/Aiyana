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
    public bool IsGrounded;
    bool wasCrouching = false;
    [Range(0, 1)]
    [SerializeField]
    float crouchSpeed = 1;
    //[SerializeField]
    //float gravity = 2;
    [SerializeField]
    float jumpForce = 100f;
    //[SerializeField, Range(0, .3f)]
    //float movementSmoothing = .05f;
    [SerializeField, Range(.1f, 50)]
    float moveSpeed = 7;
    [SerializeField, Range(.1f, 50)]
    float rotationSpeed = 7;
    [SerializeField]
    LayerMask whatIsGround;
    [SerializeField]
    Rigidbody rigidbodyPlayer;
    [SerializeField]
    Transform ceilingCheck;
    [SerializeField]
    Transform groundCheck;
    Vector3 moveDirection;
    //[SerializeField]
    //Vector3 inputs = Vector3.zero;
    [Header("Events")]
    [Space]
    public UnityEvent OnLandEvent;
    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }
    public BoolEvent OnCrouchEvent;
    #endregion

    #region Meths
    public void MovePlayer(float _horizontal, float _vertical,bool _isCrouch, bool _isJump)
    {
        if (!_isCrouch)
        {
            if (Physics.OverlapSphere(ceilingCheck.position, CEILINGRADIUS, whatIsGround).Length > 0)
            {
                _isCrouch = true;
            }
        }

        if (IsGrounded || canAirControl)
        {

            if (_isCrouch)
            {
                if (!wasCrouching)
                {
                    wasCrouching = true;
                    OnCrouchEvent.Invoke(true);
                }
                moveSpeed *= crouchSpeed;              
            }
            else
            {
                if (wasCrouching)
                {
                    wasCrouching = false;
                    OnCrouchEvent.Invoke(false);
                }
            }
            if (!rigidbodyPlayer/* || wasCrouching*/)

            {
                return;
            }
            if (IsGrounded)
            {
                moveDirection = new Vector3(_horizontal, 0, _vertical);
moveDirection = Camera.main.transform.TransformDirection(moveDirection);
                moveDirection.y = 0;
                moveDirection *= moveSpeed;
            }
           // moveDirection.y -= gravity * Time.deltaTime;
            rigidbodyPlayer.MovePosition(rigidbodyPlayer.position + moveDirection* Time.deltaTime);
PlayerRotation(_horizontal);
        }
        if (IsGrounded && _isJump)
        {
            IsGrounded = false;
            rigidbodyPlayer.AddForce(Vector3.up* jumpForce);
        }
    }
    void PlayerRotation(float _xRotation)
{
    if (!Camera.main) return;
    float _lerpAngle = Mathf.LerpAngle(transform.localEulerAngles.y, Camera.main.transform.localEulerAngles.y, Time.deltaTime * rotationSpeed);
    transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, _lerpAngle, transform.localEulerAngles.z);
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
    bool _wasGrounded = IsGrounded;
    IsGrounded = false;

    Collider[] _colliders = Physics.OverlapSphere(groundCheck.position, GROUNDEDRADIUS, whatIsGround);
    for (int i = 0; i < _colliders.Length; i++)
    {
        if (_colliders[i].gameObject != gameObject)
        {
            IsGrounded = true;
            if (!_wasGrounded)
                OnLandEvent.Invoke();
        }
    }
}
void Start()
{
    if (!rigidbodyPlayer)
    {
        rigidbodyPlayer = GetComponent<Rigidbody>();
    }
}
    #endregion
}