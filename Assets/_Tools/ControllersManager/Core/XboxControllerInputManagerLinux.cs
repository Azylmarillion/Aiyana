using System;
using UnityEngine;

/*
 * Welcome into the Lord InputsManager for Android
 * Don't forget to RENAME the axes inputs for the Xbox controller in the project settings:
 * Horizontal by LeftStickX
 * Vertical by LeftStickY
 * //
 * Don't forget to SET the axes inputs for the Xbox controller in the project settings:
 * RightStickX as 4th axis
 * RightStickY as 5th axis
 * D-PadX as 7th axis
 * D-PadY as 8th axis
 * RightTrigger as 6th axis
 * LeftTrigger  as 3rd axis
 */

#pragma warning disable 0414
public class XboxControllerInputManagerLinux : MonoBehaviour
{
    #region F/P
    #region Events
    #region Axis
    #region LeftStick
    public static event Action<float> OnVerticalAxisInput;
    public static event Action<float> OnHorizontalAxisInput;
    public static event Action<float, float> OnMoveAxisInput;
    #endregion
    #region RightStick
    public static event Action<float> OnRotateXAxisInput;
    public static event Action<float> OnRotateYAxisInput;
    public static event Action<float, float> OnRotateAxisInput;
    #endregion
    #region D-pad
    public static event Action<float> OnDpadxAxis;
    public static event Action<float> OnDpadyAxis;
    #endregion
    #region Trigger
    public static event Action<float> OnRightTriggerAxis;
    public static event Action<float> OnLeftTriggerAxis;
    #endregion
    #endregion
    #region  Buttons
    #region A
    #region GetKey
    public static event Action<bool> OnAInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnADownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnAUpInputPress;
    #endregion
    #endregion
    #region B
    #region GetKey
    public static event Action<bool> OnBInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnBDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnBUpInputPress;
    #endregion
    #endregion
    #region X
    #region GetKey
    public static event Action<bool> OnXInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnXDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnXUpInputPress;
    #endregion
    #endregion
    #region Y
    #region GetKey
    public static event Action<bool> OnYInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnYDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnYUpInputPress;
    #endregion
    #endregion
    #region Back
    #region GetKey
    public static event Action<bool> OnBackInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnBackDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnBackUpInputPress;
    #endregion
    #endregion
    #region DPadUp
    #region GetKey
    public static event Action<bool> OnDPadUpInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnDPadUpDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnDPadUpUpInputPress;
    #endregion
    #endregion
    #region DPadDown
    #region GetKey
    public static event Action<bool> OnDPadDownInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnDPadDownDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnDPadDownUpInputPress;
    #endregion
    #endregion
    #region DPadLeft
    #region GetKey
    public static event Action<bool> OnDPadLeftInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnDPadLeftDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnDPadLeftUpInputPress;
    #endregion
    #endregion
    #region DPadRight
    #region GetKey
    public static event Action<bool> OnDPadRightInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnDPadRightDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnDPadRightUpInputPress;
    #endregion

    //Up

    //Down

    #endregion
    #region Start
    #region GetKey
    public static event Action<bool> OnStartInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnStartDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnStartUpInputPress;
    #endregion
    #endregion
    #region Bumper
    #region GetKeyDown
    //RightBumperDown
    public static event Action<bool> OnRightBumperDownInputPress;
    //LeftBumperDown
    public static event Action<bool> OnLeftBumperDownInputPress;
    #endregion
    #region GetKeyUp
    //RightBumperUp
    public static event Action<bool> OnRightBumperUpInputPress;
    //LeftBumperUp
    public static event Action<bool> OnLeftBumperUpInputPress;
    #endregion
    #region GetKey
    //RightBumper
    public static event Action<bool> OnRightBumperInputPress;
    //LeftBumper
    public static event Action<bool> OnLeftBumperInputPress;
    #endregion
    #endregion
    #region LeftStickClick
    #region GetKey
    public static event Action<bool> OnLeftStickClickInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnLeftStickClickDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnLeftStickClickUpInputPress;
    #endregion
    #endregion
    #region RightStickClick
    #region GetKey
    public static event Action<bool> OnRightStickClickInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnRightStickClickDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnRightStickClickUpInputPress;
    #endregion
    #endregion
    #endregion
    #endregion
    #region Apportionment
    #region Axis
    #region LeftStick
    [SerializeField, Header("LeftStickX"), Range(-1, 1)]
    float leftStickX;
    public float LeftStickX { get { return leftStickX = Input.GetAxis("LeftStickX"); } }
    [SerializeField, Header("LeftStickY"), Range(-1, 1)]
    float leftStickY;
    public float LeftStickY { get { return leftStickY = Input.GetAxis("LeftStickY"); } }
    #endregion
    #region RightStick
    [SerializeField, Header("RightStickX"), Range(-1, 1)]
    float rightStickX;
    public float RightStickX { get { return rightStickX = Input.GetAxis("RightStickX"); } }
    [SerializeField, Header("RightStickY"), Range(-1, 1)]
    float rightStickY;
    public float RightStickY { get { return rightStickY = Input.GetAxis("RightStickY"); } }
    #endregion
    #region D-pad
    [SerializeField, Header("D-Pad X"), Range(-1, 1)]
    float dpadx;
    public float Dpadx { get { return dpadx = Input.GetAxis("D-PadX"); } }
    [SerializeField, Header("D-Pad X"), Range(-1, 1)]
    float dpady;
    public float Dpady { get { return dpady = Input.GetAxis("D-PadY"); } }
    #endregion
    #region Trigers
    [SerializeField, Header("RightTrigger"), Range(-1, 1)]
    float rightTrigger;
    public float RightTrigger { get { return rightTrigger = Input.GetAxis("RightTrigger"); } }
    [SerializeField, Header("LeftTrigger"), Range(-1, 1)]
    float leftTrigger;
    public float LeftTrigger { get { return leftTrigger = Input.GetAxis("LeftTrigger"); } }
    #endregion
    #endregion
    #region Buttons
    #region A
    #region GetKeyDown
    [SerializeField, Header("A Button")]
    bool aButtonDown;
    public bool AButtonDown { get { return aButtonDown = Input.GetKeyDown(KeyCode.JoystickButton0); } }
    #endregion
    #region GetKeyUp
    [SerializeField]
    bool aButtonUp;
    public bool AButtonUp { get { return aButtonUp = Input.GetKeyDown(KeyCode.JoystickButton0); } }
    #endregion
    #region GetKey
    [SerializeField]
    bool aButton;
    public bool AButton { get { return aButton = Input.GetKey(KeyCode.JoystickButton0); } }
    #endregion
    #endregion
    #region B
    #region GetKeyDown
    [SerializeField, Header("B Button")]
    bool bButtonDown;
    public bool BButtonDown { get { return bButtonDown = Input.GetKeyDown(KeyCode.JoystickButton1); } }
    #endregion
    #region GetKeyUp
    [SerializeField]
    bool bButtonUp;
    public bool BButtonUp { get { return bButtonUp = Input.GetKeyUp(KeyCode.JoystickButton1); } }
    #endregion
    #region GetKey
    [SerializeField]
    bool bButton;
    public bool BButton { get { return bButton = Input.GetKey(KeyCode.JoystickButton1); } }
    #endregion
    #endregion
    #region X
    #region GetKeyDown
    [SerializeField, Header("X Button")]
    bool xButtonDown;
    public bool XButtonDown { get { return xButtonDown = Input.GetKeyDown(KeyCode.JoystickButton2); } }
    #endregion
    #region GetKeyUp
    [SerializeField]
    bool xButtonUp;
    public bool XButtonUp { get { return xButtonUp = Input.GetKeyUp(KeyCode.JoystickButton2); } }
    #endregion
    #region GetKey
    [SerializeField]
    bool xButton;
    public bool XButton { get { return xButton = Input.GetKey(KeyCode.JoystickButton2); } }
    #endregion
    #endregion
    #region Y
    #region GetKeyDown
    [SerializeField, Header("Y Button")]
    bool yButtonDown;
    public bool YButtonDown { get { return yButtonDown = Input.GetKeyDown(KeyCode.JoystickButton3); } }
    #endregion
    #region GetKeyUp
    [SerializeField]
    bool yButtonUp;
    public bool YButtonUp { get { return yButtonUp = Input.GetKeyUp(KeyCode.JoystickButton3); } }
    #endregion
    #region GetKey
    [SerializeField]
    bool yButton;
    public bool YButton { get { return yButton = Input.GetKey(KeyCode.JoystickButton3); } }
    #endregion
    #endregion
    #region Back
    #region GetKeyDown
    [SerializeField, Header("Back Button")]
    bool backButtonDown;
    public bool BackButtonDown { get { return backButtonDown = Input.GetKeyDown(KeyCode.JoystickButton6); } }
    #endregion
    #region GetKeyUp
    [SerializeField]
    bool backButtonUp;
    public bool BackButtonUp { get { return backButtonUp = Input.GetKeyUp(KeyCode.JoystickButton6); } }
    #endregion
    #region GetKey
    [SerializeField]
    bool backButton;
    public bool BackButton { get { return backButton = Input.GetKey(KeyCode.JoystickButton6); } }
    #endregion
    #endregion
    #region Start
    #region GetKeyDown
    [SerializeField, Header("Start Button")]
    bool startButtonDown;
    public bool StartButtonDown { get { return startButtonDown = Input.GetKeyDown(KeyCode.JoystickButton7); } }
    #endregion
    #region GetKeyUp
    [SerializeField]
    bool startButtonUp;
    public bool StartButtonUp { get { return startButtonUp = Input.GetKeyUp(KeyCode.JoystickButton7); } }
    #endregion
    #region GetKey
    [SerializeField]
    bool startButton;
    public bool StartButton { get { return startButton = Input.GetKey(KeyCode.JoystickButton7); } }
    #endregion
    #endregion
    #region Bumper
    #region GetKeyDown
    [SerializeField, Header("RightBumperDown")]
    bool rightBumperDown;
    public bool RightBumperDown { get { return rightBumperDown = Input.GetKeyDown(KeyCode.JoystickButton5); } }
    [SerializeField, Header("LeftBumperDown")]
    bool leftBumperDown;
    public bool LeftBumperDown { get { return leftBumperDown = Input.GetKeyDown(KeyCode.JoystickButton4); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("RightBumperUp")]
    bool rightBumperUp;
    public bool RightBumperUp { get { return rightBumperUp = Input.GetKeyUp(KeyCode.JoystickButton5); } }
    [SerializeField, Header("LeftBumperUp")]
    bool leftBumperUp;
    public bool LeftBumperUp { get { return leftBumperUp = Input.GetKeyUp(KeyCode.JoystickButton4); } }
    #endregion
    #region GetKey
    [SerializeField, Header("RightBumper")]
    bool rightBumper;
    public bool RightBumper { get { return rightBumper = Input.GetKey(KeyCode.JoystickButton5); } }
    [SerializeField, Header("LeftBumper")]
    bool leftBumper;
    public bool LeftBumper { get { return leftBumper = Input.GetKey(KeyCode.JoystickButton4); } }
    #endregion
    #endregion
    #region D-pad
    #region D-PadUp
    #region GetKeyDown
    [SerializeField, Header("D-PadUp Down")]
    bool dPadUpDown;
    public bool DPadUpDown { get { return dPadUpDown = Input.GetKeyDown(KeyCode.JoystickButton13); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("D-PadUp Up")]
    bool dPadUpUp;
    public bool DPadUpUp { get { return dPadUpUp = Input.GetKeyUp(KeyCode.JoystickButton13); } }
    #endregion
    #region GetKey
    [SerializeField, Header("D-PadUp")]
    bool dPadUp;
    public bool DPadUp { get { return dPadUp = Input.GetKey(KeyCode.JoystickButton13); } }
    #endregion
    #endregion
    #region D-PadDown
    #region GetKeyDown
    [SerializeField, Header("D-PadDown Down")]
    bool dPadDownDown;
    public bool DPadDownDown { get { return dPadDownDown = Input.GetKeyDown(KeyCode.JoystickButton14); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("D-PadDown Up")]
    bool dPadDownUp;
    public bool DPadDownUp { get { return dPadDownUp = Input.GetKeyUp(KeyCode.JoystickButton14); } }
    #endregion
    #region GetKey
    [SerializeField, Header("D-PadDown")]
    bool dPadDown;
    public bool DPadDown { get { return dPadDown = Input.GetKey(KeyCode.JoystickButton14); } }
    #endregion
    #endregion
    #region D-PadLeft
    #region GetKeyDown
    [SerializeField, Header("D-PadLeft Down")]
    bool dPadLeftDown;
    public bool DPadLeftDown { get { return dPadLeftDown = Input.GetKeyDown(KeyCode.JoystickButton11); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("D-PadLeft Up")]
    bool dPadLeftUp;
    public bool DPadLeftUp { get { return dPadLeftUp = Input.GetKeyUp(KeyCode.JoystickButton11); } }
    #endregion
    #region GetKey
    [SerializeField, Header("D-PadLeft")]
    bool dPadLeft;
    public bool DPadLeft { get { return dPadLeft = Input.GetKey(KeyCode.JoystickButton11); } }
    #endregion
    #endregion
    #region D-PadRight
    #region GetKeyDown
    [SerializeField, Header("D-PadRight Down")]
    bool dPadRightDown;
    public bool DPadRightDown { get { return dPadRightDown = Input.GetKeyDown(KeyCode.JoystickButton12); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("D-PadRight Up")]
    bool dPadRightUp;
    public bool DPadRightUp { get { return dPadRightUp = Input.GetKeyUp(KeyCode.JoystickButton12); } }
    #endregion
    #region GetKey
    [SerializeField, Header("D-PadRight")]
    bool dPadRight;
    public bool DPadRight { get { return dPadRight = Input.GetKey(KeyCode.JoystickButton12); } }
    #endregion
    #endregion
    #endregion
    #region LeftStickClick
    #region GetKeyDown
    [SerializeField, Header("leftTriggerClickDown")]
    bool leftStickClickDown;
    public bool LeftStickClickDown { get { return leftStickClickDown = Input.GetKeyDown(KeyCode.JoystickButton9); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("leftTriggerClickUp")]
    bool leftStickClickUp;
    public bool LeftStickClickUp { get { return leftStickClickUp = Input.GetKeyUp(KeyCode.JoystickButton9); } }
    #endregion
    #region GetKey
    [SerializeField, Header("leftTriggerClick")]
    bool leftStickClick;
    public bool LeftStickClick { get { return leftStickClick = Input.GetKey(KeyCode.JoystickButton9); } }
    #endregion
    #endregion
    #region RightStickClick
    #region GetKeyDown
    [SerializeField, Header("RightTriggerClickDown")]
    bool rightStickClickDown;
    public bool RightStickClickDown { get { return rightStickClickDown = Input.GetKeyDown(KeyCode.JoystickButton10); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("RightTriggerClickUp")]
    bool rightStickClickUp;
    public bool RightStickClickUp { get { return rightStickClickUp = Input.GetKeyUp(KeyCode.JoystickButton10); } }
    #endregion
    #region GetKey
    [SerializeField, Header("RightTriggerClick")]
    bool rightStickClick;
    public bool RightStickClick { get { return rightStickClick = Input.GetKey(KeyCode.JoystickButton10); } }
    #endregion
    #endregion
    #endregion
    #endregion
    #region otter
    public static XboxControllerInputManagerLinux Instance;
    #endregion
    #endregion

    #region Meths
    void TestAxis(float _x, float _y)
    {
        //move
    }
    #endregion

    #region UniMeths
    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Already an Input Manager in the Scene !");
            Destroy(this);
        }
    }

    void OnDestroy()
    {
        #region Events
        #region LeftStick
        OnVerticalAxisInput = null;
        OnHorizontalAxisInput = null;
        OnMoveAxisInput = null;
        #endregion
        #region RightStick
        OnRotateXAxisInput = null;
        OnRotateYAxisInput = null;
        OnRotateAxisInput = null;
        #endregion
        #region D-pad
        OnDpadxAxis = null;
        OnDpadyAxis = null;
        #endregion
        #region Trigger
        OnRightTriggerAxis = null;
        OnLeftTriggerAxis = null;
        #endregion
        #region  Buttons
        #region A
        #region GetKey
        OnAInputPress = null;
        #endregion
        #region GetKeyDown
        OnADownInputPress = null;
        #endregion
        #region GetKeyUp
        OnAUpInputPress = null;
        #endregion
        #endregion
        #region B
        #region GetKey
        OnBInputPress = null;
        #endregion
        #region GetKeyDown
        OnBDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnBUpInputPress = null;
        #endregion
        #endregion
        #region X
        #region GetKey
        OnXInputPress = null;
        #endregion
        #region GetKeyDown
        OnXDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnXUpInputPress = null;
        #endregion
        #endregion
        #region Y
        #region GetKey
        OnYInputPress = null;
        #endregion
        #region GetKeyDown
        OnYDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnYUpInputPress = null;
        #endregion
        #endregion
        #region Back
        #region GetKey
        OnBackInputPress += null;
        #endregion
        #region GetKeyDown
        OnBackDownInputPress += null;
        #endregion
        #region GetKeyUp
        OnBackUpInputPress += null;
        #endregion
        #endregion
        #region DPadUp
        #region GetKey
        OnDPadUpInputPress += null;
        #endregion
        #region GetKeyDown
        OnDPadUpDownInputPress += null;
        #endregion
        #region GetKeyUp
        OnDPadUpUpInputPress += null;
        #endregion
        #endregion
        #region DPadDown
        #region GetKey
        OnDPadDownInputPress += null;
        #endregion
        #region GetKeyDown
        OnDPadDownDownInputPress += null;
        #endregion
        #region GetKeyUp
        OnDPadDownUpInputPress += null;
        #endregion
        #endregion
        #region DPadLeft
        #region GetKey
        OnDPadLeftInputPress += null;
        #endregion
        #region GetKeyDown
        OnDPadLeftDownInputPress += null;
        #endregion
        #region GetKeyUp
        OnDPadLeftUpInputPress += null;
        #endregion
        #endregion
        #region DPadRight
        #region GetKey
        OnDPadRightInputPress += null;
        #endregion
        #region GetKeyDown
        OnDPadRightDownInputPress += null;
        #endregion
        #region GetKeyUp
        OnDPadRightUpInputPress += null;
        #endregion
        #endregion
        #region Start
        #region GetKey
        OnStartInputPress = null;
        #endregion
        #region GetKeyDown
        OnStartDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnStartUpInputPress = null;
        #endregion
        #endregion
        #region Bumper
        #region GetKeyDown
        //RightBumperDown
        OnRightBumperDownInputPress = null;
        //LeftBumperDown
        OnLeftBumperDownInputPress = null;
        #endregion
        #region GetKeyUp
        //RightBumperUp
        OnRightBumperUpInputPress = null;
        //LeftBumperUp
        OnLeftBumperUpInputPress = null;
        #endregion
        #region GetKey
        //RightBumper
        OnRightBumperInputPress = null;
        //LeftBumper
        OnLeftBumperInputPress = null;
        #endregion
        #endregion
        #region LeftStickClick
        #region GetKey
        OnLeftStickClickInputPress = null;
        #endregion
        #region GetKeyDown
        OnLeftStickClickDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnLeftStickClickUpInputPress = null;
        #endregion
        #endregion
        #region RightStickClick
        #region GetKey
        OnRightStickClickInputPress = null;
        #endregion
        #region GetKeyDown
        OnRightStickClickDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnRightStickClickUpInputPress = null;
        #endregion
        #endregion
        #endregion        
        #endregion
        Instance = null;
    }

    void Update()
    {
        #region Xbox Controller
        #region Axis
        #region LeftStick
        OnVerticalAxisInput?.Invoke(LeftStickY);
        OnHorizontalAxisInput?.Invoke(LeftStickX);
        OnMoveAxisInput?.Invoke(LeftStickX, LeftStickY);
        #endregion
        #region RightStick
        OnRotateXAxisInput?.Invoke(RightStickX);
        OnRotateYAxisInput?.Invoke(RightStickY);
        OnRotateAxisInput?.Invoke(RightStickX, RightStickY);
        #endregion
        #region D-Pad
        OnDpadxAxis?.Invoke(Dpadx);
        OnDpadyAxis?.Invoke(Dpady);
        #endregion
        #region  Triggers
        OnRightTriggerAxis?.Invoke(RightTrigger);
        OnLeftTriggerAxis?.Invoke(LeftTrigger);
        #endregion
        #endregion
        #region Buttons
        #region A
        #region GetKey
        OnAInputPress?.Invoke(AButton);
        #endregion
        #region GetKeyDown
        OnADownInputPress?.Invoke(AButtonDown);
        #endregion
        #region GetKeyUp
        OnAUpInputPress?.Invoke(AButtonUp);
        #endregion
        #endregion
        #region B
        #region GetKey
        OnBInputPress?.Invoke(BButton);
        #endregion
        #region GetKeyDown
        OnBDownInputPress?.Invoke(BButtonDown);
        #endregion
        #region GetKeyUp
        OnBUpInputPress?.Invoke(BButtonUp);
        #endregion
        #endregion
        #region X
        #region GetKey
        OnXInputPress?.Invoke(XButton);
        #endregion
        #region GetKeyDown
        OnXDownInputPress?.Invoke(XButtonDown);
        #endregion
        #region GetKeyUp
        OnXUpInputPress?.Invoke(XButtonUp);
        #endregion
        #endregion
        #region Y
        #region GetKey
        OnYInputPress?.Invoke(YButton);
        #endregion
        #region GetKeyDown
        OnYDownInputPress?.Invoke(YButtonDown);
        #endregion
        #region GetKeyUp
        OnYUpInputPress?.Invoke(YButtonUp);
        #endregion
        #endregion
        #region Back
        #region GetKey
        OnBackInputPress?.Invoke(BackButton);
        #endregion
        #region GetKeyDown
        OnBackDownInputPress?.Invoke(BackButtonDown);
        #endregion
        #region GetKeyUp
        OnBackUpInputPress?.Invoke(BackButtonUp);
        #endregion
        #endregion
        #region DPadUp
        #region GetKey
        OnDPadUpInputPress?.Invoke(DPadUp);
        #endregion
        #region GetKeyDown
        OnDPadUpDownInputPress?.Invoke(DPadUpDown);
        #endregion
        #region GetKeyUp
        OnDPadUpUpInputPress?.Invoke(DPadUpUp);
        #endregion
        #endregion
        #region DPadDown
        #region GetKey
        OnDPadDownInputPress?.Invoke(DPadDown);
        #endregion
        #region GetKeyDown
        OnDPadDownDownInputPress?.Invoke(DPadDownDown);
        #endregion
        #region GetKeyUp
        OnDPadDownUpInputPress?.Invoke(DPadDownUp);
        #endregion
        #endregion
        #region DPadLeft
        #region GetKey
        OnDPadLeftInputPress?.Invoke(DPadLeft);
        #endregion
        #region GetKeyDown
        OnDPadLeftDownInputPress?.Invoke(DPadLeftDown);
        #endregion
        #region GetKeyUp
        OnDPadLeftUpInputPress?.Invoke(DPadLeftUp);
        #endregion
        #endregion
        #region DPadRight
        #region GetKey
        OnDPadRightInputPress?.Invoke(DPadRight);
        #endregion
        #region GetKeyDown
        OnDPadRightDownInputPress?.Invoke(DPadRightDown);
        #endregion
        #region GetKeyUp
        OnDPadRightUpInputPress?.Invoke(DPadRightUp);
        #endregion
        #endregion
        #region Start
        #region GetKey
        OnStartInputPress?.Invoke(StartButton);
        #endregion
        #region GetKeyDown
        OnStartDownInputPress?.Invoke(StartButtonDown);
        #endregion
        #region GetKeyUp
        OnStartUpInputPress?.Invoke(StartButtonUp);
        #endregion
        #endregion
        #region Bumper
        #region GetKeyDown
        OnRightBumperDownInputPress?.Invoke(RightBumperDown);
        OnLeftBumperDownInputPress?.Invoke(LeftBumperDown);
        #endregion
        #region GetKeyUp
        OnRightBumperUpInputPress?.Invoke(RightBumperUp);
        OnLeftBumperUpInputPress?.Invoke(LeftBumperUp);
        #endregion
        #region GetKey
        OnRightBumperInputPress?.Invoke(RightBumper);
        OnLeftBumperInputPress?.Invoke(LeftBumper);
        #endregion
        #endregion
        #region LeftStickClick
        #region GetKey
        OnLeftStickClickInputPress?.Invoke(LeftStickClick);
        #endregion
        #region GetKeyDown
        OnLeftStickClickDownInputPress?.Invoke(leftStickClickDown);
        #endregion
        #region GetKeyUp
        OnLeftStickClickUpInputPress?.Invoke(leftStickClickUp);
        #endregion
        #endregion
        #region RightStickClick
        #region GetKey
        OnRightStickClickInputPress?.Invoke(RightStickClick);
        #endregion
        #region GetKeyDown
        OnRightStickClickDownInputPress?.Invoke(RightStickClickDown);
        #endregion
        #region GetKeyUp
        OnRightStickClickUpInputPress?.Invoke(RightStickClickUp);
        #endregion
        #endregion
        #endregion
        #endregion
    }
    #endregion
}