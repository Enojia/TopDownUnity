using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
    void Start()
    {
        Invoke("Die", 1f);
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
