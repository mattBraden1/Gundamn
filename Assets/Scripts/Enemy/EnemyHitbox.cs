using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : MonoBehaviour
{
    [SerializeField]
    private float contactDamage = 20;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerHealth>() != null)
            other.gameObject.GetComponent<PlayerHealth>().takeDamage(contactDamage);
    }
}
