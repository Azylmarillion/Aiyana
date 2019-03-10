using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.Characters.ThirdPerson;

public class Climber : MonoBehaviour
{
    #region F/P
    [SerializeField]
    ClimbSort currentClimbSort;
    //
    [SerializeField]
    float beginDistance;
    [SerializeField]
    float climbForce = 2;
    [SerializeField]
    float climbRange = 2;
    [SerializeField]
    float coolDown = .15f;
    [SerializeField]
    float jumpForce = 2;
    [SerializeField]
    float lastTime;
    [SerializeField]
    float maxAngle = 30;
    [SerializeField]
    float minDistance;
    [SerializeField]
    float smallEdge = .25f;
    //
    [SerializeField]
    LayerMask checkLayerObstacle;
    [SerializeField]
    LayerMask checkLayerReachable;
    [SerializeField]
    LayerMask currentSpotLayer;
    [SerializeField]
    LayerMask whatsClimbable;
    //
    [SerializeField]
    Quaternion oldRotation;
    //    
    [SerializeField]
    Vector3 rayCastPosition;
    [SerializeField]
    Vector3 targetPoint;
    [SerializeField]
    Vector3 targetNormal;
    //
    #region Player
    [SerializeField,Header("Player settings")]
    Animator animator;
    //    
    [SerializeField]
    ThirdPersonCharacter tPC;
    //UniCharacterController3D tPC;
    //
    [SerializeField]
    ThirdPersonUserControl tPUC;
    //UniPlayerController tPUC;
    //
    [SerializeField]
    Rigidbody rigidbodyPlayer;
    //
    [SerializeField]
    Transform handTransform;
    //
    [SerializeField]
    Vector3 fallHandOffset;
    [SerializeField]
    Vector3 horizontalHandOffset;
    [SerializeField]
    Vector3 verticalHandOffset;    
    #endregion
    #endregion

    #region Meths
    //void CheckForClimbStart()
    //{
    //    RaycastHit _hit;
    //    Vector3 _direction = transform.forward - transform.up / .8f;
    //    if(!Physics.Raycast(transform.position + transform.rotation * rayCastPosition,_direction,1.2f ))
    //    {            
    //        currentClimbSort = ClimbSort.CheckingForClimbStart;
    //        if (Physics.Raycast(transform.position + new Vector3(0, 1.1f, 0), -transform.up, out _hit, 1.6f, whatsClimbable))
    //        {
    //            FindSpot(_hit, CheckingSort.falling);
    //            Debug.Log("climbStart");
    //        }
    //    }
    //}
    void CheckForPlateau()
    {
        RaycastHit _hit;
        Vector3 _direction = transform.up + transform.forward / 2;
        if(!Physics.Raycast(handTransform.position + transform.rotation * verticalHandOffset, _direction,out _hit,1.5f,whatsClimbable))
        {
            currentClimbSort = ClimbSort.ClimbingTowardPlateau;
            if (Physics.Raycast(handTransform.position + _direction * 1.5f, -Vector3.up, out _hit, 1.7f, whatsClimbable))
                targetPoint = handTransform.position + _direction * 1.5f;
            else
                targetPoint = handTransform.position + _direction * 1.5f - transform.rotation * new Vector3(0,- .2f, .25f);
            targetNormal = -transform.forward;
            animator.SetBool("Crouch", true);
            animator.SetBool("OnGround", true);
        }
    }
    void CheckForSpots(Vector3 _spotLocation, Vector3 _direction, float _range, CheckingSort _currentChekingSort)
    {
        bool _foundSpot = false;
        RaycastHit _hit;
        if(Physics.Raycast(_spotLocation - transform.right * smallEdge / 2,_direction, out _hit, _range, whatsClimbable))
        {
            Debug.DrawRay(_spotLocation - transform.right * smallEdge / 2, _direction, Color.red);

            if (Vector3.Distance(handTransform.position,_hit.point) > minDistance)
            {
                _foundSpot = true;
                FindSpot(_hit, _currentChekingSort);
            }
        }
        if(!_foundSpot)
        {
            if (Physics.Raycast(_spotLocation + transform.right * smallEdge / 2, _direction, out _hit, _range, whatsClimbable))
            {
                Debug.DrawRay(_spotLocation + transform.right * smallEdge / 2, _direction, Color.cyan);

                if (Vector3.Distance(handTransform.position, _hit.point) > minDistance)
                {
                    _foundSpot = true;
                    FindSpot(_hit, _currentChekingSort);
                }
            }
        }
        if (!_foundSpot)
        {
            if (Physics.Raycast(_spotLocation - transform.right * smallEdge / 2 + transform.forward * smallEdge, _direction, out _hit, _range, whatsClimbable))
            {
                Debug.DrawRay(_spotLocation - transform.right * smallEdge / 2 + transform.forward * smallEdge, _direction, Color.yellow);

                if (Vector3.Distance(handTransform.position, _hit.point)-smallEdge/1.5f > minDistance)
                {
                    _foundSpot = true;
                    FindSpot(_hit, _currentChekingSort);
                }
            }
        }
        if (!_foundSpot)
        {
            if (Physics.Raycast(_spotLocation + transform.right * smallEdge / 2 + transform.forward * smallEdge, _direction, out _hit, _range, whatsClimbable))
            {
                Debug.DrawRay(_spotLocation + transform.right * smallEdge / 2 + transform.forward * smallEdge, _direction,Color.green);
                if (Vector3.Distance(handTransform.position, _hit.point) - smallEdge / 1.5f > minDistance)
                {
                    _foundSpot = true;
                    FindSpot(_hit, _currentChekingSort);
                }
            }
        }
    }
    void Climb()
    {
        if(Time.time - lastTime > coolDown && currentClimbSort == ClimbSort.Climbing)
        {
            if(Input.GetAxis("Vertical") > 0)
            {
                CheckForSpots(handTransform.position + transform.rotation * verticalHandOffset + transform.up * climbRange, -transform.up,climbRange,CheckingSort.normal);
                if (currentClimbSort != ClimbSort.ClimbingTowardsPoint)
                    CheckForPlateau();
            }
            if (Input.GetAxis("Vertical") < 0)
            {
                CheckForSpots(handTransform.position - transform.rotation*(verticalHandOffset + new Vector3(0,0.3f,0)), -transform.up, climbRange, CheckingSort.normal);
                if(currentClimbSort != ClimbSort.ClimbingTowardsPoint)
                {
                    rigidbodyPlayer.isKinematic = false;
                    tPUC.enabled = true;
                    currentClimbSort = ClimbSort.Falling;
                    oldRotation = transform.rotation;
                }
            }
            if (Input.GetAxis("Horizontal") != 0)
            {
                CheckForSpots(handTransform.position + transform.rotation * horizontalHandOffset,transform.right*Input.GetAxis("Horizontal") - transform.up / 3.5f, climbRange / 2, CheckingSort.normal);

                if (currentClimbSort != ClimbSort.ClimbingTowardsPoint)                
                    CheckForSpots(handTransform.position + transform.rotation * horizontalHandOffset, transform.right * Input.GetAxis("Horizontal") - transform.up / 1.5f, climbRange / 3, CheckingSort.normal);

                if (currentClimbSort != ClimbSort.ClimbingTowardsPoint)
                    CheckForSpots(handTransform.position + transform.rotation * horizontalHandOffset, transform.right * Input.GetAxis("Horizontal") - transform.up / 6, climbRange / 1.5f, CheckingSort.normal);

                if (currentClimbSort != ClimbSort.ClimbingTowardsPoint)
                {
                    int _horizontal = 0;

                    if (Input.GetAxis("Horizontal") < 0)
                        _horizontal = -1;
                    if (Input.GetAxis("Horizontal") > 0)
                        _horizontal = 1;
                    CheckForSpots(handTransform.position + transform.rotation * horizontalHandOffset + transform.right*_horizontal*smallEdge/4,transform.forward - transform.up * 2, climbRange / 3, CheckingSort.turning);
                    if (currentClimbSort != ClimbSort.ClimbingTowardsPoint)
                        CheckForSpots(handTransform.position + transform.rotation * horizontalHandOffset + transform.right * .2f, transform.forward - transform.up * 2 + transform.right * _horizontal/1.5f, climbRange / 3, CheckingSort.turning);
                }
            }
        }
    }
    void FindSpot(RaycastHit _hit,CheckingSort _currentChekingSort)
    {
        if(Vector3.Angle(_hit.normal,Vector3.up) < maxAngle)
        {
            RayInfo _rayInfo = new RayInfo();
            if (_currentChekingSort == CheckingSort.normal)
                _rayInfo = GetClosestPoint(_hit.transform, _hit.point + new Vector3(0,-.01f,0),transform.forward/2.5f);
            else if (_currentChekingSort == CheckingSort.turning)
                _rayInfo = GetClosestPoint(_hit.transform, _hit.point + new Vector3(0, -.01f, 0), transform.forward / 2.5f - transform.right * Input.GetAxis("Horizontal"));
            else if (_currentChekingSort == CheckingSort.falling)
                _rayInfo = GetClosestPoint(_hit.transform, _hit.point + new Vector3(0, -.01f, 0), -transform.forward / 2.5f);
            targetPoint = _rayInfo.Point;
            targetNormal = _rayInfo.Normal;
             if (_rayInfo.CanGoToPoint)
            {
                if(currentClimbSort != ClimbSort.Climbing && currentClimbSort != ClimbSort.ClimbingTowardsPoint)
                {
                    tPUC.enabled = false;
                    rigidbodyPlayer.isKinematic = true;
                    tPC.m_IsGrounded = false;
                    //tPC.IsGrounded = false;
                }
                currentClimbSort = ClimbSort.ClimbingTowardsPoint;
                beginDistance = Vector3.Distance(transform.position, (targetPoint - transform.rotation * handTransform.localPosition));
            }
        }
    }
    void Jumping()
    {
        if(rigidbodyPlayer.velocity.y < 0 && currentClimbSort != ClimbSort.Falling)
        {
            currentClimbSort = ClimbSort.Falling;
            oldRotation = transform.rotation;
        }
        if (rigidbodyPlayer.velocity.y > 0 && currentClimbSort != ClimbSort.Jumping)
            currentClimbSort = ClimbSort.Jumping;
        if (currentClimbSort == ClimbSort.Jumping)
            CheckForSpots(handTransform.position + fallHandOffset, -transform.up,.1f,CheckingSort.normal);
        if(currentClimbSort == ClimbSort.Falling)
        {
            CheckForSpots(handTransform.position + fallHandOffset + transform.rotation * new Vector3(.02f, -.6f, 0), - transform.up,.4f,CheckingSort.normal);
            transform.rotation = oldRotation;
        }
    }
    void LinkEverything()
    {
        if (currentClimbSort == ClimbSort.Walking && Input.GetAxis("Vertical") > 0)
            StartClimbing();
        if (currentClimbSort == ClimbSort.Climbing)
            Climb();
        UpdateStates();
        if (currentClimbSort == ClimbSort.ClimbingTowardsPoint || currentClimbSort == ClimbSort.ClimbingTowardPlateau)
            MoveTowardsPoint();
        if (currentClimbSort == ClimbSort.Jumping || currentClimbSort == ClimbSort.Falling)
            Jumping();
    }
    void MoveTowardsPoint()
    {
        transform.position = Vector3.Lerp(transform.position, (targetPoint - transform.rotation * handTransform.localPosition), Time.deltaTime * climbForce);
        Quaternion _lookRotation = Quaternion.LookRotation(-targetNormal);
        transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * climbForce);
        animator.SetBool("OnGround", false);
        float _distance = Vector3.Distance(transform.position, (targetPoint - transform.rotation * handTransform.localPosition));
        //
        float _percent = -9 * (beginDistance - _distance) - beginDistance;//
        animator.SetFloat("Jump", _percent);//
        //
        if (_distance <= .01f && currentClimbSort == ClimbSort.ClimbingTowardsPoint)
        {
            transform.position = targetPoint - transform.rotation * handTransform.localPosition;
            transform.rotation = _lookRotation;
            lastTime = Time.time;
            currentClimbSort = ClimbSort.Climbing;
        }
        if (_distance <= .25f && currentClimbSort == ClimbSort.ClimbingTowardPlateau)
        {
            transform.position = targetPoint - transform.rotation * handTransform.localPosition;
            transform.rotation = _lookRotation;
            lastTime = Time.time;
            currentClimbSort = ClimbSort.Walking;
            rigidbodyPlayer.isKinematic = false;
            tPUC.enabled = true;
        }
    }
    void StartClimbing()
    {
        if(Physics.Raycast(transform.position + transform.rotation * rayCastPosition,transform.forward,.4f)&& Time.time - lastTime > coolDown && currentClimbSort == ClimbSort.Walking)
        {
            if (currentClimbSort == ClimbSort.Walking)
                rigidbodyPlayer.AddForce(transform.up * jumpForce);
            lastTime = Time.time;       
        }            
    }
    void UpdateStates()
    {
        if(currentClimbSort != ClimbSort.Walking && tPC.m_IsGrounded/*IsGrounded*/ && currentClimbSort != ClimbSort.ClimbingTowardsPoint)
        {
            currentClimbSort = ClimbSort.Walking;
            tPUC.enabled = true;
            rigidbodyPlayer.isKinematic = false;
        }
        if (currentClimbSort == ClimbSort.Walking && !tPC.m_IsGrounded/*IsGrounded*/)
            currentClimbSort = ClimbSort.Jumping;
        //if (currentClimbSort == ClimbSort.Walking && (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0))
            //CheckForClimbStart();            
    }
    RayInfo GetClosestPoint(Transform _tranform, Vector3 _direction , Vector3 _position)
    {
        RayInfo _currentRayInfo = new RayInfo();
        RaycastHit _hit;
        int _oldLayer = _tranform.gameObject.layer;
        _tranform.gameObject.layer = 14;// change this shit
        if(Physics.Raycast(_position-_direction,_direction,out _hit,_direction.magnitude*2, currentSpotLayer))
        {
            _currentRayInfo.Point = _hit.point;
            _currentRayInfo.Normal = _hit.normal;
            if(!Physics.Linecast(handTransform.position + transform.rotation * new Vector3(0,.05f,.05f),_currentRayInfo.Point + new Vector3(0,.5f,0),out _hit,checkLayerReachable))
            {
                if(!Physics.Linecast(_currentRayInfo.Point - Quaternion.Euler(new Vector3(0,90,0))*_currentRayInfo.Normal * .35f + .1f *_currentRayInfo.Normal, _currentRayInfo.Point + Quaternion.Euler(new Vector3(0, 90, 0)) * _currentRayInfo.Normal * .35f + .1f * _currentRayInfo.Normal, out _hit,checkLayerObstacle))
                {
                    if (!Physics.Linecast(_currentRayInfo.Point + Quaternion.Euler(new Vector3(0, 90, 0)) * _currentRayInfo.Normal * .35f + .1f * _currentRayInfo.Normal, _currentRayInfo.Point - Quaternion.Euler(new Vector3(0, 90, 0)) * _currentRayInfo.Normal * .35f + .1f * _currentRayInfo.Normal, out _hit, checkLayerObstacle))
                    {
                        _currentRayInfo.CanGoToPoint = true;
                    }
                    else
                    {
                        SetGoToPointFalse();
                    }
                }
                else
                {
                    SetGoToPointFalse();
                }
            }
            else
            {
                SetGoToPointFalse();
            }
            _tranform.gameObject.layer = _oldLayer;
            return _currentRayInfo;            
        }
        else
        {
            _tranform.gameObject.layer = _oldLayer;
            return _currentRayInfo;
        }
    }
    #region Redundancy
    void SetGoToPointFalse()
    {
        RayInfo _currentRayInfo = new RayInfo();
        _currentRayInfo.CanGoToPoint = false;
    }
    #endregion
    #endregion

    #region UniMeth
    private void Start()
    {
        if(!rigidbodyPlayer)
        {
            rigidbodyPlayer = GetComponent<Rigidbody>();
        }
    }
    private void Update()
    {
        LinkEverything();
    }
    #endregion
}

[System.Serializable]
public class RayInfo
{
    public bool CanGoToPoint;
    //
    public Vector3 Normal;
    public Vector3 Point;
}