using UnityEngine;
using System.Collections;

public class PlayerMobility : MovingObject
{
    
    public float strafeSpeed;

	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Rotate(mousePosition);
        Controller();
	}

    public void Controller()
    {
        float inputVert = Input.GetAxis("Vertical");
        rb2D.AddForce(gameObject.transform.up * speed * inputVert);

        float inputHor = Input.GetAxis("Horizontal");
        rb2D.AddForce(gameObject.transform.right * strafeSpeed * inputHor);
    }
}
