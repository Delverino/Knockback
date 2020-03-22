using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public KeyCode restart = KeyCode.R;

    public int curr_scene;

    public FireAtMouse gun;
    public TextOnClick dialogue;

    public bool over = false;


    // Start is called before the first frame update
    void Start()
    {
        over = false;
        curr_scene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


        if (Input.anyKeyDown)
        {
            if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            {
                SceneManager.LoadScene(curr_scene + 1);
            }
            else if (over)
            {
                SceneManager.LoadScene(curr_scene);
            }
        }
    }

    
}
