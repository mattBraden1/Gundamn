using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField]
    private GameObject playerBullet;
    [SerializeField]
    private int fireRate = 2;
    private int curFireRate;

    // Start is called before the first frame update
    void Start()
    {
        curFireRate = fireRate;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Fire1") != 0 && curFireRate <= 0)
        {
            Instantiate(playerBullet, new Vector3(transform.position.x, transform.position.y+1.5f, transform.position.z), transform.rotation);
            curFireRate = fireRate; 
        }
        else
            curFireRate--;
    }
}
