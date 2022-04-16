using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMarker : MonoBehaviour
{
    [SerializeField]
    private int markerPos = 0;
    public int getPos()
    {
        return markerPos;
    }
}
