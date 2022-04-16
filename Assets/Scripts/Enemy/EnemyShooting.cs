using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField]
    public GameObject projectile;
    [SerializeField]
    private float fireRate = 20;
    private float interval;
    void Start()
    {
        interval = fireRate;
    }

    void Shoot()
    {
        Instantiate(projectile, new Vector3(transform.position.x, transform.position.y - 1.5f, transform.position.z), transform.rotation);
    }

    void Update()
    {
        if (interval >= fireRate)
        {
            Shoot();
            interval = 0;
        }
        else
            interval += 1;
    }


}
