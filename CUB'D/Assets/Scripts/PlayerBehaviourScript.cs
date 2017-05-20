using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public float jumpPower;
    public bool doubleJumpEnabled;

    private bool doubleJumpState;

    void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
        // input
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, 0, y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(0, jumpPower, 0);
        }

        // logic
	}
    
    void OnCollisionEnter(Collision collision){
        var gameObject = collision.gameObject;
        if(gameObject.tag == "Enemy")
        {
            var gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehaviourScript>();
            gameManager.lives--;

            DestroyObject(gameObject);
        }
        
    }
}
