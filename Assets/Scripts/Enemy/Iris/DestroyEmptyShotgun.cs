using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEmptyShotgun : MonoBehaviour
{
    [SerializeField]
    private float timeToDestroy = 5;
    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
}
