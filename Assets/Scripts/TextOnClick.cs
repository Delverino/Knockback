using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextOnClick : MonoBehaviour
{
    public GameObject text_bubble;

    public string[] sentences;

    int index;

    bool done = false;

    // Start is called before the first frame update
    void Start()
    {
        index = -1;
        newText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            text_bubble.SetActive(false);
        }


        if (!done && GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            newText();
            done = true;
        }
    }

    void newText()
    {
        index++;
        if (index > sentences.Length - 1)
        {
            text_bubble.SetActive(false);
        }
        else
        {
            text_bubble.GetComponentInChildren<TextMeshProUGUI>().text = sentences[index];
            text_bubble.SetActive(true);

        }

    }
}
