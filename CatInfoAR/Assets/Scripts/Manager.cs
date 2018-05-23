using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Manager : MonoBehaviour {

    public GameObject target;

    private Rigidbody rb;

    private void Awake()
    {
        target.GetComponent<Rigidbody>();
    }

    public void OnPointDown()
    {
        rb.AddForce(new Vector3(0,3,0));
    }
}
