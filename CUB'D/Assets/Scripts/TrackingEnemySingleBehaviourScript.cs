using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingEnemySingleBehaviourScript : MonoBehaviour
{

    public GameObject destination = null;
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (destination != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
      
    }
}

