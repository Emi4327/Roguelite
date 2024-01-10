using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealingDummy : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float damage=30;
    [SerializeField] private float bulletSpawnInterval=1;
    [SerializeField] private float bulletSpeed=10;
    [SerializeField] private float timeToDisappear=4;


    private float timer;
    private List<GameObject> bulletPool = new List<GameObject>();
    private int bulletPoolSize = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= bulletSpawnInterval)
        {
            SpawnBullet();
            timer = 0;
        }
    }

    private void SpawnBullet()
    {
        if(bulletPool.Count < bulletPoolSize)
        {
            CreateNewBullet();
        }
        else
        {
            SpawnBulletFromPool();
        }
    }
    private void CreateNewBullet()
    {
        GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        bulletPool.Add(newBullet);
        SetBullet(newBullet.GetComponent<Bullet>());
    }
    private void SpawnBulletFromPool()
    {
        foreach(var bullet in  bulletPool)
        {
            if(bullet.gameObject.activeSelf) continue;
            bullet.SetActive(true);
            SetBullet(bullet.GetComponent<Bullet>());
            break;
        }
    }
    private void SetBullet(Bullet bullet)
    {
        bullet.transform.position = bulletSpawnPoint.position;
        bullet.SetDamage(damage);
        bullet.SetRotation(bulletSpawnPoint.localEulerAngles);
        bullet.SetSpeed(bulletSpeed);
        bullet.SetTimeToDisappear(timeToDisappear);
    }
}
