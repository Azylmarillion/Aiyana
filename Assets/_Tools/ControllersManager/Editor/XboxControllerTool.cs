using UnityEngine;
using UnityEditor;

public class XboxControllerTool : EditorWindow
{
    #region F/P
    Texture XboxTexture = null;
    #endregion

    #region XboxControllerMapping

    [MenuItem("Tools/ControllersManager/XBox Controller Mapping/Android Mapping")]
    public static void ShowAndroid()
    {
        XboxControllerTool _android = (XboxControllerTool)GetWindow(typeof(XboxControllerTool));
        _android.InitMenu("Android");
        _android.Show();
    }
    //
    [MenuItem("Tools/ControllersManager/XBox Controller Mapping/Linux Mapping")]
    public static void ShowLinux()
    {      
        XboxControllerTool _window = (XboxControllerTool)GetWindow(typeof(XboxControllerTool));
        _window.InitMenu("Linux");
        _window.Show();
    }
    //
    [MenuItem("Tools/ControllersManager/XBox Controller Mapping/Mac Mapping")]
    public static void ShowMac()
    {
        XboxControllerTool _window = (XboxControllerTool)GetWindow(typeof(XboxControllerTool));
        _window.InitMenu("Mac");
        _window.Show();
    }
    //
    [MenuItem("Tools/ControllersManager/XBox Controller Mapping/Windows Mapping")]
    public static void ShowWindow()
    {
        XboxControllerTool _window = (XboxControllerTool)GetWindow(typeof(XboxControllerTool));
        _window.InitMenu("Windows");
        _window.Show();
    }

    void InitMenu(string _OS)
    {
       XboxTexture = Resources.Load(_OS) as Texture;
    }  

    void OnGUI()
    {        
        GUI.color = Color.red;
        if (GUILayout.Button("X"))
        {
            Close();
        }
        GUI.color = Color.white;

        EditorGUILayout.Space();

        if (XboxTexture)
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            Rect _textureRect = GUILayoutUtility.GetRect(XboxTexture.width/1.5f, XboxTexture.height/1.5f);
            EditorGUI.DrawPreviewTexture(_textureRect, XboxTexture);

            EditorGUILayout.EndHorizontal();
        }
        else
        {
            EditorGUILayout.HelpBox("No Texture founded, reload package!!!!", MessageType.Error);
        }
    }
    #endregion
}