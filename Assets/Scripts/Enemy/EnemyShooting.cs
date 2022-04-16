using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField]
    private float yOffset = -1.5f;
    [SerializeField]
    public GameObject projectile;
    [SerializeField]
    private float fireRate = 20;
    //private float interval;
    private bool isShooting = true, startCoroutine = false;
    [SerializeField]
    private bool burst = false;
    [SerializeField]
    private int burstShots = 1;
    private int curShots;

    private void Start()
    {
        curShots = burstShots;
    }

    void Shoot()
    {
        Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + yOffset, transform.position.z), transform.rotation);
    }

    void Update()
    {
        if (isShooting & !burst)
        {
            Shoot();
            isShooting = false;
        }
        else if (curShots > 0 && isShooting && !startCoroutine)
        {
            Shoot();
            curShots--;
            StartCoroutine(WaitForTime(.5f));
        }
        else if (!startCoroutine)
        {
            StartCoroutine(WaitForTime(fireRate));
            curShots = burstShots;
        }
    }
    IEnumerator WaitForTime(float timeToWait)
    {
        startCoroutine = true;
        yield return new WaitForSeconds(timeToWait);
        isShooting = true;
        startCoroutine = false;
    }

}
