using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuiceTime : MonoBehaviour
{
    public static JuiceTime Instance { get; private set;}

    //public float slow_time = 0.5f;
    float unscaled = 1;
    float target_time_scale;
    
    
    public float response;

    private void Awake()
    {
        target_time_scale = unscaled;
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Time.timeScale = Mathf.Lerp(Time.timeScale, target_time_scale, response);
    }

    public void scale_time(float scale, float duration)
    {
        StartCoroutine(delayed_dilation(scale, duration));
    }

    IEnumerator delayed_dilation(float scale, float duration)
    {
        target_time_scale = scale;
        yield return new WaitForSeconds(duration);
        target_time_scale = 1;
    }

}
