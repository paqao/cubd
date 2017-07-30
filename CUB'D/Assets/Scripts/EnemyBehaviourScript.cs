using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourScript : MonoBehaviour {

    public double direction = 1.0f;
    public double speed = 5.0f;
    public double x = 0.0f;

    private bool calcCollision = true;
    public bool isMoving = false;

    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (isMoving)
        {
            x = direction * Time.deltaTime * speed;

            transform.Translate(new Vector3((float)x, 0.0f, 0.0f), Space.World);

            if (transform.position.y < -5.0f)
            {
                GameObject.Destroy(this.gameObject);
            }
        }
	}

    private void OnCollisionExit(Collision collision)
    {
        var gameObject = collision.gameObject;

        if(gameObject.tag == "Obstacle" && !calcCollision)
        {
            calcCollision = true;
        }
    }

    void OnCollisionEnter(Collision collision){

     
        var gameObject = collision.gameObject;

        if (gameObject.tag == "Obstacle" && calcCollision)
        {
            direction *= -1.0f;
            calcCollision = false;
        }
    }
}
