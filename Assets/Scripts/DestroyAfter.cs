﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine( destruct());
    }

    IEnumerator destruct()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}