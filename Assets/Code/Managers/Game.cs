using System.Collections;
using UnityEngine;

public class Game : MonoBehaviour 
{
    public GUImanager guiManager;
    bool _menuShowing = false;

    void Start()
    {
        guiManager = GetComponent<GUImanager>();
    }

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_menuShowing)
        {
            guiManager.ShowStaMenu();
            _menuShowing = true;
        }        
        else if (Input.GetKeyDown(KeyCode.Escape) && _menuShowing)
        {
            guiManager.HideStaMenu();
            _menuShowing = false;
        }
    }

    public static Vector2 GetScreenBounds()
    {
        Camera cam = Camera.main;
        return cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, cam.transform.position.z));
    }    
}