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
        Stat CurrentHealthStat = _statsContainer.GetStat(StatType.Health);
        CurrentHealthStat.ReduceCurrentValue(amount);
        Debug.Log($"{this.gameObject.name} health: {CurrentHealthStat.CurrentValue}/{CurrentHealthStat.MaxValue}");

        if (CurrentHealthStat.CurrentValue <= 0)
        {
            GUImanager.OnPointsReceivedEvent.Invoke();
            gameObject.SetActive(false);
        }
    }

    public override void Update()
    {
        MoveTo(new Vector2(-1, 0));

        base.Update();
    }
}
