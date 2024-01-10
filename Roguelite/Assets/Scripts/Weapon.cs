using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private WeaponSO weaponSO;
    private SpriteRenderer weaponModelRenderer;
    private Collider2D attackCollider;
    void Start()
    {
        weaponModelRenderer=GetComponentInChildren<SpriteRenderer>();
    }
    
    public void ChooseWeapon(WeaponSO weapon)
    {

    }
    public void Attack()
    {
        if(weaponSO.isMelee)
        {
            AttackMeleeWeapon();
        }
        else
        {
            AttackRangedWeapon();
        }
    }
    public void AttackMeleeWeapon()
    {

    }
    public void AttackRangedWeapon()
    {

    }
}
