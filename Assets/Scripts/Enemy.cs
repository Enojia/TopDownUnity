using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject player;
    public GameObject explosion;

    private Animator anim;
    private Rigidbody2D rb2D;
	// Use this for initialization
	void Start ()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
	}
	

	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 toPlayer = player.transform.position - transform.position;
        float z = Mathf.Atan2(toPlayer.y, toPlayer.x) * Mathf.Rad2Deg - 90;

        transform.eulerAngles = new Vector3(0, 0, z);
        rb2D.AddForce(gameObject.transform.up * speed);
	}

    void OnDisable()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
