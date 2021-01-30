using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;
    public KeyCode inspect;
    public SpriteRenderer spr;
    Vector2 pos;
    public float speed;
    Rigidbody2D rb;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
     
        pos = this.gameObject.transform.position;
        rb = this.gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        pos = this.gameObject.transform.position;

        if (Input.GetKey(left))
        {
            spr.flipX = true;
            pos.x -= speed * Time.deltaTime;
            rb.MovePosition(pos);
            anim.SetBool("walking", true);
        }
        else if (Input.GetKey(right))
        {
            spr.flipX = false;
            pos.x += speed * Time.deltaTime;
            rb.MovePosition(pos);
            anim.SetBool("walking", true);
        }

        if (Input.GetKey(up))
        {
            pos.y += speed * Time.deltaTime;
            rb.MovePosition(pos);
            anim.SetBool("walking", true);
        }
        else if (Input.GetKey(down))
        {
            pos.y -= speed * Time.deltaTime;
            rb.MovePosition(pos);
            anim.SetBool("walking", true);
        }

        if (Input.anyKey != true)
        {
            anim.SetBool("walking", false);
        }
    }
}
