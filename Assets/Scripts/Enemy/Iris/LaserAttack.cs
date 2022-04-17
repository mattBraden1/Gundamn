using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAttack : MonoBehaviour
{
    private bool startCoroutine = false;
    [SerializeField]
    private float frequency = 30;
    [SerializeField]
    private GameObject laser;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForTime(frequency));
    }

    // Update is called once per frame
    void Update()
    {
        if (!startCoroutine)
            StartCoroutine(WaitForTime(frequency));
    }

    IEnumerator WaitForTime(float timeToWait)
    {
        startCoroutine = true;
        yield return new WaitForSeconds(timeToWait);
        startCoroutine = false;
        fireLaser();
    }

    private void fireLaser()
    {
        GameObject templaser = Instantiate(laser, new Vector3(transform.position.x,transform.position.y-17,transform.position.z), laser.transform.rotation, transform);
        Destroy(templaser, 4);
    }
}
