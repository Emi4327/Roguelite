using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EnemyTakeHit : MonoBehaviour
{
    public void TakeHit(float damage)
    {
        Debug.Log(gameObject.name + " Take hit: " + damage.ToString());
    }
}
