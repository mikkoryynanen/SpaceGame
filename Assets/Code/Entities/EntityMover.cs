using UnityEngine;

public class EntityMover : MonoBehaviour 
{
    public float speed = 10f;
    
    public bool CanGoOutOfBounds { get; protected set; }

    Vector2 _movementVector = Vector2.zero;
    Vector2 _screenBounds;
    Vector2 _objectBounds;

    public virtual void Start() 
    {
        _screenBounds = Game.GetScreenBounds();

        // SpriteRenderer renderer;
        // TryGetComponent<SpriteRenderer>(out renderer);
        // if (renderer != null)
        // {
        //     _objectBounds = renderer.sprite.bounds.extents;
        // }

        CanGoOutOfBounds = false;
    }

    public void MoveTo(Vector2 direction)
    {
        _movementVector = direction;
    }

    public virtual void Update() 
    {        
        if (_movementVector == Vector2.zero)
        {
            return;
        }

        transform.Translate(new Vector2(_movementVector.x * speed * Time.deltaTime, _movementVector.y * speed * Time.deltaTime));
    }

    public virtual void LateUpdate()
    {
        if (!CanGoOutOfBounds)
        {
            float objPosX = Mathf.Clamp(transform.position.x, -_screenBounds.x, _screenBounds.x);
            float objPosY = Mathf.Clamp(transform.position.y, -_screenBounds.y, _screenBounds.y);
            transform.position = new Vector2(objPosX, objPosY);            
        }

        if (transform.position.x > _screenBounds.x || transform.position.y > _screenBounds.y)
        {
            gameObject.SetActive(false);
        }
    }
}