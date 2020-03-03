using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squash : MonoBehaviour
{
    public Rigidbody2D body;
    public shake s;

    public Vector3 init_transform;
    public Vector3 squish;
    public Vector3 stretch;

    public float y_threshold;
    public float change_threshold;

    //all in reference to just the y motion
    float velocity_diff = 0;
    float last_velocity = 0;
    float curr_velocity;

    //public zoom z;
    public float elasticity;

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
        curr_velocity = body.velocity.y;
        velocity_diff = Mathf.Abs(curr_velocity - last_velocity);
        last_velocity = curr_velocity;

        if((curr_velocity) > y_threshold)
        {
            transform.localScale = stretch;
        } else if (velocity_diff > change_threshold)
        {
            transform.localScale = squish;
            s.big_trauma();
            //z.zoom_in(2);
        }
        else
        {
            transform.localScale = Vector3.Lerp(transform.localScale, init_transform, elasticity);
        }
    }
}
