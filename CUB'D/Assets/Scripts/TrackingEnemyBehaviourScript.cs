using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingEnemyBehaviourScript : MonoBehaviour {
    
    public TrackingEnemySingleBehaviourScript enemy = null;
    public GameObject player = null;
    public float speed;
    public float range;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        var distance = Vector3.Distance(player.transform.position, transform.position);

        if(range >= distance){
            enemy.destination = player.gameObject;
        }
        else{
            enemy.destination = null;
        }
	}
}
