using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FireAtMouse : MonoBehaviour
{
    public Transform mouse;
    public GameObject bullet;
    public float speed;
    public float kick;
    public Rigidbody2D body;

    public int bullets;
    public TextMeshProUGUI bullet_text;
    string initial_bullet_text;

    public Manager game_manager;
    
    // Start is called before the first frame update
    void Start()
    {
        initial_bullet_text = bullet_text.text;
        bullet_text.text = initial_bullet_text + bullets.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && bullets > 0)
        {
            JuiceTime.Instance.scale_time(0.3f, 0.06f);
            bullets--;
            bullet_text.text = initial_bullet_text + bullets.ToString();

            GameObject fired = Instantiate(bullet, transform.position, Quaternion.identity);
            fired.transform.right = (mouse.position - transform.position).normalized;
            fired.GetComponent<Rigidbody2D>().velocity = (mouse.position - transform.position).normalized * speed; 
            body.velocity = body.velocity +  (Vector2)(transform.position - mouse.position).normalized * kick;
        }


        if (bullets <= 0 && GameObject.FindGameObjectsWithTag("Bullet").Length == 0)
        {
            game_manager.over = true;
        }
    }

    private void OnDestroy()
    {
        game_manager.over = true;
    }


}
