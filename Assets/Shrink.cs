using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour
{
    public float shrink_per_sec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.localScale = transform.localScale - Vector3.one * (shrink_per_sec * Time.fixedDeltaTime);
        if(transform.localScale.x < 0.01f)
        {
            Destroy(gameObject);
        }
    }
}
