using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region F/P
    [SerializeField, Header("Player settings"), Range(.1f, 20)]
    float gravity = 20;
    [SerializeField, Range(.1f, 400)]
    float playerJumpForce = 200;
    [SerializeField, Range(.1f, 20)]
    float playerMoveSpeed = 5;
    [SerializeField, Range(.1f, 20)]
    float playerRotationSpeed = 5;
    Vector3 moveDirection;
    [SerializeField]
    CharacterController playerController;
   // [SerializeField]
   // Rigidbody rigidbodyPlayer;
    #endregion

    #region Meths
    void PlayerMovement(float _horizontal, float _vertical)
    {
        if (!playerController) return;
        if (playerController.isGrounded)
        {
            moveDirection = new Vector3(_horizontal, 0, _vertical);
            moveDirection = Camera.main.transform.TransformDirection(moveDirection);
            moveDirection.y = 0;
            moveDirection *= playerMoveSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        playerController.Move(moveDirection * Time.deltaTime);
        PlayerRotation(_horizontal);
    }
    void PlayerRotation(float _xRotation)
    {
        if (!Camera.main) return;
        float _lerpAngle = Mathf.LerpAngle(transform.localEulerAngles.y, Camera.main.transform.localEulerAngles.y, Time.deltaTime * playerRotationSpeed);
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, _lerpAngle, transform.localEulerAngles.z);
    }
    
    #endregion

    #region UniMeths
    void Awake()
    {
        XboxControllerInputManagerWindows.OnMoveAxisInput += PlayerMovement;
    }
    private void Start()
    {

    }
    #endregion
}
