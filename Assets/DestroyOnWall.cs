using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnWall : MonoBehaviour
{
    public string wall_name = "Wall";


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(wall_name))
        {
            Destroy(gameObject);
        }
    }
}
