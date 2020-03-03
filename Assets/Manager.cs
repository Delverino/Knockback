using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public KeyCode restart = KeyCode.R;

    public int curr_scene;


    // Start is called before the first frame update
    void Start()
    {
        curr_scene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(restart))
        {
            SceneManager.LoadScene(curr_scene);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            SceneManager.LoadScene(curr_scene + 1);
        }
    }

    
}
