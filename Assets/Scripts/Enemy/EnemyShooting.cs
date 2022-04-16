using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject Enemy;
    public Transform player;
    [SerializeField]
    public float speed = 1;
    public float bulletImpulse = 20.0f;
    [SerializeField]
    private bool onRange = true;
    public Rigidbody projectile;
    void Start()
    {
    }

    void Shoot()
    {

        if (onRange)
        {
            var dir = Vector3.zero;
            dir = player.transform.position - transform.position;
            Rigidbody bullet = gameObject.GetComponent<Rigidbody>();
            bullet.velocity = new Vector3(dir.normalized.x * speed, dir.normalized.y * speed, 0);

            Destroy(gameObject, 2);
        }


    }

    void Update()
    {
        //onRange = Vector3.Distance(transform.position, player.position) < range;
        Shoot();
    }


}
