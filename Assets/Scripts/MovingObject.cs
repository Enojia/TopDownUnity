using UnityEngine;
using System.Collections;

public abstract class MovingObject : MonoBehaviour
{
    public float speed;
    
    protected Rigidbody2D rb2D;

    // Use this for initialization
    protected virtual void Start ()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
	

    protected void Rotate(Vector3 end)
    {
        Quaternion rot = Quaternion.LookRotation(transform.position - end, Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
    }
}
