using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackVars : MonoBehaviour
{
    [SerializeField]
    private bool pause = false;
    [SerializeField]
    private float timeToWait = 0;
    [SerializeField]
    private bool shoot = false, destroy = false;
    public bool pauseAtSpot()
    {
        return pause;
    }
    public float waitTime()
    {
        return timeToWait;
    }
    public bool shootAtSpot()
    {
        return shoot;
    }
    public bool destoryAtSpot()
    {
        return destroy;
    }
}
