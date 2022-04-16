using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField]
    public GameObject projectile;
    [SerializeField]
    private float fireRate = 20;
    //private float interval;
    private bool isShooting = true, startCoroutine = false;
    void Start()
    {
        
    }

    void Shoot()
    {
        Instantiate(projectile, new Vector3(transform.position.x, transform.position.y - 1.5f, transform.position.z), transform.rotation);
    }

    void Update()
    {
        if (isShooting)
        {
            Shoot();
            isShooting = false;
        }
        else if (!startCoroutine)
            StartCoroutine(WaitForTime(fireRate));
    }
    IEnumerator WaitForTime(float timeToWait)
    {
        startCoroutine = true;
        yield return new WaitForSeconds(timeToWait);
        isShooting = true;
        startCoroutine = false;
    }

}
