using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float timeToDisappear;
    private float damage;
    private float speed;

    private float timer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        PlayerTakeHit takeHit = collision.gameObject.GetComponent<PlayerTakeHit>();
        if(!takeHit) return;
        Debug.Log("TakeHit detected");

        takeHit.TakeDamage(damage);
        gameObject.SetActive(false);
    }

    private void Update()
    {
        Vector3 direction = transform.localEulerAngles;
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        timer += Time.deltaTime;
        if(timer >= timeToDisappear)
        {
            timer = 0;
            gameObject.SetActive(false);
        }
    }
    public void SetDamage(float damage)
    {
        this.damage = damage;
    }
    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }
    public void SetRotation(Vector3 euler)
    {
        transform.localEulerAngles = euler;
    }
    public void SetTimeToDisappear(float time)
    {
        timeToDisappear = time;
    }

}
