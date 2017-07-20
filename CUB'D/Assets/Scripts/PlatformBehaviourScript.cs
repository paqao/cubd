using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviourScript : MonoBehaviour {

	public double maxX = 0.0f;
	public double minX = 0.0f;
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
            
		if(transform.position.x < minX){
			speed *= -1.0f;
		}
		if(transform.position.x > maxX){
			speed *= -1.0f;
		}
	}

}
