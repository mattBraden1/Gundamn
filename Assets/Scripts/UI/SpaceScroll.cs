using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceScroll : MonoBehaviour
{

    void Update()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();

        GetComponent<MeshRenderer>();

        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;

        offset.y += Time.deltaTime / 10; //every ten seconds loop

        mat.mainTextureOffset = offset;
    }
}
