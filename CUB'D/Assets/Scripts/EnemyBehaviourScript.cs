using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourScript : MonoBehaviour {

    public double direction = 1.0f;
    public double speed = 5.0f;
    public double x = 0.0f;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        x = direction * Time.deltaTime * speed;

        transform.Translate(new Vector3((float) x, 0.0f, 0.0f), Space.World);
            
        if(transform.position.y < -5.0f){
            GameObject.Destroy(this.gameObject);
        }
	}

    void OnCollisionEnter(Collision collision){
        var gameObject = collision.gameObject;

        if (gameObject.tag == "Floor") {
            if(collision.transform.position.y > 0.0f)
        {
                direction *= -1.0f;
            }
        }
    }
}
