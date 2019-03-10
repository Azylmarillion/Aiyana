using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UniCharacterController3D))]
public class UniPlayerController : MonoBehaviour
{

    #region F/P
    private UniCharacterController3D characterToControl; // A reference to the ThirdPersonCharacter on the object
    private Transform tPcam;                  // A reference to the main camera in the scenes transform
    private Vector3 camForward;             // The current forward direction of the camera
    private Vector3 move;
    private bool canJump;                      // the world-relative desired move direction, calculated from the camForward and user input.
    bool canCrouch;
    float v;
    float h;
    #endregion

    #region Meths
    void MakeMeCrouch(bool _doIt)
    {
        canCrouch = _doIt;
    }
    void MakeMeJump(bool _doIt)
    {
        if (!_doIt) return;
        canJump = true;
        canCrouch = false;
    }
    void MakeMeMove(float _hori, float _vert)
    {
       h = _hori;
       v = _vert;
    }
    #endregion

    #region UniMeths
    private void Awake()
    {
        XboxControllerInputManagerWindows.OnXDownInputPress += MakeMeCrouch;
        XboxControllerInputManagerWindows.OnADownInputPress += MakeMeJump;
        XboxControllerInputManagerWindows.OnMoveAxisInput += MakeMeMove;
    }
    private void FixedUpdate()
    {
        // calculate move direction to pass to character
        if (tPcam != null)
        {
            // calculate camera relative direction to move:
            camForward = Vector3.Scale(tPcam.forward, new Vector3(1, 0, 1)).normalized;
            move = v * camForward + h * tPcam.right;
        }
        else
        {
            // we use world-relative directions in the case of no main camera
            move = v * Vector3.forward + h * Vector3.right;
        }
#if !MOBILE_INPUT
        // walk speed multiplier
        if (Input.GetKey(KeyCode.LeftShift)) move *= 0.5f;
#endif

        // pass all parameters to the character control script
        characterToControl.Move(move, canCrouch, canJump);
        canJump = false;
    }
    private void Start()
    {
        // get the transform of the main camera
        if (Camera.main != null)
        {
            tPcam = Camera.main.transform;
        }
        else
        {
            Debug.LogWarning(
                "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", gameObject);
            // we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
        }

        // get the third person character ( this should never be null due to require component )
        if(!characterToControl)
        characterToControl = GetComponent<UniCharacterController3D>();
    }
    #endregion
}