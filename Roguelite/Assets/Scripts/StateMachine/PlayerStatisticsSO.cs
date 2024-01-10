using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Statistics/playerStats", order = 1)]
public class PlayerStatisticsSO : ScriptableObject
{
    public float MaxHealth = 50;
    public float MaxArmor = 100;
    public float Speed = 10;
    
}
