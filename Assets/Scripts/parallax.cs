using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public Transform player;

    Vector3 last_edge;
    Vector3 next_pos;
    Vector3[] diff;

    GameObject[,] mountains;
    //public GameObject mountiain_prefab;
    public GameObject[] backgrounds;
    int[] middles;



    // Start is called before the first frame update
    void Start()
    {

        mountains = new GameObject[3, backgrounds.Length];
        middles = new int[backgrounds.Length];
        diff = new Vector3[backgrounds.Length];
        for (int j = 0; j < backgrounds.Length; j++)
        {
            middles[j] = 1;
            mountains[0,j] = backgrounds[j];
            diff[j] = backgrounds[j].transform.position - backgrounds[j].GetComponent<edge>().start.position;
            for (int i = 1; i < 3; i++)
            {
                last_edge = mountains[i - 1,j].GetComponent<edge>().end.position;
                mountains[i,j] = Instantiate(backgrounds[j], transform);
                next_pos = diff[j] + last_edge;
                mountains[i,j].transform.position = next_pos;
            }        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {

            if (player.position.x > mountains[middles[i] % 3,i].transform.position.x)
            {
                middles[i]++;
                last_edge = mountains[middles[i] % 3,i].GetComponent<edge>().end.position;
                next_pos = diff[i] + last_edge;
                mountains[(middles[i] + 1) % 3, i].transform.position = next_pos;

            }
        }
        
    }

    private void FixedUpdate()
    {
        transform.position = player.transform.position;
    }
}
