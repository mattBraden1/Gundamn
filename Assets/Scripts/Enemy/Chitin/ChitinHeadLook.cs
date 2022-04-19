using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChitinHeadLook : MonoBehaviour
{
    [SerializeField]
    private bool isLooking = false;
    [SerializeField]
    private Transform player;
    private float rot = 0;
    void Update()
    {
        rot = Mathf.Acos((transform.position.y - player.position.y) / Mathf.Sqrt(Mathf.Pow(transform.position.x - player.position.x, 2) + Mathf.Pow(transform.position.y - player.position.y, 2))) *Mathf.Rad2Deg;
        if(transform.position.x > player.position.x)
            transform.localEulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, -rot);
        else
            transform.localEulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, rot);
    }
    public void setLooking(bool a)
    {
        isLooking = a;
    }
}
