using UnityEngine;
using System.Collections;

public class PlayerMobility : MonoBehaviour
{
    public float speed;
    public float strafeSpeed;

    private Animator anim;
    private Rigidbody2D rb2D;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            anim.SetTrigger("Attack");
        }
    }
    // Update is called once per frame
    void FixedUpdate ()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);

        float inputVert = Input.GetAxis("Vertical");
        rb2D.AddForce(gameObject.transform.up * speed * inputVert);

        float inputHor = Input.GetAxis("Horizontal");
        rb2D.AddForce(gameObject.transform.right * strafeSpeed * inputHor);

	}
}
