using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPCamera : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 1;
    [SerializeField]
    float zoomSpeed = 2f;
    [SerializeField]
    Transform Obstruction;
    [SerializeField]
    Transform Player;
    [SerializeField]
    Transform Target;        
    
    void CamControl(float _x,float _y)
    {
        float _vertical = _y * rotationSpeed;
        float _horizontal = _x * rotationSpeed;
        _vertical = Mathf.Clamp(_vertical, -35, 60);

        transform.LookAt(Target);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Target.rotation = Quaternion.Euler(_vertical, _horizontal, 0);
        }
        else
        {
            Target.rotation = Quaternion.Euler(_vertical, _horizontal, 0);
            Player.rotation = Quaternion.Euler(0, _horizontal, 0);
        }
    }


    void ViewObstructed()
    {
        RaycastHit _hit;

        if (Physics.Raycast(transform.position, Target.position - transform.position, out _hit, 4.5f))
        {
            if (_hit.collider.gameObject.tag != "Player")
            {
                Obstruction = _hit.transform;
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

                if (Vector3.Distance(Obstruction.position, transform.position) >= 3f && Vector3.Distance(transform.position, Target.position) >= 1.5f)
                    transform.Translate(Vector3.forward * zoomSpeed * Time.deltaTime);
            }
            else
            {
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                if (Vector3.Distance(transform.position, Target.position) < 4.5f)
                    transform.Translate(Vector3.back * zoomSpeed * Time.deltaTime);
            }
        }
    }

    private void Awake()
    {
        XboxControllerInputManagerWindows.OnRotateAxisInput += CamControl;
    }

    private void LateUpdate()
    {
        //CamControl();
        ViewObstructed();
    }

    void Start()
    {
        Obstruction = Target;
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }
}
