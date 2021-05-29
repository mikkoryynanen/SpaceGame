using UnityEngine;

[RequireComponent(typeof(Shooter))]
public class Player : Entity
{    

    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        MoveTo(new Vector2(horizontal, vertical));

        base.Update();
    }
    
}
