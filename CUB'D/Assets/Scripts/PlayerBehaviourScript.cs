using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public float jumpPower;
    public bool doubleJumpEnabled;

    private bool doubleJumpState;
	private bool canMoveVertically = true;
	private float x = 0, y = 0;
    void Start () {
		
		x = 0; y = 0;
	}
	
	// Update is called once per frame
	void Update () {
        // input
        x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		if(canMoveVertically)
        	y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, 0, y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(0, jumpPower, 0);
        }

        // logic
		//check camera projection 
		if (Camera.main.orthographic) { //2D
			canMoveVertically = false;
		}
		else
			canMoveVertically = true; //3D
	}
}
