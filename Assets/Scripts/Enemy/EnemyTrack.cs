using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrack : MonoBehaviour
{
    [SerializeField]
    private GameObject[] points;
    [SerializeField]
    private float speed = 1;
    private int curPos = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var dir = Vector3.zero;
        if (Vector3.Distance(transform.position, points[curPos].transform.position) > .5f)
        {
            dir = points[curPos].transform.position - transform.position;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(dir.normalized.x * speed, dir.normalized.y * speed, 0);
        }
        else
            wrapPos();
    }
    private int wrapPos()
    {
        if (++curPos >= points.Length)
            curPos = 0;
        return curPos;
    }
}
