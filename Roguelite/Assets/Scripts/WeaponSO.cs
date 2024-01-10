using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewWeapon", menuName = "Weapons/WeaponData", order = 1)]
public class WeaponSO : ScriptableObject
{
    public bool IsMelee = true;
    public bool AttackInLookingDirection = true;
    public Sprite WeaponSprite;
    public float Damage = 10;
    [Tooltip("Attacks per second")]
    public float AttackSpeed = 1;
    public float AttackColliderRadius = 2.5f;
    public int MaxTargets = 999;
}
