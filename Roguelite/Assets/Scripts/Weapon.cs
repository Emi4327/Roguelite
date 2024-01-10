using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private WeaponSO weaponSO;
    private SpriteRenderer weaponModelRenderer;
    private CircleCollider2D attackCollider;
    private void Start()
    {
        weaponModelRenderer=GetComponentInChildren<SpriteRenderer>();
        attackCollider=GetComponent<CircleCollider2D>();
        attackCollider.radius = weaponSO.AttackColliderRadius;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)) Attack();
    }
    public void Attack()
    {
        if(weaponSO.IsMelee)
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
        attackCollider.enabled = true;
        StartCoroutine(DisableColliderAfterTime());
    }
    public void AttackRangedWeapon()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemyTakeHit = collision.GetComponent<EnemyTakeHit>();
        if(!enemyTakeHit) return;
        if(weaponSO.AttackInLookingDirection && IsEnemyInLookingDirection(collision.transform))
        {
            enemyTakeHit.TakeHit(weaponSO.Damage);
        }
        else if(!weaponSO.AttackInLookingDirection)
        {
            enemyTakeHit.TakeHit(weaponSO.Damage);
        }

    }
    private bool IsEnemyInLookingDirection(Transform enemy)
    {
        
        return false;
    }
    private IEnumerator DisableColliderAfterTime()
    {
        yield return new WaitForSeconds(0.021f);
        attackCollider.enabled = false;
    }
}
