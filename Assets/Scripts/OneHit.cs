using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneHit : MonoBehaviour, ITakeDamage
{
    public void hurt(int damage)
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
