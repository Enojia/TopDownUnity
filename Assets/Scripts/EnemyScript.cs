using UnityEngine;
using System.Collections;

public class EnemyScript : MovingObject
{
    GameObject player;

    protected override void Start()
    {
        base.Start();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void FixedUpdate ()
    {
        Vector3 end = transform.position - player.transform.position;
        Rotate(end);
	}
}
