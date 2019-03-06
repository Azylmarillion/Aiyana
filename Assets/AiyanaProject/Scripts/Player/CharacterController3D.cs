using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterController3D : MonoBehaviour
{
    #region F/P
    [SerializeField]
    Rigidbody rigidbodyPlayer;
    [SerializeField]
    float speed;
    #endregion

    #region Meths
    void PlayerMovement(float _x,float _y)
    {
        Vector3 playerMovement = new Vector3(_x, 0f, _y) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
    #endregion

    #region UniMeths
    void Awake()
    {
        XboxControllerInputManagerWindows.OnMoveAxisInput += PlayerMovement;
    }
    #endregion
    

    

    
}