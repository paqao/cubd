using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviourScript : MonoBehaviour {

    public EnemyBehaviourScript[] enemyTriggers;
    private bool triggerDone = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {
        if(!triggerDone)
        if(collider.gameObject.tag == "Player" && enemyTriggers != null && enemyTriggers.Length > 0)
        {
                triggerDone = true;

                foreach (var item in enemyTriggers)
                {
                    item.isMoving = true;
                }
        }
    }
}
