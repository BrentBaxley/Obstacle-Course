using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigedBody;
    [SerializeField]float dropTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;

        rigedBody = GetComponent<Rigidbody>();
        rigedBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > dropTime)
        {
            Debug.Log("Greater than 3 seconds has passed");
            meshRenderer.enabled = true;
            rigedBody.useGravity = true;
        }
    }
}
