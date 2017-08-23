using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviourScript : MonoBehaviour {

    [Header("x align")]
	public double maxX = 0.0f;
	public double minX = 0.0f;
    public double speedX = 5.0f;
    public double x = 0.0f;
    public double curx = 0.0f;

    [Header("y align")]
    public double maxY = 0.0f;
    public double minY = 0.0f;
    public double speedY = 0.0f;
    public double y = 0.0f;
    public double cury = 0.0f;

    [Header("z align")]
    public double maxZ = 0.0f;
    public double minZ = 0.0f;
    public double speedZ = 0.0f;
    public double z = 0.0f;
    public double curz = 0.0f;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
        x = Time.deltaTime * speedX;
        y = Time.deltaTime * speedY;
        z = Time.deltaTime * speedZ;

        if (speedX == 0.0f)
            x = 0.0f;

        if (speedY == 0.0f)
            y = 0.0f;

        if (speedZ == 0.0f)
            z = 0.0f;

        curx += x;
        cury += y;
        curz += z;

        transform.Translate(new Vector3((float) x, (float)y, (float)z), Space.World);
            
		if(curx < minX || curx > maxX){
            speedX *= -1.0f;
		}

        if(cury < minY || cury > maxY)
        {
            speedY *= -1.0f;
        }

        if( curz < minZ || curz > maxZ)
        {
            speedZ *= -1.0f;
        }
	}

}
