using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bob : MonoBehaviour
{
    public float roughness = 1;
    public float rotation = 5;
    public float shake_up = 1;
    public float shake_side = 1;

    public Vector3 init_pos;

    int rotation_seed = 1;
    int shake_up_seed = 2;
    int shake_side_seed = 3;

    Vector3 delta;

    // Start is called before the first frame update
    void Start()
    {
        init_pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        delta = new Vector3(my_noise(shake_side, shake_side_seed), my_noise(shake_up, shake_up_seed), 0);


        transform.localPosition = init_pos + delta;
        transform.localRotation = Quaternion.Euler(0, 0, my_noise(rotation, rotation_seed));

        //transform.SetPositionAndRotation(init_pos + delta, Quaternion.Euler(0,0, my_noise(rotation, rotation_seed)));//  (my_noise(rotation, rotation_seed));
    }

    public float my_noise(float max, int seed)
    {
        return (Mathf.PerlinNoise(seed + Time.realtimeSinceStartup * roughness, Time.realtimeSinceStartup * roughness) * 2 * max) - max;
    }
}
