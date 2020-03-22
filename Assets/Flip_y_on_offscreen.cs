using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip_y_on_offscreen : MonoBehaviour
{
    public float top_screen;

    float negative_local_y;
    float initial_local_y;

    float lower_bound_y;

    // Start is called before the first frame update
    void Start()
    {
        initial_local_y = transform.localPosition.y;
        negative_local_y = -initial_local_y;

        lower_bound_y = -top_screen;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > top_screen)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, negative_local_y, transform.localPosition.z);
            lower_bound_y = transform.position.y;
        } else if(transform.position.y < lower_bound_y)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, initial_local_y, transform.localPosition.z);
        }
    }
}
