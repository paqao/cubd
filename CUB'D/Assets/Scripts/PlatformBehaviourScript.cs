using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviourScript : MonoBehaviour {

	public double maxX = 0.0f;
	public double minX = 0.0f;
    public double speedx = 5.0f;
    public double x = 0.0f;

    public double maxY = 0.0f;
    public double minY = 0.0f;
    public double speedY = 0.0f;
    public double y = 0.0f;

    public double maxZ = 0.0f;
    public double minZ = 0.0f;
    public double speedZ = 0.0f;
    public double z = 0.0f;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        x = Time.deltaTime * speedx;
        y = Time.deltaTime * speedY;
        z = Time.deltaTime * speedZ;

        transform.Translate(new Vector3((float) x, (float)y, (float)z), Space.World);
            
		if(transform.position.x < minX || transform.position.x > maxX){
			speedx *= -1.0f;
		}

        if(transform.position.y < minY || transform.position.y > maxY)
        {
            speedY *= -1.0f;
        }

        if(transform.position.z < minZ || transform.position.z > maxZ)
        {
            speedZ *= -1.0f;
        }
	}

}
