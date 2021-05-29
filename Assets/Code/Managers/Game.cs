using UnityEngine;

public class Game : MonoBehaviour 
{
    public static Vector2 GetScreenBounds()
    {
        Camera cam = Camera.main;
        return cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, cam.transform.position.z));
    }    
}