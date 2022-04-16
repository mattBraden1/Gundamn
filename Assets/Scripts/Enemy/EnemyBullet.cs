using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    [SerializeField]
    private float speed = 20;
    [SerializeField]
    private float damage = 25;

    // Start is called before the first frame update
    void Start()
    {
        //var dir = Vector3.zero;
        //dir = GameObject.FindGameObjectWithTag("Player").transform.position - transform.position;
        Rigidbody bullet = gameObject.GetComponent<Rigidbody>();
        bullet.AddRelativeForce(new Vector3(0, -speed, 0));
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Wall")
            Destroy(gameObject);
        else if (collision.gameObject.GetComponent<PlayerHealth>() != null)
        {
            collision.gameObject.GetComponent<PlayerHealth>().takeDamage(damage);
            Destroy(gameObject);
        }
    }
}
