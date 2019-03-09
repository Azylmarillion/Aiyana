using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region F/P
    #region Player
    [SerializeField, Header("Player settings")]
    CharacterController3D playerToControl;
    float horizontal = 0f;
    float vertical = 0f;
    bool canJump = false;
    bool canCrouch = false;
    #endregion

    #endregion

    #region Meths
    void MakeMeJump(bool _doIt)
    {
        if (!_doIt) return;
        canJump = true;
        canCrouch = false;
    }

    void MakeMeMove(float _horizontal, float _vertical)
    {
        horizontal = _horizontal;
        vertical = _vertical;
    }
    #endregion

    #region UnyMeths
    void Awake()
    {
        XboxControllerInputManagerWindows.OnMoveAxisInput += MakeMeMove;
        XboxControllerInputManagerWindows.OnADownInputPress += MakeMeJump;
    }
    void FixedUpdate()
    {
        playerToControl.MovePlayer(horizontal, vertical, canCrouch, canJump);
        canJump = false;
    }
    void Start()
    {
        if(!playerToControl)
        {
            playerToControl = GetComponent<CharacterController3D>();
        }
    }
    #endregion
}