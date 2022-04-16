using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrack : MonoBehaviour
{
    [SerializeField]
    private GameObject[] points;
    [SerializeField]
    private float speed = 1.0f;
    private int curPos = 0;
    private bool continueRunning = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (continueRunning)
        {
            var dir = Vector3.zero;
            if (Vector3.Distance(transform.position, points[curPos].transform.position) > .5f)
            {
                dir = points[curPos].transform.position - transform.position;
                gameObject.GetComponent<Rigidbody>().velocity = new Vector3(dir.normalized.x * speed, dir.normalized.y * speed, 0);
            }
            else
            {
                if (points[curPos].GetComponent<TrackVars>().destoryAtSpot())
                {
                    Destroy(transform.parent.gameObject);
                    /*foreach (GameObject obj in points)
                        Destroy(obj);
                    Destroy(gameObject);*/
                }
                if (points[curPos].GetComponent<TrackVars>().shootAtSpot())
                    Debug.Log("Reminder: Add shoot functionality to track");
                if (points[curPos].GetComponent<TrackVars>().pauseAtSpot())
                    StartCoroutine(WaitForTime(points[curPos].GetComponent<TrackVars>().waitTime()));
                wrapPos();
            }
        }
    }
    private int wrapPos()
    {
        if (++curPos >= points.Length)
            curPos = 0;
        return curPos;
    }
    //waits for timeToWait seconds
    IEnumerator WaitForTime(float timeToWait)
    {
        continueRunning = false;
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(timeToWait);
        continueRunning = true;
    }
}
