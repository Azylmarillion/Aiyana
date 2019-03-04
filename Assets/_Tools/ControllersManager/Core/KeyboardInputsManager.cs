using System;
using UnityEngine;

#pragma warning disable 0414
public class KeyboardInputsManager : MonoBehaviour
{
    #region F/P
    #region Events
    #region Axis
    public static event Action<float> OnMouseXAxisInput;
    public static event Action<float> OnMouseYAxisInput;
    public static event Action<float, float> OnMoveMouseAxisInput;
    #endregion
    #region Buttons keyboard
    #region Alphanumeric
    #region 1
    #region GetKey
    public static event Action<bool> OnKBAOneInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBAOneDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBAOneUpInputPress;
    #endregion
    #endregion    
    #region 2
    #region GetKey
    public static event Action<bool> OnKBATwoInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBATwoDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBATwoUpInputPress;
    #endregion
    #endregion
    #region 3
    #region GetKey
    public static event Action<bool> OnKBAThreeInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBAThreeDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBAThreeUpInputPress;
    #endregion
    #endregion
    #region 4
    #region GetKey
    public static event Action<bool> OnKBAFourInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBAFourDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBAFourUpInputPress;
    #endregion
    #endregion
    #region 5
    #region GetKey
    public static event Action<bool> OnKBAFiveInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBAFiveDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBAFiveUpInputPress;
    #endregion
    #endregion
    #region 6
    #region GetKey
    public static event Action<bool> OnKBASixInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBASixDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBASixUpInputPress;
    #endregion
    #endregion
    #region 7
    #region GetKey
    public static event Action<bool> OnKBASevenInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBASevenDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBASevenUpInputPress;
    #endregion
    #endregion
    #region 8
    #region GetKey
    public static event Action<bool> OnKBAEightInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBAEightDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBAEightUpInputPress;
    #endregion
    #endregion
    #region 9
    #region GetKey
    public static event Action<bool> OnKBANineInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBANineDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBANineUpInputPress;
    #endregion
    #endregion
    #region 0
    #region GetKey
    public static event Action<bool> OnKBAZeroInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBAZeroDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBAZeroUpInputPress;
    #endregion
    #endregion
    #endregion
    #region DirectionalArrows
    #region DownArrow
    #region GetKey
    public static event Action<bool> OnDownArrowInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnDownArrowDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnDownArrowUpInputPress;
    #endregion
    #endregion
    #region LeftArrow
    #region GetKey
    public static event Action<bool> OnLeftArrowInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnLeftArrowDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnLeftArrowUpInputPress;
    #endregion
    #endregion
    #region RightArrow
    #region GetKey
    public static event Action<bool> OnRightArrowInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnRightArrowDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnRightArrowUpInputPress;
    #endregion
    #endregion
    #region UpArrows
    #region GetKey
    public static event Action<bool> OnUpArrowInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnUpArrowDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnUpArrowUpInputPress;
    #endregion
    #endregion
    #endregion
    #region Keypad
    #region 0
    #region GetKey
    public static event Action<bool> OnKPZeroInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKPAZeroDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKPZeroUpInputPress;
    #endregion
    #endregion    
    #region 1
    #region GetKey
    public static event Action<bool> OnKPOneInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKPOneDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKPOneUpInputPress;
    #endregion
    #endregion
    #region 2
    #region GetKey
    public static event Action<bool> OnKPTwoInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKPTwoDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKPTwoUpInputPress;
    #endregion
    #endregion
    #region 3
    #region GetKey
    public static event Action<bool> OnKPThreeInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKPThreeDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKPThreeUpInputPress;
    #endregion
    #endregion
    #region 4
    #region GetKey
    public static event Action<bool> OnKPFourInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKPFourDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKPFourUpInputPress;
    #endregion
    #endregion    
    #region 5
    #region GetKey
    public static event Action<bool> OnKPFiveInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKPFiveDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKPFiveUpInputPress;
    #endregion
    #endregion
    #region 6
    #region GetKey
    public static event Action<bool> OnKPSixInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKPSixDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKPSixUpInputPress;
    #endregion
    #endregion
    #region 7
    #region GetKey
    public static event Action<bool> OnKPSevenInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKPSevenDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKPSevenUpInputPress;
    #endregion
    #endregion
    #region 8
    #region GetKey
    public static event Action<bool> OnKPEightInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKPEightDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKPEightUpInputPress;
    #endregion
    #endregion
    #region 9
    #region GetKey
    public static event Action<bool> OnKPNineInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKPNineDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKPNineUpInputPress;
    #endregion
    #endregion    

    #endregion
    #region Lettres
    #region A
    #region GetKey
    public static event Action<bool> OnKBAInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBADownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBAUpInputPress;
    #endregion
    #endregion
    #region Z
    #region GetKey
    public static event Action<bool> OnKBZInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBZDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBZUpInputPress;
    #endregion
    #endregion
    #region E
    #region GetKey
    public static event Action<bool> OnKBEInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBEDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBEUpInputPress;
    #endregion
    #endregion
    #region R
    #region GetKey
    public static event Action<bool> OnKBRInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBRDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBRUpInputPress;
    #endregion
    #endregion
    #region T
    #region GetKey
    public static event Action<bool> OnKBTInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBTDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBTUpInputPress;
    #endregion
    #endregion
    #region Y
    #region GetKey
    public static event Action<bool> OnKBYInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBYDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBYUpInputPress;
    #endregion
    #endregion
    #region U
    #region GetKey
    public static event Action<bool> OnKBUInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBUDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBUUpInputPress;
    #endregion
    #endregion
    #region I
    #region GetKey
    public static event Action<bool> OnKBIInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBIDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBIUpInputPress;
    #endregion
    #endregion
    #region O
    #region GetKey
    public static event Action<bool> OnKBOInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBODownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBOUpInputPress;
    #endregion
    #endregion
    #region P
    #region GetKey
    public static event Action<bool> OnKBPInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBPDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBPUpInputPress;
    #endregion
    #endregion
    #region Q
    #region GetKey
    public static event Action<bool> OnKBQInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBQDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBQUpInputPress;
    #endregion
    #endregion
    #region S
    #region GetKey
    public static event Action<bool> OnKBSInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBSDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBSUpInputPress;
    #endregion
    #endregion
    #region D
    #region GetKey
    public static event Action<bool> OnKBDInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBDDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBDUpInputPress;
    #endregion
    #endregion
    #region F
    #region GetKey
    public static event Action<bool> OnKBFInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBFDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBFIUpnputPress;
    #endregion
    #endregion
    #region G
    #region GetKey
    public static event Action<bool> OnKBGInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBGDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBGUpInputPress;
    #endregion
    #endregion
    #region H
    #region GetKey
    public static event Action<bool> OnKBHInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBHDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBHUpInputPress;
    #endregion
    #endregion
    #region J
    #region GetKey
    public static event Action<bool> OnKBJInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBJDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBJUpInputPress;
    #endregion
    #endregion
    #region K
    #region GetKey
    public static event Action<bool> OnKBKInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBKDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBKUpInputPress;
    #endregion
    #endregion
    #region L
    #region GetKey
    public static event Action<bool> OnKBLInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBLDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBLUpInputPress;
    #endregion
    #endregion
    #region M
    #region GetKey
    public static event Action<bool> OnKBMInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBMDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBMUpInputPress;
    #endregion
    #endregion
    #region W
    #region GetKey
    public static event Action<bool> OnKBWInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBWDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBWUpInputPress;
    #endregion
    #endregion
    #region X
    #region GetKey
    public static event Action<bool> OnKBXInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBXDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBXUpInputPress;
    #endregion
    #endregion
    #region C
    #region GetKey
    public static event Action<bool> OnKBCInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBCDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBCUpInputPress;
    #endregion
    #endregion
    #region V
    #region GetKey
    public static event Action<bool> OnKBVInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBVDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBVUpInputPress;
    #endregion
    #endregion
    #region B
    #region GetKey
    public static event Action<bool> OnKBBInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBBDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBBUpInputPress;
    #endregion
    #endregion
    #region N
    #region GetKey
    public static event Action<bool> OnKBNInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnKBNDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnKBNUpInputPress;
    #endregion
    #endregion
    #endregion
    #endregion
    #region Buttons mouse
    #region LeftClick
    #region GetKey
    public static event Action<bool> OnLeftClickInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnLeftClickDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnLeftClickUpInputPress;
    #endregion
    #endregion
    #region RightClick
    #region GetKey
    public static event Action<bool> OnRightClickInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnRightClickDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnRightClickUpInputPress;
    #endregion
    #endregion
    #region WheelClick
    #region GetKey
    public static event Action<bool> OnWheelClickInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnWheelClickDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnWheelClickUpInputPress;
    #endregion
    #endregion
    #endregion
    #region SpecialKey
    #region Escape
    #region GetKey
    public static event Action<bool> OnEscapeClickInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnEscapeClickDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnEscapeClickUpInputPress;
    #endregion
    #endregion
    #region Space
    #region GetKey
    public static event Action<bool> OnSpaceClickInputPress;
    #endregion
    #region GetKeyDown
    public static event Action<bool> OnSpaceClickDownInputPress;
    #endregion
    #region GetKeyUp
    public static event Action<bool> OnSpaceClickUpInputPress;
    #endregion
    #endregion

    #endregion
    #endregion
    #region apportionment
    #region Axis
    [SerializeField, Header("MouseX axis"), Range(-1, 1)]
    float mouseX;
    public float MouseX { get { return mouseX = Input.GetAxis("MouseX"); } }
    [SerializeField, Header("MouseY axis"), Range(-1, 1)]
    float mouseY;
    public float MouseY { get { return mouseY = Input.GetAxis("MouseY"); } }
    #endregion
    #region Buttons mouse
    #region LeftClick
    #region GetKey
    [SerializeField, Header("LeftClick")]
    bool leftClick;
    public bool LeftClick { get { return leftClick = Input.GetKey(KeyCode.Mouse0); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("LeftClickDown")]
    bool leftClickDown;
    public bool LeftClickDown { get { return leftClickDown = Input.GetKeyDown(KeyCode.Mouse0); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("LeftClickUp")]
    bool leftClickUp;
    public bool LeftClickUp { get { return leftClickUp = Input.GetKeyUp(KeyCode.Mouse0); } }
    #endregion
    #endregion
    #region RightClick
    #region GetKey
    [SerializeField, Header("RightClick")]
    bool rightClick;
    public bool RightClick { get { return rightClick = Input.GetKey(KeyCode.Mouse1); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("RightClickDown")]
    bool rightClickDown;
    public bool RightClickDown { get { return rightClickDown = Input.GetKeyDown(KeyCode.Mouse1); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("RightClickUp")]
    bool rightClickUp;
    public bool RightClickUp { get { return rightClickUp = Input.GetKeyUp(KeyCode.Mouse1); } }
    #endregion
    #endregion
    #region WheelClick
    #region GetKey
    [SerializeField, Header("WheelClick")]
    bool wheelClick;
    public bool WheelClick { get { return wheelClick = Input.GetKey(KeyCode.Mouse2); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("WheelClickDown")]
    bool wheelClickDown;
    public bool WheelClickDown { get { return wheelClickDown = Input.GetKeyDown(KeyCode.Mouse2); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("WheelClickUp")]
    bool wheelClickUp;
    public bool WheelClickUp { get { return wheelClickUp = Input.GetKeyUp(KeyCode.Mouse2); } }
    #endregion
    #endregion
    #endregion
    #region Buttons keyboard
    #region Alphanumeric
    #region One
    #region GetKey
    [SerializeField, Header("AlphOneKeyboard")]
    bool alphaOneKeyboard;
    public bool AlphaOneKeyboard { get { return alphaOneKeyboard = Input.GetKey(KeyCode.Alpha1); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("AlphOneKeyboardDown")]
    bool alphaOneKeyboardDown;
    public bool AlphaOneKeyboardDown { get { return alphaOneKeyboardDown = Input.GetKeyDown(KeyCode.Alpha1); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("AlphOneKeyboardUp")]
    bool alphaOneKeyboardUp;
    public bool AlphaOneKeyboardUp { get { return alphaOneKeyboardDown = Input.GetKeyUp(KeyCode.Alpha1); } }
    #endregion
    #endregion
    #region Two
    #region GetKey
    [SerializeField, Header("AlphTwoKeyboard")]
    bool alphaTwoKeyboard;
    public bool AlphaTwoKeyboard { get { return alphaTwoKeyboard = Input.GetKey(KeyCode.Alpha2); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("AlphTwoKeyboardDown")]
    bool alphaTwoKeyboardDown;
    public bool AlphaTwoKeyboardDown { get { return alphaTwoKeyboardDown = Input.GetKeyDown(KeyCode.Alpha2); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("AlphTwoKeyboardUp")]
    bool alphaTwoKeyboardUp;
    public bool AlphaTwoKeyboardUp { get { return alphaTwoKeyboardUp = Input.GetKeyUp(KeyCode.Alpha2); } }
    #endregion
    #endregion
    #region Three
    #region GetKey
    [SerializeField, Header("AlphthreeKeyboard")]
    bool alphaThreeKeyboard;
    public bool AlphaThreeKeyboard { get { return alphaThreeKeyboard = Input.GetKey(KeyCode.Alpha3); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("AlphthreeKeyboard")]
    bool alphaThreeKeyboardDown;
    public bool AlphaThreeKeyboardDown { get { return alphaThreeKeyboardDown = Input.GetKeyDown(KeyCode.Alpha3); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("AlphthreeKeyboard")]
    bool alphaThreeKeyboardUp;
    public bool AlphaThreeKeyboardUp { get { return alphaThreeKeyboardUp = Input.GetKeyUp(KeyCode.Alpha3); } }
    #endregion
    #endregion
    #region Four
    #region GetKey
    [SerializeField, Header("AlphFourKeyboard")]
    bool alphFourKeyboard;
    public bool AlphFourKeyboard { get { return alphFourKeyboard = Input.GetKey(KeyCode.Alpha4); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("AlphFourKeyboard")]
    bool alphFourKeyboardDown;
    public bool AlphFourKeyboardDown { get { return alphFourKeyboardDown = Input.GetKeyDown(KeyCode.Alpha4); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("AlphFourKeyboard")]
    bool alphFourKeyboardUp;
    public bool AlphFourKeyboardUp { get { return alphFourKeyboardUp = Input.GetKeyUp(KeyCode.Alpha4); } }
    #endregion
    #endregion
    #region Five
    #region GetKey
    [SerializeField, Header("AlphFiveKeyboard")]
    bool alphaFiveKeyboard;
    public bool AlphaFiveKeyboard { get { return alphaFiveKeyboard = Input.GetKey(KeyCode.Alpha5); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("AlphFiveKeyboard")]
    bool alphaFiveKeyboardDown;
    public bool AlphaFiveKeyboardDown { get { return alphaFiveKeyboardDown = Input.GetKeyDown(KeyCode.Alpha5); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("AlphFiveKeyboard")]
    bool alphaFiveKeyboardUp;
    public bool AlphaFiveKeyboardUp { get { return alphaFiveKeyboardUp = Input.GetKeyUp(KeyCode.Alpha5); } }
    #endregion
    #endregion
    #region Six
    #region GetKey
    [SerializeField, Header("AlphSixKeyboard")]
    bool alphaSixKeyboard;
    public bool AlphaSixKeyboard { get { return alphaSixKeyboard = Input.GetKey(KeyCode.Alpha6); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("AlphSixKeyboardDown")]
    bool alphaSixKeyboardDown;
    public bool AlphaSixKeyboardDown { get { return alphaSixKeyboardDown = Input.GetKeyDown(KeyCode.Alpha6); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("AlphSixKeyboardUp")]
    bool alphaSixKeyboardUp;
    public bool AlphaSixKeyboardUp { get { return alphaSixKeyboardUp = Input.GetKeyUp(KeyCode.Alpha6); } }
    #endregion
    #endregion
    #region Seven
    #region GetKey
    [SerializeField, Header("AlphSevenKeyboard")]
    bool alphaSevenKeyboard;
    public bool AlphaSevenKeyboard { get { return alphaSevenKeyboard = Input.GetKey(KeyCode.Alpha7); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("AlphSevenKeyboard")]
    bool alphaSevenKeyboardDown;
    public bool AlphaSevenKeyboardDown { get { return alphaSevenKeyboardDown = Input.GetKeyDown(KeyCode.Alpha7); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("AlphSevenKeyboard")]
    bool alphaSevenKeyboardUp;
    public bool AlphaSevenKeyboardUp { get { return alphaSevenKeyboardUp = Input.GetKeyUp(KeyCode.Alpha7); } }
    #endregion
    #endregion
    #region Eight
    #region GetKey
    [SerializeField, Header("AlphEightKeyboard")]
    bool alphaEightKeyboard;
    public bool AlphaEightKeyboard { get { return alphaEightKeyboard = Input.GetKey(KeyCode.Alpha8); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("AlphEightKeyboardDown")]
    bool alphaEightKeyboardDown;
    public bool AlphaEightKeyboardDown { get { return alphaEightKeyboardDown = Input.GetKeyDown(KeyCode.Alpha8); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("AlphEightKeyboardUp")]
    bool alphaEightKeyboardUp;
    public bool AlphaEightKeyboardUp { get { return alphaEightKeyboardUp = Input.GetKeyUp(KeyCode.Alpha8); } }
    #endregion
    #endregion
    #region Nine
    #region GetKey
    [SerializeField, Header("AlphEighKeyboard")]
    bool alphaNineKeyboard;
    public bool AlphaNineKeyboard { get { return alphaNineKeyboard = Input.GetKey(KeyCode.Alpha9); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("AlphEighKeyboardDown")]
    bool alphaNineKeyboardDown;
    public bool AlphaNineKeyboardDown { get { return alphaNineKeyboardDown = Input.GetKeyDown(KeyCode.Alpha9); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("AlphEighKeyboardUp")]
    bool alphaNineKeyboardUp;
    public bool AlphaNineKeyboardUp { get { return alphaNineKeyboardUp = Input.GetKeyUp(KeyCode.Alpha9); } }
    #endregion
    #endregion
    #region Zero
    #region GetKey
    [SerializeField, Header("AlphZeroKeyboard")]
    bool alphaZeroKeyboard;
    public bool AlphaZeroKeyboard { get { return alphaZeroKeyboard = Input.GetKey(KeyCode.Alpha0); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("AlphZeroKeyboardDown")]
    bool alphaZeroKeyboardDown;
    public bool AlphaZeroKeyboardDown { get { return alphaZeroKeyboardDown = Input.GetKeyDown(KeyCode.Alpha0); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("AlphZeroKeyboardUp")]
    bool alphaZeroKeyboardUp;
    public bool AlphaZeroKeyboardUp { get { return alphaZeroKeyboardUp = Input.GetKeyUp(KeyCode.Alpha0); } }
    #endregion
    #endregion
    #endregion
    #region Directional Arrows
    #region DownArrow
    #region GetKey
    [SerializeField, Header("DownArrow")]
    bool downArrow;
    public bool DownArrow { get { return downArrow = Input.GetKey(KeyCode.DownArrow); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("DownArrow Down")]
    bool downArrowDown;
    public bool DownArrowDown { get { return downArrowDown = Input.GetKeyDown(KeyCode.DownArrow); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("DownArrow Up")]
    bool downArrowUp;
    public bool DownArrowUp { get { return downArrowUp = Input.GetKeyUp(KeyCode.DownArrow); } }
    #endregion
    #endregion
    #region LeftArrow
    #region GetKey
    [SerializeField, Header("LeftArrow")]
    bool leftArrow;
    public bool LeftArrow { get { return leftArrow = Input.GetKey(KeyCode.LeftArrow); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("LeftArrow Down")]
    bool leftArrowDown;
    public bool LeftArrowDown { get { return leftArrowDown = Input.GetKeyDown(KeyCode.LeftArrow); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("LeftArrow Up")]
    bool leftArrowUp;
    public bool LeftArrowUp { get { return leftArrowUp = Input.GetKeyUp(KeyCode.LeftArrow); } }
    #endregion
    #endregion
    #region RightArrow
    #region GetKey
    [SerializeField, Header("RightArrow")]
    bool rightArrow;
    public bool RightArrow { get { return rightArrow = Input.GetKey(KeyCode.RightArrow); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("RightArrow Down")]
    bool rightArrowDown;
    public bool RightArrowDown { get { return rightArrowDown = Input.GetKeyDown(KeyCode.RightArrow); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("RightArrow Up")]
    bool rightArrowUp;
    public bool RightArrowUp { get { return rightArrowUp = Input.GetKeyUp(KeyCode.RightArrow); } }
    #endregion
    #endregion
    #region UpArrow
    #region GetKey
    [SerializeField, Header("UpArrow")]
    bool upArrow;
    public bool UpArrow { get { return upArrow = Input.GetKey(KeyCode.UpArrow); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("UpArrow Down")]
    bool upArrowDown;
    public bool UpArrowDown { get { return upArrowDown = Input.GetKeyDown(KeyCode.UpArrow); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("UpArrow Up")]
    bool upArrowUp;
    public bool UpArrowUp { get { return upArrowUp = Input.GetKeyUp(KeyCode.UpArrow); } }
    #endregion
    #endregion
    #endregion
    #region Keypad
    #region Zero
    #region GetKey
    [SerializeField, Header("KeypadZeroKeyboard")]
    bool keypadZeroKeyboard;
    public bool KPZeroKeyboard { get { return keypadZeroKeyboard = Input.GetKey(KeyCode.Keypad0); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("KeypadZeroKeyboardDown")]
    bool keypadZeroKeyboardDown;
    public bool KPZeroKeyboardDown { get { return keypadZeroKeyboardDown = Input.GetKeyDown(KeyCode.Keypad0); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("KeypadZeroKeyboardUp")]
    bool keypadZeroKeyboardUp;
    public bool KPZeroKeyboardUp { get { return keypadZeroKeyboardUp = Input.GetKeyUp(KeyCode.Keypad0); } }
    #endregion
    #endregion
    #region One
    #region GetKey
    [SerializeField, Header("KeypadOneKeyboard")]
    bool keypadOneKeyboard;
    public bool KeypadOneKeyboard { get { return keypadOneKeyboard = Input.GetKey(KeyCode.Keypad1); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("KeypadOneKeyboardDown")]
    bool keypadOneKeyboardDown;
    public bool KeypadOneKeyboardDown { get { return keypadOneKeyboardDown = Input.GetKeyDown(KeyCode.Keypad1); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("KeypadOneKeyboardUp")]
    bool keypadOneKeyboardUp;
    public bool KeypadOneKeyboardUp { get { return keypadOneKeyboardDown = Input.GetKeyUp(KeyCode.Keypad1); } }
    #endregion
    #endregion
    #region Two
    #region GetKey
    [SerializeField, Header("KeypadTwoKeyboard")]
    bool keypadTwoKeyboard;
    public bool KeypadTwoKeyboard { get { return keypadTwoKeyboard = Input.GetKey(KeyCode.Keypad2); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("KeypadTwoKeyboardDown")]
    bool keypadTwoKeyboardDown;
    public bool KeypadTwoKeyboardDown { get { return keypadTwoKeyboardDown = Input.GetKeyDown(KeyCode.Keypad2); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("KeypadTwoKeyboardUp")]
    bool keypadTwoKeyboardUp;
    public bool KeypadTwoKeyboardUp { get { return keypadTwoKeyboardDown = Input.GetKeyUp(KeyCode.Keypad2); } }
    #endregion
    #endregion
    #region Three
    #region GetKey
    [SerializeField, Header("KeypadThreeKeyboard")]
    bool keypadThreeKeyboard;
    public bool KeypadThreeKeyboard { get { return keypadThreeKeyboard = Input.GetKey(KeyCode.Keypad3); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("KeypadThreeKeyboardDown")]
    bool keypadThreeKeyboardDown;
    public bool KeypadThreeKeyboardDown { get { return keypadThreeKeyboardDown = Input.GetKeyDown(KeyCode.Keypad3); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("KeypadOneKeyboardUp")]
    bool keypadThreeKeyboardUp;
    public bool KeypadThreeKeyboardUp { get { return keypadThreeKeyboardDown = Input.GetKeyUp(KeyCode.Keypad3); } }
    #endregion
    #endregion
    #region Four
    #region GetKey
    [SerializeField, Header("KeypadFourKeyboard")]
    bool keypadFourKeyboard;
    public bool KeypadFourKeyboard { get { return keypadFourKeyboard = Input.GetKey(KeyCode.Keypad4); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("KeypadFourKeyboardDown")]
    bool keypadFourKeyboardDown;
    public bool KeypadFourKeyboardDown { get { return keypadFourKeyboardDown = Input.GetKeyDown(KeyCode.Keypad4); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("KeypadFourKeyboardUp")]
    bool keypadFourKeyboardUp;
    public bool KeypadFourKeyboardUp { get { return keypadFourKeyboardDown = Input.GetKeyUp(KeyCode.Keypad4); } }
    #endregion
    #endregion
    #region Five
    #region GetKey
    [SerializeField, Header("KeypadFiveKeyboard")]
    bool keypadFiveKeyboard;
    public bool KeypadFiveKeyboard { get { return keypadFiveKeyboard = Input.GetKey(KeyCode.Keypad5); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("KeypadFiveKeyboardDown")]
    bool keypadFiveKeyboardDown;
    public bool KeypadFiveKeyboardDown { get { return keypadFiveKeyboardDown = Input.GetKeyDown(KeyCode.Keypad5); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("KeypadFiveKeyboardUp")]
    bool keypadFiveKeyboardUp;
    public bool KeypadFiveKeyboardUp { get { return keypadFiveKeyboardDown = Input.GetKeyUp(KeyCode.Keypad5); } }
    #endregion
    #endregion
    #region Six
    #region GetKey
    [SerializeField, Header("KeypadSixKeyboard")]
    bool keypadSixKeyboard;
    public bool KeypadSixKeyboard { get { return keypadSixKeyboard = Input.GetKey(KeyCode.Keypad6); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("KeypadSixKeyboardDown")]
    bool keypadSixKeyboardDown;
    public bool KeypadSixKeyboardDown { get { return keypadSixKeyboardDown = Input.GetKeyDown(KeyCode.Keypad6); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("KeypadSixKeyboardUp")]
    bool keypadSixKeyboardUp;
    public bool KeypadSixKeyboardUp { get { return keypadSixKeyboardDown = Input.GetKeyUp(KeyCode.Keypad6); } }
    #endregion
    #endregion
    #region Seven
    #region GetKey
    [SerializeField, Header("KeypadSevenKeyboard")]
    bool keypadSevenKeyboard;
    public bool KeypadSevenKeyboard { get { return keypadSevenKeyboard = Input.GetKey(KeyCode.Keypad7); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("KeypadSevenKeyboardDown")]
    bool keypadSevenKeyboardDown;
    public bool KeypadSevenKeyboardDown { get { return keypadSevenKeyboardDown = Input.GetKeyDown(KeyCode.Keypad7); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("KeypadSevenKeyboardUp")]
    bool keypadSevenKeyboardUp;
    public bool KeypadSevenKeyboardUp { get { return keypadSevenKeyboardDown = Input.GetKeyUp(KeyCode.Keypad7); } }
    #endregion
    #endregion
    #region Eight
    #region GetKey
    [SerializeField, Header("KeypadEightKeyboard")]
    bool keypadEightKeyboard;
    public bool KeypadEightKeyboard { get { return keypadEightKeyboard = Input.GetKey(KeyCode.Keypad8); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("KeypadEightKeyboardDown")]
    bool keypadEightKeyboardDown;
    public bool KeypadEightKeyboardDown { get { return keypadEightKeyboardDown = Input.GetKeyDown(KeyCode.Keypad8); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("KeypadEightKeyboardUp")]
    bool keypadEightKeyboardUp;
    public bool KeypadEightKeyboardUp { get { return keypadEightKeyboardDown = Input.GetKeyUp(KeyCode.Keypad8); } }
    #endregion
    #endregion
    #region Nine
    #region GetKey
    [SerializeField, Header("KeypadNineKeyboard")]
    bool keypadNineKeyboard;
    public bool KeypadNineKeyboard { get { return keypadNineKeyboard = Input.GetKey(KeyCode.Keypad9); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("KeypadOneKeyboardDown")]
    bool keypadNineKeyboardDown;
    public bool KeypadNineKeyboardDown { get { return keypadNineKeyboardDown = Input.GetKeyDown(KeyCode.Keypad9); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("KeypadOneKeyboardUp")]
    bool keypadNineKeyboardUp;
    public bool KeypadNineKeyboardUp { get { return keypadNineKeyboardDown = Input.GetKeyUp(KeyCode.Keypad9); } }
    #endregion
    #endregion       
    #endregion
    #region Letters
    #region A
    #region GetKey
    [SerializeField, Header("AKeyboard")]
    bool aKeyboard;
    public bool AKeyboard { get { return aKeyboard = Input.GetKey(KeyCode.A); } }
    #endregion 
    #region GetKeyDown
    [SerializeField, Header("AKeyboardDown")]
    bool aKeyboardDown;
    public bool AKeyboardDown { get { return aKeyboardDown = Input.GetKeyDown(KeyCode.A); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("AKeyboardUp")]
    bool aKeyboardUp;
    public bool AKeyboardUp { get { return aKeyboardUp = Input.GetKeyUp(KeyCode.A); } }
    #endregion
    #endregion
    #region Z
    #region GetKey
    [SerializeField, Header("ZKeyboard")]
    bool zKeyboard;
    public bool ZKeyboard { get { return zKeyboard = Input.GetKey(KeyCode.Z); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("ZKeyboardDown")]
    bool zKeyboardDown;
    public bool ZKeyboardDown { get { return zKeyboardDown = Input.GetKeyDown(KeyCode.Z); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("ZKeyboard")]
    bool zKeyboardUp;
    public bool ZKeyboardUp { get { return zKeyboardUp = Input.GetKeyUp(KeyCode.Z); } }
    #endregion
    #endregion
    #region E
    #region GetKey
    [SerializeField, Header("EKeyboard")]
    bool eKeyboard;
    public bool EKeyboard { get { return eKeyboard = Input.GetKey(KeyCode.E); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("EKeyboardDown")]
    bool eKeyboardDown;
    public bool EKeyboardDown { get { return eKeyboardDown = Input.GetKeyDown(KeyCode.E); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("EKeyboardUp")]
    bool eKeyboardUp;
    public bool EKeyboardUp { get { return eKeyboardUp = Input.GetKeyUp(KeyCode.E); } }
    #endregion
    #endregion
    #region R
    #region GetKey
    [SerializeField, Header("RKeyboard")]
    bool rKeyboard;
    public bool RKeyboard { get { return rKeyboard = Input.GetKey(KeyCode.R); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("RKeyboardDown")]
    bool rKeyboardDown;
    public bool RKeyboardDown { get { return rKeyboardDown = Input.GetKeyDown(KeyCode.R); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("RKeyboardUp")]
    bool rKeyboardUp;
    public bool RKeyboardUp { get { return rKeyboardUp = Input.GetKeyUp(KeyCode.R); } }
    #endregion
    #endregion
    #region T
    #region GetKey 
    [SerializeField, Header("TKeyboard")]
    bool tKeyboard;
    public bool TKeyboard { get { return tKeyboard = Input.GetKey(KeyCode.T); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("TKeyboardDown")]
    bool tKeyboardDown;
    public bool TKeyboardDown { get { return tKeyboardDown = Input.GetKeyDown(KeyCode.T); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("TKeyboardUp")]
    bool tKeyboardUp;
    public bool TKeyboardUp { get { return tKeyboardUp = Input.GetKeyUp(KeyCode.T); } }
    #endregion
    #endregion
    #region Y
    #region GetKey
    [SerializeField, Header("YKeyboard")]
    bool yKeyboard;
    public bool YKeyboard { get { return yKeyboard = Input.GetKey(KeyCode.Y); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("YKeyboardDown")]
    bool yKeyboardDown;
    public bool YKeyboardDown { get { return yKeyboardDown = Input.GetKeyDown(KeyCode.Y); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("YKeyboardUp")]
    bool yKeyboardUp;
    public bool YKeyboardUp { get { return yKeyboardUp = Input.GetKeyUp(KeyCode.Y); } }
    #endregion
    #endregion
    #region  U
    #region GetKey
    [SerializeField, Header("UKeyboard")]
    bool uKeyboard;
    public bool UKeyboard { get { return uKeyboard = Input.GetKey(KeyCode.U); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("UKeyboardDown")]
    bool uKeyboardDown;
    public bool UKeyboardDown { get { return uKeyboardDown = Input.GetKeyDown(KeyCode.U); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("UKeyboard")]
    bool uKeyboardUp;
    public bool UKeyboardUp { get { return uKeyboardUp = Input.GetKeyUp(KeyCode.U); } }
    #endregion
    #endregion
    #region I
    #region GetKey
    [SerializeField, Header("IKeyboard")]
    bool iKeyboard;
    public bool IKeyboard { get { return iKeyboard = Input.GetKey(KeyCode.I); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("IKeyboardDown")]
    bool iKeyboardDown;
    public bool IKeyboardDown { get { return iKeyboardDown = Input.GetKeyDown(KeyCode.I); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("IKeyboardUp")]
    bool iKeyboardUp;
    public bool IKeyboardUp { get { return iKeyboardUp = Input.GetKeyUp(KeyCode.I); } }
    #endregion
    #endregion
    #region O
    #region GetKey
    [SerializeField, Header("OKeyboard")]
    bool oKeyboard;
    public bool OKeyboard { get { return oKeyboard = Input.GetKey(KeyCode.O); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("OKeyboardDown")]
    bool oKeyboardDown;
    public bool OKeyboardDown { get { return oKeyboardDown = Input.GetKeyDown(KeyCode.O); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("OKeyboard")]
    bool oKeyboardUp;
    public bool OKeyboardUp { get { return oKeyboardUp = Input.GetKeyUp(KeyCode.O); } }
    #endregion
    #endregion
    #region P
    #region GetKey
    [SerializeField, Header("PKeyboard")]
    bool pKeyboard;
    public bool PKeyboard { get { return pKeyboard = Input.GetKey(KeyCode.P); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("PKeyboardDown")]
    bool pKeyboardDown;
    public bool PKeyboardDown { get { return pKeyboardDown = Input.GetKeyDown(KeyCode.P); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("PKeyboardUp")]
    bool pKeyboardUp;
    public bool PKeyboardUp { get { return pKeyboardUp = Input.GetKeyUp(KeyCode.P); } }
    #endregion
    #endregion
    #region Q
    #region GetKey
    [SerializeField, Header("QKeyboard")]
    bool qKeyboard;
    public bool QKeyboard { get { return qKeyboard = Input.GetKey(KeyCode.Q); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("QKeyboardDown")]
    bool qKeyboardDown;
    public bool QKeyboardDown { get { return qKeyboardDown = Input.GetKeyDown(KeyCode.Q); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("QKeyboardUp")]
    bool qKeyboardUp;
    public bool QKeyboardUp { get { return qKeyboardUp = Input.GetKeyUp(KeyCode.Q); } }
    #endregion
    #endregion
    #region S
    #region GetKey
    [SerializeField, Header("SKeyboard")]
    bool sKeyboard;
    public bool SKeyboard { get { return sKeyboard = Input.GetKey(KeyCode.S); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("SKeyboardDown")]
    bool sKeyboardDown;
    public bool SKeyboardDown { get { return sKeyboardDown = Input.GetKeyDown(KeyCode.S); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("SKeyboardUp")]
    bool sKeyboardUp;
    public bool SKeyboardUp { get { return sKeyboardUp = Input.GetKeyUp(KeyCode.S); } }
    #endregion
    #endregion
    #region D
    #region GetKey
    [SerializeField, Header("DKeyboard")]
    bool dKeyboard;
    public bool DKeyboard { get { return dKeyboard = Input.GetKey(KeyCode.D); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("DKeyboardDown")]
    bool dKeyboardDown;
    public bool DKeyboardDown { get { return dKeyboardDown = Input.GetKeyDown(KeyCode.D); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("DKeyboardUp")]
    bool dKeyboardUp;
    public bool DKeyboardUp { get { return dKeyboardUp = Input.GetKeyUp(KeyCode.D); } }
    #endregion
    #endregion
    #region F
    #region GetKey
    [SerializeField, Header("FKeyboard")]
    bool fKeyboard;
    public bool FKeyboard { get { return fKeyboard = Input.GetKey(KeyCode.F); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("FKeyboardDown")]
    bool fKeyboardDown;
    public bool FKeyboardDown { get { return fKeyboardDown = Input.GetKeyDown(KeyCode.F); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("FKeyboardUp")]
    bool fKeyboardUp;
    public bool FKeyboardUp { get { return fKeyboardUp = Input.GetKeyUp(KeyCode.F); } }
    #endregion
    #endregion
    #region G
    #region GetKey
    [SerializeField, Header("GKeyboard")]
    bool gKeyboard;
    public bool GKeyboard { get { return gKeyboard = Input.GetKey(KeyCode.G); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("GKeyboardDown")]
    bool gKeyboardDown;
    public bool GKeyboardDown { get { return gKeyboardDown = Input.GetKeyDown(KeyCode.G); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("GKeyboardUp")]
    bool gKeyboardUp;
    public bool GKeyboardUp { get { return gKeyboardUp = Input.GetKeyUp(KeyCode.G); } }
    #endregion
    #endregion
    #region H
    #region GetKey
    [SerializeField, Header("HKeyboard")]
    bool hKeyboard;
    public bool HKeyboard { get { return hKeyboard = Input.GetKey(KeyCode.H); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("HKeyboardDown")]
    bool hKeyboardDown;
    public bool HKeyboardDown { get { return hKeyboardDown = Input.GetKeyDown(KeyCode.H); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("HKeyboardUp")]
    bool hKeyboardUp;
    public bool HKeyboardUp { get { return hKeyboardUp = Input.GetKeyUp(KeyCode.H); } }
    #endregion
    #endregion
    #region J
    #region GetKey
    [SerializeField, Header("JKeyboard")]
    bool jKeyboard;
    public bool JKeyboard { get { return jKeyboard = Input.GetKey(KeyCode.J); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("JKeyboardDown")]
    bool jKeyboardDown;
    public bool JKeyboardDown { get { return jKeyboardDown = Input.GetKeyDown(KeyCode.J); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("JKeyboardUp")]
    bool jKeyboardUp;
    public bool JKeyboardUp { get { return jKeyboardUp = Input.GetKeyUp(KeyCode.J); } }
    #endregion
    #endregion
    #region K
    #region GetKey
    [SerializeField, Header("KKeyboard")]
    bool kKeyboard;
    public bool KKeyboard { get { return kKeyboard = Input.GetKey(KeyCode.K); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("KKeyboardDown")]
    bool kKeyboardDown;
    public bool KKeyboardDown { get { return kKeyboardDown = Input.GetKeyDown(KeyCode.K); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("KKeyboardUp")]
    bool kKeyboardUp;
    public bool KKeyboardUp { get { return kKeyboardUp = Input.GetKeyUp(KeyCode.K); } }
    #endregion
    #endregion
    #region L
    #region GetKey
    [SerializeField, Header("LKeyboard")]
    bool lKeyboard;
    public bool LKeyboard { get { return lKeyboard = Input.GetKey(KeyCode.L); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("LKeyboardDown")]
    bool lKeyboardDown;
    public bool LKeyboardDown { get { return lKeyboardDown = Input.GetKeyDown(KeyCode.L); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("LKeyboardUp")]
    bool lKeyboardUp;
    public bool LKeyboardUp { get { return lKeyboardUp = Input.GetKeyUp(KeyCode.L); } }
    #endregion
    #endregion
    #region M
    #region GetKey
    [SerializeField, Header("MKeyboard")]
    bool mKeyboard;
    public bool MKeyboard { get { return mKeyboard = Input.GetKey(KeyCode.M); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("MKeyboardDown")]
    bool mKeyboardDown;
    public bool MKeyboardDown { get { return mKeyboardDown = Input.GetKeyDown(KeyCode.M); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("MKeyboardUp")]
    bool mKeyboardUp;
    public bool MKeyboardUp { get { return mKeyboardUp = Input.GetKeyUp(KeyCode.M); } }
    #endregion
    #endregion
    #region W
    #region GetKey
    [SerializeField, Header("WKeyboard")]
    bool wKeyboard;
    public bool WKeyboard { get { return wKeyboard = Input.GetKey(KeyCode.W); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("WKeyboardDown")]
    bool wKeyboardDown;
    public bool WKeyboardDown { get { return wKeyboardDown = Input.GetKeyDown(KeyCode.W); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("WKeyboardUp")]
    bool wKeyboardUp;
    public bool WKeyboardUp { get { return wKeyboardUp = Input.GetKeyUp(KeyCode.W); } }
    #endregion
    #endregion
    #region X
    #region GetKey
    [SerializeField, Header("XKeyboard")]
    bool xKeyboard;
    public bool XKeyboard { get { return xKeyboard = Input.GetKey(KeyCode.X); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("XKeyboardDown")]
    bool xKeyboardDown;
    public bool XKeyboardDown { get { return xKeyboardDown = Input.GetKeyDown(KeyCode.X); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("XKeyboardUp")]
    bool xKeyboardUp;
    public bool XKeyboardUp { get { return xKeyboardUp = Input.GetKeyUp(KeyCode.X); } }
    #endregion
    #endregion
    #region C
    #region GetKey
    [SerializeField, Header("CKeyboard")]
    bool cKeyboard;
    public bool CKeyboard { get { return cKeyboard = Input.GetKey(KeyCode.C); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("CKeyboardDown")]
    bool cKeyboardDown;
    public bool CKeyboardDown { get { return cKeyboardDown = Input.GetKeyDown(KeyCode.C); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("CKeyboard")]
    bool cKeyboardUp;
    public bool CKeyboardUp { get { return cKeyboardUp = Input.GetKeyUp(KeyCode.C); } }
    #endregion
    #endregion
    #region V
    #region GetKey
    [SerializeField, Header("VKeyboard")]
    bool vKeyboard;
    public bool VKeyboard { get { return vKeyboard = Input.GetKey(KeyCode.V); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("VKeyboardDown")]
    bool vKeyboardDown;
    public bool VKeyboardDown { get { return vKeyboardDown = Input.GetKeyDown(KeyCode.V); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("VKeyboardUp")]
    bool vKeyboardUp;
    public bool VKeyboardUp { get { return vKeyboardUp = Input.GetKeyUp(KeyCode.V); } }
    #endregion
    #endregion
    #region B
    #region GetKey
    [SerializeField, Header("BKeyboard")]
    bool bKeyboard;
    public bool BKeyboard { get { return bKeyboard = Input.GetKey(KeyCode.B); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("BKeyboardDown")]
    bool bKeyboardDown;
    public bool BKeyboardDown { get { return bKeyboardDown = Input.GetKeyDown(KeyCode.B); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("BKeyboardUp")]
    bool bKeyboardUp;
    public bool BKeyboardUp { get { return bKeyboardUp = Input.GetKeyUp(KeyCode.B); } }
    #endregion
    #endregion
    #region N
    #region GetKey
    [SerializeField, Header("NKeyboard")]
    bool nKeyboard;
    public bool NKeyboard { get { return nKeyboard = Input.GetKey(KeyCode.N); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("NKeyboardDown")]
    bool nKeyboardDown;
    public bool NKeyboardDown { get { return nKeyboardDown = Input.GetKeyDown(KeyCode.N); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("NKeyboardUp")]
    bool nKeyboardUp;
    public bool NKeyboardUp { get { return nKeyboardUp = Input.GetKeyUp(KeyCode.N); } }
    #endregion
    #endregion
    #endregion
    #region SpecialKey
    #region Escape
    #region GetKey
    [SerializeField, Header("Escape")]
    bool escape;
    public bool Escape { get { return escape = Input.GetKey(KeyCode.Escape); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("Escape Down")]
    bool escapeDown;
    public bool EscapeDown { get { return escapeDown = Input.GetKeyDown(KeyCode.Escape); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("Escape Up")]
    bool escapeUp;
    public bool EscapeUp { get { return escapeUp = Input.GetKeyUp(KeyCode.Escape); } }
    #endregion
    #endregion
    #region Space
    #region GetKey
    [SerializeField, Header("Space")]
    bool space;
    public bool Space { get { return space = Input.GetKey(KeyCode.Space); } }
    #endregion
    #region GetKeyDown
    [SerializeField, Header("Space Down")]
    bool spaceDown;
    public bool SpaceDown { get { return spaceDown = Input.GetKeyDown(KeyCode.Space); } }
    #endregion
    #region GetKeyUp
    [SerializeField, Header("Space Up")]
    bool spaceUp;
    public bool SpaceUp { get { return spaceUp = Input.GetKeyUp(KeyCode.Space); } }
    #endregion
    #endregion

    #endregion
    #endregion
    #endregion
    #region otter
    public static KeyboardInputsManager Instance;
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
        #region Axis
        OnMouseXAxisInput = null;
        OnMouseYAxisInput = null;
        OnMoveMouseAxisInput = null;
        #endregion
        #region Buttons keyboard
        #region Alphanumeric
        #region 1
        #region GetKey
        OnKBAOneInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBAOneDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBAOneUpInputPress = null;
        #endregion
        #endregion
        #region 2
        #region GetKey
        OnKBATwoInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBATwoDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBATwoUpInputPress = null;
        #endregion
        #endregion
        #region 3
        #region GetKey
        OnKBAThreeInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBAThreeDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBAThreeUpInputPress = null;
        #endregion
        #endregion
        #region 4
        #region GetKey
        OnKBAFourInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBAFourDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBAFourUpInputPress = null;
        #endregion
        #endregion
        #region 5
        #region GetKey
        OnKBAFiveInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBAFiveDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBAFiveUpInputPress = null;
        #endregion
        #endregion
        #region 6
        #region GetKey
        OnKBASixInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBASixDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBASixUpInputPress = null;
        #endregion
        #endregion
        #region 7
        #region GetKey
        OnKBASevenInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBASevenDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBASevenUpInputPress = null;
        #endregion
        #endregion
        #region 8
        #region GetKey
        OnKBAEightInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBAEightDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBAEightUpInputPress = null;
        #endregion
        #endregion
        #region 9
        #region GetKey
        OnKBANineInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBANineDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBANineUpInputPress = null;
        #endregion
        #endregion
        #region 0
        #region GetKey
        OnKBAZeroInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBAZeroDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBAZeroUpInputPress = null;
        #endregion
        #endregion
        #endregion
        #region DirectionalArrow
        #region DownArrow
        #region GetKey
        OnDownArrowInputPress = null;
        #endregion
        #region GetKeyDown
        OnDownArrowDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnDownArrowUpInputPress = null;
        #endregion
        #endregion
        #region LeftArrow
        #region GetKey
        OnLeftArrowInputPress = null;
        #endregion
        #region GetKeyDown
        OnLeftArrowDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnLeftArrowUpInputPress = null;
        #endregion
        #endregion
        #region RightArrow
        #region GetKey
        OnRightArrowInputPress = null;
        #endregion
        #region GetKeyDown
        OnRightArrowDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnRightArrowUpInputPress = null;
        #endregion
        #endregion
        #region UpArrow
        #region GetKey
        OnUpArrowInputPress = null;
        #endregion
        #region GetKeyDown
        OnUpArrowDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnUpArrowUpInputPress = null;
        #endregion
        #endregion
        #endregion
        #region Lettres
        #region A
        #region GetKey
        OnKBAInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBADownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBAUpInputPress = null;
        #endregion
        #endregion
        #region Z
        #region GetKey
        OnKBZInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBZDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBZUpInputPress = null;
        #endregion
        #endregion
        #region E
        #region GetKey
        OnKBEInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBEDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBEUpInputPress = null;
        #endregion
        #endregion
        #region R
        #region GetKey
        OnKBRInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBRDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBRUpInputPress = null;
        #endregion
        #endregion
        #region T
        #region GetKey
        OnKBTInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBTDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBTUpInputPress = null;
        #endregion
        #endregion
        #region Y
        #region GetKey
        OnKBYInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBYDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBYUpInputPress = null;
        #endregion
        #endregion
        #region U
        #region GetKey
        OnKBUInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBUDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBUUpInputPress = null;
        #endregion
        #endregion
        #region I
        #region GetKey
        OnKBIInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBIDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBIUpInputPress = null;
        #endregion
        #endregion
        #region O
        #region GetKey
        OnKBOInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBODownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBOUpInputPress = null;
        #endregion
        #endregion
        #region P
        #region GetKey
        OnKBPInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBPDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBPUpInputPress = null;
        #endregion
        #endregion
        #region Q
        #region GetKey
        OnKBQInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBQDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBQUpInputPress = null;
        #endregion
        #endregion
        #region S
        #region GetKey
        OnKBSInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBSDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBSUpInputPress = null;
        #endregion
        #endregion
        #region D
        #region GetKey
        OnKBDInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBDDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBDUpInputPress = null;
        #endregion
        #endregion
        #region F
        #region GetKey
        OnKBFInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBFDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBFIUpnputPress = null;
        #endregion
        #endregion
        #region G
        #region GetKey
        OnKBGInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBGDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBGUpInputPress = null;
        #endregion
        #endregion
        #region H
        #region GetKey
        OnKBHInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBHDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBHUpInputPress = null;
        #endregion
        #endregion
        #region J
        #region GetKey
        OnKBJInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBJDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBJUpInputPress = null;
        #endregion
        #endregion
        #region K
        #region GetKey
        OnKBKInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBKDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBKUpInputPress = null;
        #endregion
        #endregion
        #region L
        #region GetKey
        OnKBLInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBLDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBLUpInputPress = null;
        #endregion
        #endregion
        #region M
        #region GetKey
        OnKBMInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBMDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBMUpInputPress = null;
        #endregion
        #endregion
        #region W
        #region GetKey
        OnKBWInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBWDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBWUpInputPress = null;
        #endregion
        #endregion
        #region X
        #region GetKey
        OnKBXInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBXDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBXUpInputPress = null;
        #endregion
        #endregion
        #region C
        #region GetKey
        OnKBCInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBCDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBCUpInputPress = null;
        #endregion
        #endregion
        #region V
        #region GetKey
        OnKBVInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBVDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBVUpInputPress = null;
        #endregion
        #endregion
        #region B
        #region GetKey
        OnKBBInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBBDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBBUpInputPress = null;
        #endregion
        #endregion
        #region N
        #region GetKey
        OnKBNInputPress = null;
        #endregion
        #region GetKeyDown
        OnKBNDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKBNUpInputPress = null;
        #endregion
        #endregion
        #endregion
        #region Keypad
        #region 0
        #region GetKey
        OnKPZeroInputPress = null;
        #endregion
        #region GetKeyDown
        OnKPAZeroDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKPZeroUpInputPress = null;
        #endregion
        #endregion
        #region 1
        #region GetKey
        OnKPOneInputPress = null;
        #endregion
        #region GetKeyDown
        OnKPOneDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKPOneUpInputPress = null;
        #endregion
        #endregion
        #region 2
        #region GetKey
        OnKPTwoInputPress = null;
        #endregion
        #region GetKeyDown
        OnKPTwoDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKPTwoUpInputPress = null;
        #endregion
        #endregion
        #region 3
        #region GetKey
        OnKPThreeInputPress = null;
        #endregion
        #region GetKeyDown
        OnKPThreeDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKPThreeUpInputPress = null;
        #endregion
        #endregion
        #region 4
        #region GetKey
        OnKPFourInputPress = null;
        #endregion
        #region GetKeyDown
        OnKPFourDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKPFourUpInputPress = null;
        #endregion
        #endregion
        #region 5
        #region GetKey
        OnKPFiveInputPress = null;
        #endregion
        #region GetKeyDown
        OnKPFiveDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKPFiveUpInputPress = null;
        #endregion
        #endregion
        #region 6
        #region GetKey
        OnKPSixInputPress = null;
        #endregion
        #region GetKeyDown
        OnKPSixDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKPSixUpInputPress = null;
        #endregion
        #endregion
        #region 7
        #region GetKey
        OnKPSevenInputPress = null;
        #endregion
        #region GetKeyDown
        OnKPSevenDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKPSevenUpInputPress = null;
        #endregion
        #endregion
        #region 8
        #region GetKey
        OnKPEightInputPress = null;
        #endregion
        #region GetKeyDown
        OnKPEightDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKPEightUpInputPress = null;
        #endregion
        #endregion
        #region 9
        #region GetKey
        OnKPNineInputPress = null;
        #endregion
        #region GetKeyDown
        OnKPNineDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnKPNineUpInputPress = null;
        #endregion
        #endregion
        #endregion
        #region SpecialKey
        #region Escape
        #region GetKey
        OnEscapeClickInputPress = null;
        #endregion
        #region GetKeyDown
        OnEscapeClickDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnEscapeClickUpInputPress = null;
        #endregion
        #endregion
        #region Space
        #region GetKey
        OnSpaceClickInputPress = null;
        #endregion
        #region GetKeyDown
        OnSpaceClickDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnSpaceClickUpInputPress = null;
        #endregion
        #endregion

        #endregion
        #endregion
        #region Buttons mouse
        #region LeftClick
        #region GetKey
        OnLeftClickInputPress = null;
        #endregion
        #region GetKeyDown
        OnLeftClickDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnLeftClickUpInputPress = null;
        #endregion
        #endregion
        #region RightClick
        #region GetKey
        OnRightClickInputPress = null;
        #endregion
        #region GetKeyDown
        OnRightClickDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnRightClickUpInputPress = null;
        #endregion
        #endregion
        #region WheelClick
        #region GetKey
        OnWheelClickInputPress = null;
        #endregion
        #region GetKeyDown
        OnWheelClickDownInputPress = null;
        #endregion
        #region GetKeyUp
        OnWheelClickUpInputPress = null;
        #endregion
        #endregion
        #endregion
        #endregion
        Instance = null;
    }

    public void Update()
    {       
        #region Mouse axis
        OnMouseXAxisInput?.Invoke(MouseX);
        OnMouseYAxisInput?.Invoke(MouseY);
        OnMoveMouseAxisInput?.Invoke(MouseX,MouseY);
        #endregion
        #region Mouse buttons
        #region LeftClick
        #region GetKey
        OnLeftClickInputPress?.Invoke(LeftClick);
        #endregion
        #region GetKeyDown
        OnLeftClickDownInputPress?.Invoke(LeftClickDown);
        #endregion
        #region GetKeyUp
        OnLeftClickUpInputPress?.Invoke(LeftClickUp);
        #endregion
        #endregion
        #region RightClick
        #region GetKey
        OnRightClickInputPress?.Invoke(RightClick);
        #endregion
        #region GetKeyDown
        OnRightClickDownInputPress?.Invoke(RightClickDown);
        #endregion
        #region GetKeyUp
        OnRightClickUpInputPress?.Invoke(RightClickUp);
        #endregion
        #endregion
        #region WheelClick
        #region GetKey
        OnWheelClickInputPress?.Invoke(WheelClick);
        #endregion
        #region GetKeyDown
        OnWheelClickDownInputPress?.Invoke(WheelClickDown);
        #endregion
        #region GetKeyUp
        OnWheelClickUpInputPress?.Invoke(WheelClickUp);
        #endregion
        #endregion
        #endregion
        #region Keyboard
        #region Alphanumeric
        #region 1
        #region GetKey
        OnKBAOneInputPress?.Invoke(AlphaOneKeyboard);
        #endregion
        #region GetKeyDown
        OnKBAOneDownInputPress?.Invoke(AlphaOneKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBAOneUpInputPress?.Invoke(AlphaOneKeyboardUp);
        #endregion
        #endregion
        #region 2
        #region GetKey
        OnKBATwoInputPress?.Invoke(AlphaTwoKeyboard);
        #endregion
        #region GetKeyDown
        OnKBATwoDownInputPress?.Invoke(AlphaTwoKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBATwoUpInputPress?.Invoke(AlphaTwoKeyboardUp);
        #endregion
        #endregion
        #region 3
        #region GetKey
        OnKBAThreeInputPress?.Invoke(AlphaThreeKeyboard);
        #endregion
        #region GetKeyDown
        OnKBAThreeDownInputPress?.Invoke(AlphaThreeKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBAThreeUpInputPress?.Invoke(AlphaThreeKeyboardUp);
        #endregion
        #endregion
        #region 4
        #region GetKey
        OnKBAFourInputPress?.Invoke(AlphFourKeyboard);
        #endregion
        #region GetKeyDown
        OnKBAFourDownInputPress?.Invoke(AlphFourKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBAFourUpInputPress?.Invoke(AlphFourKeyboardUp);
        #endregion
        #endregion
        #region 5
        #region GetKey
        OnKBAFiveInputPress?.Invoke(AlphaFiveKeyboard);
        #endregion
        #region GetKeyDown
        OnKBAFiveDownInputPress?.Invoke(AlphaFiveKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBAFiveUpInputPress?.Invoke(AlphaFiveKeyboardUp);
        #endregion
        #endregion
        #region 6
        #region GetKey
        OnKBASixInputPress?.Invoke(AlphaSixKeyboard);
        #endregion
        #region GetKeyDown
        OnKBASixDownInputPress?.Invoke(AlphaSixKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBASixUpInputPress?.Invoke(AlphaSixKeyboardUp);
        #endregion
        #endregion
        #region 7
        #region GetKey
        OnKBASevenInputPress?.Invoke(AlphaSevenKeyboard);
        #endregion
        #region GetKeyDown
        OnKBASevenDownInputPress?.Invoke(AlphaSevenKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBASevenUpInputPress?.Invoke(AlphaSevenKeyboardUp);
        #endregion
        #endregion
        #region 8
        #region GetKey
        OnKBAEightInputPress?.Invoke(AlphaEightKeyboard);
        #endregion
        #region GetKeyDown
        OnKBAEightDownInputPress?.Invoke(AlphaEightKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBAEightUpInputPress?.Invoke(AlphaEightKeyboardUp);
        #endregion
        #endregion
        #region 9
        #region GetKey
        OnKBANineInputPress?.Invoke(AlphaNineKeyboard);
        #endregion
        #region GetKeyDown
        OnKBANineDownInputPress?.Invoke(AlphaNineKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBANineUpInputPress?.Invoke(AlphaNineKeyboardUp);
        #endregion
        #endregion
        #region 0
        #region GetKey
        OnKBAZeroInputPress?.Invoke(AlphaZeroKeyboard);
        #endregion
        #region GetKeyDown
        OnKBAZeroDownInputPress?.Invoke(AlphaZeroKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBANineUpInputPress?.Invoke(AlphaZeroKeyboardUp);
        #endregion
        #endregion
        #endregion
        #region DirectionalArrow
        #region DownArrow
        #region GetKey
        OnDownArrowInputPress?.Invoke(DownArrow);
        #endregion
        #region GetKeyDown
        OnDownArrowDownInputPress?.Invoke(DownArrowDown);
        #endregion
        #region GetKeyUp
        OnDownArrowUpInputPress?.Invoke(DownArrowUp);
        #endregion
        #endregion
        #region LeftArrow
        #region GetKey
        OnLeftArrowInputPress?.Invoke(LeftArrow);
        #endregion
        #region GetKeyDown
        OnLeftArrowDownInputPress?.Invoke(LeftArrowDown);
        #endregion
        #region GetKeyUp
        OnLeftArrowUpInputPress?.Invoke(LeftArrowUp);
        #endregion
        #endregion
        #region RightArrow
        #region GetKey
        OnRightArrowInputPress?.Invoke(RightArrow);
        #endregion
        #region GetKeyDown
        OnRightArrowDownInputPress?.Invoke(RightArrowDown);
        #endregion
        #region GetKeyUp
        OnRightArrowUpInputPress?.Invoke(RightArrowUp);
        #endregion
        #endregion
        #region UpArrow
        #region GetKey
        OnUpArrowInputPress?.Invoke(UpArrow);
        #endregion
        #region GetKeyDown
        OnUpArrowDownInputPress?.Invoke(UpArrowDown);
        #endregion
        #region GetKeyUp
        OnUpArrowUpInputPress?.Invoke(UpArrowUp);
        #endregion
        #endregion
        #endregion
        #region Keypad
        #region 0
        #region GetKey
        OnKPZeroInputPress?.Invoke(KPZeroKeyboard);
        #endregion
        #region GetKeyDown
        OnKPAZeroDownInputPress?.Invoke(KPZeroKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKPZeroUpInputPress?.Invoke(KPZeroKeyboardUp);
        #endregion
        #endregion
        #region 1
        #region GetKey
        OnKPOneInputPress?.Invoke(KeypadOneKeyboard);
        #endregion
        #region GetKeyDown
        OnKPOneDownInputPress?.Invoke(KeypadOneKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKPOneUpInputPress?.Invoke(KeypadOneKeyboardUp);
        #endregion
        #endregion
        #region 2
        #region GetKey
        OnKPTwoInputPress?.Invoke(KeypadTwoKeyboard);
        #endregion
        #region GetKeyDown
        OnKPTwoDownInputPress?.Invoke(KeypadTwoKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKPTwoUpInputPress?.Invoke(KeypadTwoKeyboardUp);
        #endregion
        #endregion
        #region 3
        #region GetKey
        OnKPThreeInputPress?.Invoke(KeypadThreeKeyboard);
        #endregion
        #region GetKeyDown
        OnKPThreeDownInputPress?.Invoke(KeypadThreeKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKPThreeUpInputPress?.Invoke(KeypadThreeKeyboardUp);
        #endregion
        #endregion
        #region 4
        #region GetKey
        OnKPFourInputPress?.Invoke(KeypadFourKeyboard);
        #endregion
        #region GetKeyDown
        OnKPFourDownInputPress?.Invoke(KeypadFourKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKPFourUpInputPress?.Invoke(KeypadFourKeyboardUp);
        #endregion
        #endregion
        #region 5
        #region GetKey
        OnKPFiveInputPress?.Invoke(KeypadFiveKeyboard);
        #endregion
        #region GetKeyDown
        OnKPFiveDownInputPress?.Invoke(KeypadFiveKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKPFiveUpInputPress?.Invoke(KeypadFiveKeyboardUp);
        #endregion
        #endregion
        #region 6
        #region GetKey
        OnKPSixInputPress?.Invoke(KeypadSixKeyboard);
        #endregion
        #region GetKeyDown
        OnKPSixDownInputPress?.Invoke(KeypadSixKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKPSixUpInputPress?.Invoke(KeypadSixKeyboardUp);
        #endregion
        #endregion
        #region 7
        #region GetKey
        OnKPSevenInputPress?.Invoke(KeypadSevenKeyboard);
        #endregion
        #region GetKeyDown
        OnKPSevenDownInputPress?.Invoke(KeypadSevenKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKPSevenUpInputPress?.Invoke(KeypadSevenKeyboardUp);
        #endregion
        #endregion
        #region 8
        #region GetKey
        OnKPEightInputPress?.Invoke(KeypadEightKeyboard);
        #endregion
        #region GetKeyDown
        OnKPEightDownInputPress?.Invoke(KeypadEightKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKPEightUpInputPress?.Invoke(KeypadEightKeyboardUp);
        #endregion
        #endregion
        #region 9
        #region GetKey
        OnKPNineInputPress?.Invoke(KeypadNineKeyboard);
        #endregion
        #region GetKeyDown
        OnKPNineDownInputPress?.Invoke(KeypadNineKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKPNineUpInputPress?.Invoke(KeypadNineKeyboardUp);
        #endregion
        #endregion
        #endregion
        #region Lettres
        #region A
        #region GetKey
        OnKBAInputPress?.Invoke(AKeyboard);
        #endregion
        #region GetKeyDown
        OnKBADownInputPress?.Invoke(AKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBAUpInputPress?.Invoke(AKeyboardUp);
        #endregion
        #endregion
        #region Z
        #region GetKey
        OnKBZInputPress?.Invoke(ZKeyboard);
        #endregion
        #region GetKeyDown
        OnKBZDownInputPress?.Invoke(ZKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBZUpInputPress?.Invoke(ZKeyboardUp);
        #endregion
        #endregion
        #region E
        #region GetKey
        OnKBEInputPress?.Invoke(EKeyboard);
        #endregion
        #region GetKeyDown
        OnKBEDownInputPress?.Invoke(EKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBEUpInputPress?.Invoke(EKeyboardUp);
        #endregion
        #endregion
        #region R
        #region GetKey
        OnKBRInputPress?.Invoke(RKeyboard);
        #endregion
        #region GetKeyDown
        OnKBRDownInputPress?.Invoke(RKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBRUpInputPress?.Invoke(RKeyboardUp);
        #endregion
        #endregion
        #region T
        #region GetKey
        OnKBTInputPress?.Invoke(TKeyboard);
        #endregion
        #region GetKeyDown
        OnKBTDownInputPress?.Invoke(TKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBTUpInputPress?.Invoke(TKeyboardUp);
        #endregion
        #endregion
        #region y
        #region GetKey
        OnKBYInputPress?.Invoke(YKeyboard);
        #endregion
        #region GetKeyDown
        OnKBYDownInputPress?.Invoke(YKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBYUpInputPress?.Invoke(YKeyboardUp);
        #endregion
        #endregion
        #region U
        #region GetKey
        OnKBUInputPress?.Invoke(UKeyboard);
        #endregion
        #region GetKeyDown
        OnKBUDownInputPress?.Invoke(UKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBUUpInputPress?.Invoke(UKeyboardUp);
        #endregion
        #endregion
        #region I
        #region GetKey
        OnKBIInputPress?.Invoke(IKeyboard);
        #endregion
        #region GetKeyDown
        OnKBIDownInputPress?.Invoke(IKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBIUpInputPress?.Invoke(IKeyboardUp);
        #endregion
        #endregion
        #region O
        #region GetKey
        OnKBOInputPress?.Invoke(OKeyboard);
        #endregion
        #region GetKeyDown
        OnKBOInputPress?.Invoke(OKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBOInputPress?.Invoke(OKeyboardUp);
        #endregion
        #endregion
        #region P
        #region GetKey
        OnKBPInputPress?.Invoke(PKeyboard);
        #endregion
        #region GetKeyDown
        OnKBPDownInputPress?.Invoke(PKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBPUpInputPress?.Invoke(PKeyboardUp);
        #endregion
        #endregion
        #region Q
        #region GetKey
        OnKBQInputPress?.Invoke(QKeyboard);
        #endregion
        #region GetKeyDown
        OnKBQDownInputPress?.Invoke(QKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBQUpInputPress?.Invoke(QKeyboardUp);
        #endregion
        #endregion
        #region S
        #region GetKey
        OnKBSInputPress?.Invoke(SKeyboard);
        #endregion
        #region GetKeyDown
        OnKBSDownInputPress?.Invoke(SKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBSUpInputPress?.Invoke(SKeyboardUp);
        #endregion
        #endregion
        #region D
        #region GetKey
        OnKBDInputPress?.Invoke(DKeyboard);
        #endregion
        #region GetKeyDown
        OnKBDInputPress?.Invoke(DKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBDInputPress?.Invoke(DKeyboardUp);
        #endregion
        #endregion
        #region F
        #region GetKey
        OnKBFInputPress?.Invoke(FKeyboard);
        #endregion
        #region GetKeyDown
        OnKBFDownInputPress?.Invoke(FKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBFIUpnputPress?.Invoke(FKeyboardUp);
        #endregion
        #endregion
        #region G
        #region GetKey
        OnKBGInputPress?.Invoke(GKeyboard);
        #endregion
        #region GetKeyDown
        OnKBGDownInputPress?.Invoke(GKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBGUpInputPress?.Invoke(GKeyboardUp);
        #endregion
        #endregion
        #region H
        #region GetKey
        OnKBHInputPress?.Invoke(HKeyboard);
        #endregion
        #region GetKeyDown
        OnKBHDownInputPress?.Invoke(HKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBHUpInputPress?.Invoke(HKeyboardUp);
        #endregion
        #endregion
        #region J
        #region GetKey
        OnKBJInputPress?.Invoke(JKeyboard);
        #endregion
        #region GetKeyDown
        OnKBJDownInputPress?.Invoke(JKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBJUpInputPress?.Invoke(JKeyboardUp);
        #endregion
        #endregion
        #region K
        #region GetKey
        OnKBKInputPress?.Invoke(KKeyboard);
        #endregion
        #region GetKeyDown
        OnKBKDownInputPress?.Invoke(KKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBKUpInputPress?.Invoke(KKeyboardUp);
        #endregion
        #endregion
        #region L
        #region GetKey
        OnKBLInputPress?.Invoke(LKeyboard);
        #endregion
        #region GetKeyDown
        OnKBLDownInputPress?.Invoke(LKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBLUpInputPress?.Invoke(LKeyboardUp);
        #endregion
        #endregion
        #region M
        #region GetKey
        OnKBMInputPress?.Invoke(MKeyboard);
        #endregion
        #region GetKeyDown
        OnKBMDownInputPress?.Invoke(MKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBMUpInputPress?.Invoke(MKeyboardUp);
        #endregion
        #endregion
        #region W
        #region GetKey
        OnKBWInputPress?.Invoke(WKeyboard);
        #endregion
        #region GetKeyDown
        OnKBWDownInputPress?.Invoke(WKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBWUpInputPress?.Invoke(WKeyboardUp);
        #endregion
        #endregion
        #region X
        #region GetKey
        OnKBXInputPress?.Invoke(XKeyboard);
        #endregion
        #region GetKeyDown
        OnKBXDownInputPress?.Invoke(XKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBXUpInputPress?.Invoke(XKeyboardUp);
        #endregion
        #endregion
        #region C
        #region GetKey
        OnKBCInputPress?.Invoke(CKeyboard);
        #endregion
        #region GetKeyDown
        OnKBCDownInputPress?.Invoke(CKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBCUpInputPress?.Invoke(CKeyboardUp);
        #endregion
        #endregion
        #region V
        #region GetKey
        OnKBVInputPress?.Invoke(VKeyboard);
        #endregion
        #region GetKeyDown
        OnKBVDownInputPress?.Invoke(VKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBVUpInputPress?.Invoke(VKeyboardUp);
        #endregion
        #endregion
        #region B
        #region GetKey
        OnKBBInputPress?.Invoke(BKeyboard);
        #endregion
        #region GetKeyDown
        OnKBBDownInputPress?.Invoke(BKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBBUpInputPress?.Invoke(BKeyboardUp);
        #endregion
        #endregion
        #region N
        #region GetKey
        OnKBNInputPress?.Invoke(NKeyboard);
        #endregion
        #region GetKeyDown
        OnKBNDownInputPress?.Invoke(NKeyboardDown);
        #endregion
        #region GetKeyUp
        OnKBNUpInputPress?.Invoke(NKeyboardUp);
        #endregion
        #endregion
        #endregion
        #region SpecialKey
        #region Escape
        #region GetKey
        OnEscapeClickInputPress?.Invoke(Escape);
        #endregion
        #region GetKeyDown
        OnEscapeClickDownInputPress?.Invoke(EscapeDown);
        #endregion
        #region GetKeyUp
        OnEscapeClickUpInputPress?.Invoke(EscapeUp);
        #endregion
        #endregion
        #region Space
        #region GetKey
        OnSpaceClickInputPress?.Invoke(Space);
        #endregion
        #region GetKeyDown
        OnSpaceClickDownInputPress?.Invoke(SpaceDown);
        #endregion
        #region GetKeyUp
        OnSpaceClickUpInputPress?.Invoke(SpaceUp);
        #endregion
        #endregion

        #endregion
        #endregion        
    }
    #endregion    
}

[Serializable]
public struct AxisToButtonTool
{
    [SerializeField] int lastInput;

    public int AxisToInput(string _axisName)
    {
        int _newInput = (int)Input.GetAxis(_axisName);

        bool _isDifferent = (_newInput != lastInput);
        lastInput = _newInput;
        if (_isDifferent)
        {
            return _newInput;
        }
        return 0;
    }
}