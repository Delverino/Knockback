using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{
    public float trauma;
    public float trauma_down = 0.1f;

    public float little_up;
    public float big_up;

    public float max_rotation;

    public Camera main_cam;

    public int p;

    private float t;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        trauma = Mathf.Clamp(trauma, 0, 1);
        t = trauma * trauma;
        transform.SetPositionAndRotation(main_cam.transform.position, main_cam.transform.rotation);
        //transform.position = transform.position + t * Vector3.up * Mathf.PerlinNoise(Time.realtimeSinceStartup * p, 0) + t * Vector3.right * Mathf.PerlinNoise(0,Time.realtimeSinceStartup * p);
        transform.Rotate(t * Vector3.forward * ((2 * max_rotation * Mathf.PerlinNoise(Time.realtimeSinceStartup * p, 0)) - max_rotation));
    }

    private void FixedUpdate()
    {
        trauma -= trauma_down * Time.fixedDeltaTime;
    }

    public void little_trauma()
    {
        trauma += little_up;
    }

    public void big_trauma()
    {
        trauma += big_up;
    }
}
