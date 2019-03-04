using UnityEngine;

public class SwitchControllerManager : MonoBehaviour
{
    #region F/P   
    #region Keyboard
    [SerializeField, Header("keyboard alphanumerique")]
    bool kbAlphanumeriqueCanMakeSwitch = true;
    [SerializeField, Header("keyboard directional arrow")]
    bool kbDirectionalArrowCanMakeSwitch = true;
    [SerializeField, Header("keyboard keypad")]
    bool kbKeypadCanMakeSwitch = true;
    [SerializeField, Header("keyboard letres")]
    bool kbLetresCanMakeSwitch = true;
    [SerializeField, Header("keyboard Special keys")]
    bool kbSpecialKeysCanMakeSwitch = true;
    #endregion
    #region Mouse
    [SerializeField,Header("Mouse Axis")]
    bool mouseAxisCanMakeSwitch = true;
    [SerializeField, Header("Mouse Buttons")]
    bool mouseButtonsCanMakeSwitch = true;
    #endregion
    #region Xbox Controller
    [SerializeField, Header("Xbox Controller Axis")]
    bool xboxControllerAxisCanMakeSwitch = true;
    [SerializeField, Header("Xbox Controller Buttons")]
    bool xboxControllerButtonsCanMakeSwitch = true;
    #endregion
    #endregion

    #region Meths
    #region Switch hide N show cursor
    #region Hide
    void CursorHide(bool _test)
    {
        if (_test == true && Cursor.visible == true)
        {
            Cursor.visible = false;
            Debug.Log("Disable");
        }
    }

    void CursorHide(float _test)
    {
        if (_test > .19f && Cursor.visible == true)
        {
            Cursor.visible = false;
            Debug.Log("Disable");
        }
    }

    void CursorHide(float _test, float _testSec)
    {
        if (_test >.19f && _testSec >.19f && Cursor.visible == true)
        {
            Cursor.visible = false;
            Debug.Log("Disable");
        }
    }
    #endregion
    #region Show
    void CursorShow(bool _test)
    {
        if (_test == true && Cursor.visible == false)
        {
            Cursor.visible = true;
            Debug.Log("Enable");
        }
    }

    void CursorShow(float _test, float _testSec)
    {
        if (_test > .19f && _testSec > .19f && Cursor.visible == false)
        {
            Cursor.visible = true;
            Debug.Log("Enable");
        }
    }
    #endregion
    #endregion

    #region Input detected
    #region Xbox Controler
    void XboxController()
    {
        #region Axis
        if(xboxControllerAxisCanMakeSwitch)
        {
            #region Linux Inputs
            XboxControllerInputManagerLinux.OnMoveAxisInput += CursorHide;
            XboxControllerInputManagerLinux.OnRotateAxisInput += CursorHide;
            #endregion
            #region MAC Inputs
            XboxControllerInputManagerMAC.OnMoveAxisInput += CursorHide;
            XboxControllerInputManagerMAC.OnRotateAxisInput += CursorHide;
            #endregion
            #region Windows Inputs
            XboxControllerInputManagerWindows.OnMoveAxisInput += CursorHide;
            XboxControllerInputManagerWindows.OnRotateAxisInput += CursorHide;
            #endregion
        }
        #endregion
        #region Buttons
        if (xboxControllerButtonsCanMakeSwitch)
        {
            #region Linux Inputs
            XboxControllerInputManagerLinux.OnADownInputPress += CursorHide;
            XboxControllerInputManagerLinux.OnBDownInputPress += CursorHide;
            XboxControllerInputManagerLinux.OnYDownInputPress += CursorHide;
            XboxControllerInputManagerLinux.OnXDownInputPress += CursorHide;
            XboxControllerInputManagerLinux.OnStartDownInputPress += CursorHide;
            XboxControllerInputManagerLinux.OnBackDownInputPress += CursorHide;
            XboxControllerInputManagerLinux.OnDPadUpDownInputPress += CursorHide;
            XboxControllerInputManagerLinux.OnDPadDownDownInputPress += CursorHide;
            XboxControllerInputManagerLinux.OnDPadRightDownInputPress += CursorHide;
            XboxControllerInputManagerLinux.OnDPadLeftDownInputPress += CursorHide;
            #endregion
            #region Mac Inputs
            XboxControllerInputManagerMAC.OnADownInputPress += CursorHide;
            XboxControllerInputManagerMAC.OnBDownInputPress += CursorHide;
            XboxControllerInputManagerMAC.OnYDownInputPress += CursorHide;
            XboxControllerInputManagerMAC.OnXDownInputPress += CursorHide;
            XboxControllerInputManagerMAC.OnStartDownInputPress += CursorHide;
            XboxControllerInputManagerMAC.OnBackDownInputPress += CursorHide;
            XboxControllerInputManagerMAC.OnDPadUpDownInputPress += CursorHide;
            XboxControllerInputManagerMAC.OnDPadDownDownInputPress += CursorHide;
            XboxControllerInputManagerMAC.OnDPadRightDownInputPress += CursorHide;
            XboxControllerInputManagerMAC.OnDPadLeftDownInputPress += CursorHide;
            XboxControllerInputManagerMAC.OnXboxDownInputPress += CursorHide;
            #endregion
            #region Windows Inputs
            XboxControllerInputManagerWindows.OnADownInputPress += CursorHide;
            XboxControllerInputManagerWindows.OnBDownInputPress += CursorHide;
            XboxControllerInputManagerWindows.OnYDownInputPress += CursorHide;
            XboxControllerInputManagerWindows.OnXDownInputPress += CursorHide;
            XboxControllerInputManagerWindows.OnStartDownInputPress += CursorHide;
            XboxControllerInputManagerWindows.OnBackDownInputPress += CursorHide;
            #endregion
        }
        #endregion
    }
    #endregion
    #region KeyboardMouseController
    void KeyboardMouseController()
    {
        #region Mouse Inputs
        #region Axis
        if(mouseAxisCanMakeSwitch)
        {
            KeyboardInputsManager.OnMoveMouseAxisInput += CursorShow;
        }
        #endregion
        #region Buttons
        if (mouseButtonsCanMakeSwitch)
        {
            KeyboardInputsManager.OnLeftClickDownInputPress += CursorShow;
            KeyboardInputsManager.OnRightClickDownInputPress += CursorShow;
            KeyboardInputsManager.OnWheelClickDownInputPress += CursorShow;
        }
        #endregion
        #endregion
        #region Keyboard
        #region Kb alphanumerique
        if (kbAlphanumeriqueCanMakeSwitch)
        {
            KeyboardInputsManager.OnKBAOneDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBATwoDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBAThreeDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBAFourDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBAFiveDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBASixDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBASevenDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBAEightDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBANineDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBAZeroDownInputPress += CursorShow;
        }
        #endregion
        #region  Kb directional arrow
        if (kbDirectionalArrowCanMakeSwitch)
        {
            KeyboardInputsManager.OnLeftArrowDownInputPress += CursorShow;
            KeyboardInputsManager.OnRightArrowDownInputPress += CursorShow;
            KeyboardInputsManager.OnUpArrowDownInputPress += CursorShow;
            KeyboardInputsManager.OnDownArrowDownInputPress += CursorShow;
        }
        #endregion
        #region  Kb keypad
        if (kbKeypadCanMakeSwitch)
        {
            KeyboardInputsManager.OnKPOneDownInputPress += CursorShow;
            KeyboardInputsManager.OnKPTwoDownInputPress += CursorShow;
            KeyboardInputsManager.OnKPThreeDownInputPress += CursorShow;
            KeyboardInputsManager.OnKPFourDownInputPress += CursorShow;
            KeyboardInputsManager.OnKPFiveDownInputPress += CursorShow;
            KeyboardInputsManager.OnKPSixDownInputPress += CursorShow;
            KeyboardInputsManager.OnKPSevenDownInputPress += CursorShow;
            KeyboardInputsManager.OnKPEightDownInputPress += CursorShow;
            KeyboardInputsManager.OnKPNineDownInputPress += CursorShow;
            KeyboardInputsManager.OnKPAZeroDownInputPress += CursorShow;
        }
        #endregion
        #region  kb letres
        if (kbLetresCanMakeSwitch)
        {
            KeyboardInputsManager.OnKBADownInputPress += CursorShow;
            KeyboardInputsManager.OnKBZDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBEDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBRDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBTDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBYDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBUDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBIDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBODownInputPress += CursorShow;
            KeyboardInputsManager.OnKBPDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBQDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBSDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBDDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBFDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBGDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBHDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBJDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBKDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBLDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBMDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBWDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBXDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBCDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBVDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBBDownInputPress += CursorShow;
            KeyboardInputsManager.OnKBNDownInputPress += CursorShow;
        }
        #endregion
        #region  Kb Special keys
        if (kbSpecialKeysCanMakeSwitch)
        {
            KeyboardInputsManager.OnEscapeClickDownInputPress += CursorShow;
        }
        #endregion
        #endregion
    }
    #endregion
    #endregion
    #endregion

    #region UniMeth
    private void Awake()
    {
        KeyboardMouseController();
        XboxController();
    }
    #endregion
}