using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChitinHomingBullet : MonoBehaviour
{

    [SerializeField]
    private float speed = 20;
    [SerializeField]
    private float damage = 25;
    private bool delay = true;
    [SerializeField]
    private float delayTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        //var dir = Vector3.zero;
        //dir = GameObject.FindGameObjectWithTag("Player").transform.position - transform.position;
        Rigidbody bullet = gameObject.GetComponent<Rigidbody>();
        bullet.AddRelativeForce(new Vector3(0, -speed, 0));
        StartCoroutine(WaitForTime(delayTime));
    }
    private void Update()
    {
        if (!delay)
        {
            delay = true;
            Rigidbody bullet = gameObject.GetComponent<Rigidbody>();
            bullet.velocity = Vector3.zero;
            var dir = Vector3.zero;
            dir = GameObject.FindGameObjectWithTag("Player").transform.position - transform.position;
            bullet.AddForce(dir.normalized.x * speed *2, dir.normalized.y * speed*2, 0);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<PlayerHealth>() != null)
        {
            collision.gameObject.GetComponent<PlayerHealth>().takeDamage(damage);
            Destroy(gameObject);
        }
    }
    IEnumerator WaitForTime(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        delay = false;
    }
}
