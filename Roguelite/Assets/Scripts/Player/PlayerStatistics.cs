using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatistics : MonoBehaviour
{
    [SerializeField] private PlayerStatisticsSO playerStatsSO;
    public PlayerStatisticsSO PlayerStatsSO { get { return playerStatsSO; } }

    private UIHelper uiHelper;
    public UIHelper UIHelper { get { return uiHelper; } }

    public float Health;
    public float Armor;
    public float Speed;

    private float maxHealth;
    private float maxArmor;
    private void Awake()
    {
        uiHelper = GetComponent<UIHelper>();
        Health = playerStatsSO.MaxHealth;
        Armor = playerStatsSO.MaxArmor;
        Speed = playerStatsSO.Speed;
        maxHealth = playerStatsSO.MaxHealth;
        maxArmor = playerStatsSO.MaxArmor;

        uiHelper.HealthSlider.maxValue = maxHealth;
        uiHelper.HealthSlider.value = maxHealth;
        uiHelper.ArmorSlider.maxValue = maxArmor;
        uiHelper.ArmorSlider.value = maxArmor;
    }

}
