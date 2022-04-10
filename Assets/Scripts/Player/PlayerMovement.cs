using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if((Input.GetAxis("Horizontal")- Input.GetAxis("Vertical")) == Input.GetAxis("Horizontal"))
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);
        //else
            //gameObject.GetComponent<Rigidbody>().velocity = new Vector3((Input.GetAxis("Horizontal")/2) * speed, (Input.GetAxis("Vertical")/2) * speed, 0);
    }
}
