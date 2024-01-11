using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private WeaponSO weaponSO;
    private SpriteRenderer weaponModelRenderer;
    private Animator animator;
    private CircleCollider2D attackCollider;
    private float timer;
    private void Start()
    {
        weaponModelRenderer=GetComponentInChildren<SpriteRenderer>();
        animator = GetComponent<Animator>();
        attackCollider=GetComponent<CircleCollider2D>();
        attackCollider.radius = weaponSO.AttackColliderRadius;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(Input.GetMouseButtonDown(0) && timer > 1/weaponSO.AttackSpeed)
        {
            Attack();
        }
        
    }
    public void Attack()
    {
        timer = 0;
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
        animator.Play("Attack");
        animator.speed = weaponSO.AttackSpeed;
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
        if(transform.parent.localScale.x > 0)
        {
            if(transform.position.x - enemy.position.x < 0)
            {
                return true;
            }
        }
        else
        {
            if(transform.position.x - enemy.position.x > 0)
            {
                return true;
            }
        }

        return false;
    }
    private IEnumerator DisableColliderAfterTime()
    {
        yield return new WaitForSeconds(1/weaponSO.AttackSpeed);
        attackCollider.enabled = false;
    }
}
