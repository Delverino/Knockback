﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuiceSplat : MonoBehaviour
{
    public static JuiceSplat Instance { get; private set; }

    public GameObject particles;
    public AudioSource audioSource;
    public float volume=0.5f;


    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pop(Vector3 location, Color color) 
    {
        audioSource.Play();
        GameObject particle = Instantiate(particles, location, Quaternion.identity);
        particle.GetComponent<ParticleSystem>().startColor = color;
    }
}
