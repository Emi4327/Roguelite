using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeHit : MonoBehaviour
{
    private UIHelper uiHelper;
    private PlayerStatistics playerStatistics;

    private void Awake()
    {
        playerStatistics = GetComponent<PlayerStatistics>();
        uiHelper = GetComponent<UIHelper>();
    }

    public void TakeDamage(float damage)
    {
        float damageTaken = damage;
        if(playerStatistics.Armor > 0)
        {
            ReduceArmor(damageTaken);
        }
        else
        {
            ReduceHealth(damageTaken);
        }

        UpdateSlidersValues();
    }
    private void ReduceArmor(float armorToReduce)
    {
        if(armorToReduce > playerStatistics.Armor)
        {
            armorToReduce -= playerStatistics.Armor;
            playerStatistics.Armor = 0;

            ReduceHealth(armorToReduce);
        }
        else
        {
            playerStatistics.Armor -= armorToReduce;
        }
    }
    private void ReduceHealth(float healthToReduce)
    {

        playerStatistics.Health -= healthToReduce;
        if(playerStatistics.Health <= 0)
        {
            playerStatistics.Health = 0;
            Death();
        }
    }
    private void UpdateSlidersValues()
    {
        playerStatistics.UIHelper.ArmorSlider.value = playerStatistics.Armor;
        playerStatistics.UIHelper.HealthSlider.value = playerStatistics.Health;
    }
    private void Death()
    {
        uiHelper.GameOverMenu.SetActive(true);
    }
}
