using UnityEngine;

public class ObjectMover : MonoBehaviour 
{
    public float speed = 100f;
    public Vector2 direction = new Vector2(1, 0);

    private void Update() 
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }    
}