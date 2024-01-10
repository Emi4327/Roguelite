using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewWeapon", menuName = "Weapons/WeaponData", order = 1)]
public class WeaponSO : ScriptableObject
{
    public bool isMelee = true;
    public bool attackInLookingDirection = true;
    public Sprite weaponSprite;
    public float Damage = 10;
    [Tooltip("Attacks per second")]
    public float AttackSpeed = 1;

}
