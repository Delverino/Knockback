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
    
    // Start is called before the first frame update
    void Start()
    {
        initial_bullet_text = bullet_text.text;
        bullet_text.text = initial_bullet_text + bullets.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && bullets > 0)
        {
            JuiceTime.Instance.scale_time(0.3f, 0.05f);
            bullets--;
            bullet_text.text = initial_bullet_text + bullets.ToString();

            GameObject fired = Instantiate(bullet, transform.position, Quaternion.identity);
            fired.GetComponent<Rigidbody2D>().velocity = (mouse.position - transform.position).normalized * speed; 
            body.velocity = body.velocity +  (Vector2)(transform.position - mouse.position).normalized * kick;
        }
    }


}
