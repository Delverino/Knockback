using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplatOnDestroy : MonoBehaviour
{
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        JuiceSplat.Instance.pop(transform.position, color);
    }
}
