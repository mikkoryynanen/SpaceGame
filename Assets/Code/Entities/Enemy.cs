using UnityEngine;

public class Enemy : Entity, IDamageable
{

    public override void Start()
    {
        base.Start();
        CanGoOutOfBounds = true;
    }

    public void TakeDamage(float amount)
    {
        Debug.Log($"{this.gameObject.name} took {amount} damage");
        // Stat CurrentHealthStat = _statsContainer.GetStat(StatType.Health);
        // CurrentHealthStat.ReduceCurrentValue(amount);
    }

    public override void Update()
    {
        MoveTo(new Vector2(-1, 0));

        base.Update();
    }
}
