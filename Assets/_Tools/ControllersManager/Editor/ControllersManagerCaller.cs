using UnityEditor;
using UnityEngine;

public class ControllersManagerCaller : Editor
{

    #region KeyboardInputsManager
    [MenuItem("Tools/ControllersManager/Call KeyboardInputsManager")]    
    public static void CallManager()
    {
        if (FindObjectOfType<KeyboardInputsManager>()) return;
        GameObject _manager = new GameObject("KeyboardInputsManager", typeof(KeyboardInputsManager));
        Selection.activeGameObject = _manager;
    }
    #endregion   

    #region XboxAndroidInputManager
    [MenuItem("Tools/ControllersManager/Call XboxControllerInputManagerAndroid")]
    public static void CallXboxAndroidManager()
    {
        if (FindObjectOfType<XboxControllerInputManagerAndroid>()) return;
        GameObject _manager = new GameObject("XboxControllerInputManagerAndroid", typeof(XboxControllerInputManagerAndroid));
        Selection.activeGameObject = _manager;
    }
    #endregion

    #region XboxLinuxInputManager
    [MenuItem("Tools/ControllersManager/Call XboxControllerInputManagerLinux")]
    public static void CallXboxLinuxManager()
    {
        if (FindObjectOfType<XboxControllerInputManagerLinux>()) return;
        GameObject _manager = new GameObject("XboxControllerInputManagerLinux", typeof(XboxControllerInputManagerLinux));
        Selection.activeGameObject = _manager;
    }
    #endregion

    #region XboxMACInputManager
    [MenuItem("Tools/ControllersManager/Call XboxControllerInputManagerMAC")]
    public static void CallXboxMACManager()
    {
        if (FindObjectOfType<XboxControllerInputManagerMAC>()) return;
        GameObject _manager = new GameObject("XboxControllerInputManagerMAC", typeof(XboxControllerInputManagerMAC));
        Selection.activeGameObject = _manager;
    }
    #endregion

    #region XboxWindowsInputManager
    [MenuItem("Tools/ControllersManager/Call XboxControllerInputManagerWindows")]
    public static void CallXboxWindowsManager()
    {
        if (FindObjectOfType<XboxControllerInputManagerWindows>()) return;
        GameObject _manager = new GameObject("XboxControllerInputManagerWindows", typeof(XboxControllerInputManagerWindows));
        Selection.activeGameObject = _manager;
    }
    #endregion

    #region SwitchControllerManager
    [MenuItem("Tools/ControllersManager/Call Switch Controller Manager")]
    public static void CallSwitchManager()
    {
        if (!FindObjectOfType<KeyboardInputsManager>() && !FindObjectOfType<SwitchControllerManager>())
        {
            GameObject _manager = new GameObject("InputManager", typeof(KeyboardInputsManager));
            Selection.activeGameObject = _manager;
        }
        if (FindObjectOfType<SwitchControllerManager>()) return;
        var _inputManager = FindObjectOfType<KeyboardInputsManager>();
        GameObject _switchmanager = new GameObject("SwitchControllerManager", typeof(SwitchControllerManager));
        _switchmanager.transform.parent = _inputManager.transform;
        Debug.Log("Switch controller manager added to InputManager!");
    }
    #endregion
}