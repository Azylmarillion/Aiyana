using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TPCamera : MonoBehaviour
{    
    #region F/P
    [SerializeField, Header("Camera settings")]
    Transform target;
    [SerializeField, Range(.1f, 10)]
    float cameraSpeed = 2;
    [SerializeField, Range(.1f, 10)]
    float rotationCameraSpeed = 2;
    Vector3 initDirectionOffeset;
    [SerializeField]
    Camera cameraBase;
    [SerializeField]
    float initFov;
    [SerializeField, Range(1, 120)]
    float speedFov = 80;
    #endregion

    #region Meths
    void MoveCamera()
    {
        if (!target) return;
        Vector3 _cameradirection = target.position + initDirectionOffeset;
        transform.position = Vector3.Slerp(transform.position, _cameradirection, cameraSpeed);
        transform.LookAt(target);
    }

    void SprintEffect(float _vertical)
    {
        if (!cameraBase) return;
        cameraBase.fieldOfView = Mathf.Lerp(cameraBase.fieldOfView, _vertical > .5f ? speedFov : initFov, Time.deltaTime * 5);
    }

    void RotateCamera(float _x)
    {
        Quaternion _angleRotation = Quaternion.AngleAxis(_x * rotationCameraSpeed, Vector3.up);
        initDirectionOffeset = _angleRotation * initDirectionOffeset;
    }
    #endregion

    #region UniMeths
    void Awake()
    {
        XboxControllerInputManagerWindows.OnRotateXAxisInput += RotateCamera;
        XboxControllerInputManagerWindows.OnVerticalAxisInput += SprintEffect;
    }
    void LateUpdate()
    {
        MoveCamera();
    }
    void Start()
    {
        initDirectionOffeset = transform.position - target.position;
        if (cameraBase) initFov = cameraBase.fieldOfView;
    }
    #endregion
}
