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

    public GameObject keyW;
    public GameObject ringW;
    public GameObject glassW;
    public GameObject coinW;
    public GameObject walletW;

    public winCounter winCount;

    public pickupCheck itemPickupR;
    public pickupCheck itemPickupL;

    public bool isPlayerOne;

    AudioSource aud;
    public AudioClip HONK;

    public GameObject FAIL;

    // Start is called before the first frame update
    void Start()
    {
     
        pos = this.gameObject.transform.position;
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        aud = GetComponent<AudioSource>();

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

        if (Input.GetKeyDown(inspect)) 
        {



            //right side

            if(itemPickupR.item != null){

                //is it the winning item?
                if (itemPickupR.item.GetComponent<correctItem>().winningItem == true)
                {



                    if (itemPickupR.item.GetComponent<correctItem>().objectType == correctItem.objType.Coin)
                    {
                        coinW.SetActive(true);
                    }
                    if (itemPickupR.item.GetComponent<correctItem>().objectType == correctItem.objType.Wallet)
                    {
                        walletW.SetActive(true);
                    }
                    if (itemPickupR.item.GetComponent<correctItem>().objectType == correctItem.objType.Key)
                    {
                        keyW.SetActive(true);
                    }
                    if (itemPickupR.item.GetComponent<correctItem>().objectType == correctItem.objType.Glass)
                    {
                        glassW.SetActive(true);
                    }
                    if (itemPickupR.item.GetComponent<correctItem>().objectType == correctItem.objType.Ring)
                    {
                        ringW.SetActive(true);
                    }
                    itemPickupR.item.SetActive(false);
                    itemPickupR.item = null;

                    if (isPlayerOne == true)
                    {
                        winCount.p1Win += 1;
                    }
                    else
                    {
                        winCount.p2Win += 1;
                    }

                    aud.PlayOneShot(HONK);

                }
                else
                {
                    FAIL.SetActive(true);
                }
            }

            //left side 

            if (itemPickupL.item != null)
            {
         
                //is it the winning item?
                if (itemPickupL.item.GetComponent<correctItem>().winningItem == true)
                {



                    if (itemPickupL.item.GetComponent<correctItem>().objectType == correctItem.objType.Coin)
                    {
                        coinW.SetActive(true);
                    }
                    if (itemPickupL.item.GetComponent<correctItem>().objectType == correctItem.objType.Wallet)
                    {
                        walletW.SetActive(true);
                    }
                    if (itemPickupL.item.GetComponent<correctItem>().objectType == correctItem.objType.Key)
                    {
                        keyW.SetActive(true);
                    }
                    if (itemPickupL.item.GetComponent<correctItem>().objectType == correctItem.objType.Glass)
                    {
                        glassW.SetActive(true);
                    }
                    if (itemPickupL.item.GetComponent<correctItem>().objectType == correctItem.objType.Ring)
                    {
                        ringW.SetActive(true);
                    }



                    itemPickupL.item.SetActive(false);
                    itemPickupL.item = null;


                    if (isPlayerOne == true)
                    {
                        winCount.p1Win += 1;
                    }
                    else
                    {
                        winCount.p2Win += 1;
                    }


                    aud.PlayOneShot(HONK);


                } else
                {
                    FAIL.SetActive(true);
                }
            }

        }

    }
}
