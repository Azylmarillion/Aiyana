using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

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
    float lastTime;
    [SerializeField]
    float maxAngle = 30;
    [SerializeField]
    float minDistance;
    [SerializeField]
    float smallEdge = .25f;
    //
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
    //
    [SerializeField]
    ThirdPersonUserControl tPUC;
    //
    [SerializeField]
    Rigidbody rigidbodyPlayer;
    //
    [SerializeField]
    Transform handTransform;
    //
    [SerializeField]
    Vector3 horizontalHandOffset;
    [SerializeField]
    Vector3 verticalHandOffset;
    #endregion
    #endregion

    #region Meths
    void CheckForSpots(Vector3 _spotLocation, Vector3 _direction, float _range, CheckingSort _currentChekingSort)
    {
        bool _foundSpot = false;
        RaycastHit _hit;
        if(Physics.Raycast(_spotLocation - transform.right * smallEdge / 2,_direction, out _hit, _range, whatsClimbable))
        {
            if(Vector3.Distance(handTransform.position,_hit.point) > minDistance)
            {
                _foundSpot = true;
                FindSpot(_hit, _currentChekingSort);
            }
        }
        if(!_foundSpot)
        {
            if (Physics.Raycast(_spotLocation + transform.right * smallEdge / 2, _direction, out _hit, _range, whatsClimbable))
            {
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
                if (Vector3.Distance(handTransform.position, _hit.point) > minDistance)
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
                if (Vector3.Distance(handTransform.position, _hit.point) > minDistance)
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
                //check for plateau
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
                }
                currentClimbSort = ClimbSort.ClimbingTowardsPoint;
            }
        }
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
                if(!Physics.Linecast(_currentRayInfo.Point - Quaternion.Euler(new Vector3(0,90,0))*_currentRayInfo.Normal * .35f + .1f *_currentRayInfo.Point, _currentRayInfo.Point + Quaternion.Euler(new Vector3(0, 90, 0)) * _currentRayInfo.Normal * .35f + .1f * _currentRayInfo.Point,out _hit,checkLayerReachable))
                {
                    if (!Physics.Linecast(_currentRayInfo.Point + Quaternion.Euler(new Vector3(0, 90, 0)) * _currentRayInfo.Normal * .35f + .1f * _currentRayInfo.Point, _currentRayInfo.Point - Quaternion.Euler(new Vector3(0, 90, 0)) * _currentRayInfo.Normal * .35f + .1f * _currentRayInfo.Point, out _hit, checkLayerReachable))
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
            SetGoToPointFalse();
            _tranform.gameObject.layer = _oldLayer;
            return _currentRayInfo;
        }
    }
    #region redundancy
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