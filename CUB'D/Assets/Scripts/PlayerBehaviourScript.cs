using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public float jumpPower;
    public bool doubleJumpEnabled;

    private bool doubleJumpState;
	private bool isJumping;
	private bool canMoveVertically = true;
	private float x, y;

	private bool scaling = true;

	private int timer = 0;
	private bool returnToNormal = false;
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
			isJumping = true;
			returnToNormal = false;
        }

        // logic
		//check camera projection 
		if (Camera.main.orthographic) { //2D
			canMoveVertically = false;
		}
		else
			canMoveVertically = true; //3D

		Jumping ();



	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Floor" && timer > 5) {
			isJumping = false;
			timer = 0;


		}
	}

	void Jumping ()
	{
		if (isJumping) {
			timer++;
			transform.localScale = Vector3.Lerp (transform.localScale, new Vector3 (0.75f, 1.25f, 0.75f), 0.5f);
		}
		else
			if (!isJumping && !returnToNormal) {
				if (transform.localScale.x < 1.25f) {
					transform.localScale = Vector3.Lerp (transform.localScale, new Vector3 (1.25f, 0.75f, 1.25f), 0.5f);
				}
				if (transform.localScale.x > 1.22f)
					returnToNormal = true;
			}
		if (returnToNormal) {
			transform.localScale = Vector3.Lerp (transform.localScale, new Vector3 (1f, 1f, 1f), 0.75f);
		}
	}
}