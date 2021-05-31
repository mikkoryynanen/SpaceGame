using UnityEngine;

public class Projectile : Entity
{
    public override void Start()
    {
        base.Start();
        CanGoOutOfBounds = true;
    }

    public override void Update()
    {
        MoveTo(new UnityEngine.Vector2(1, 0));

        base.Update();

        RaycastHit2D hit = Physics2D.Raycast(transform.
        position, transform.forward, 2f);
        if (hit.collider != null)
        {
            IDamageable damageable = hit.collider.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(50);
            }

            gameObject.SetActive(false);
        }
    }
}