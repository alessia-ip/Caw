using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupAcvtivator : MonoBehaviour
{

    public GameObject pickupRight;
    public GameObject pickupLeft;
    SpriteRenderer spr;

    // Start is called before the first frame update
    void Start()
    {
        spr = this.gameObject.GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(spr.flipX == false)
        {
            pickupRight.SetActive(true);
            pickupLeft.SetActive(false);
        } else
        {
            pickupRight.SetActive(false);
            pickupLeft.SetActive(true);
        }
    }
}
