using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupCheck : MonoBehaviour
{

    public GameObject item;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("col2");

        if(collision.gameObject.tag == "Pickup")
        {
            item = collision.gameObject;
            item.transform.GetChild(0).gameObject.SetActive(true);
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(item != null)
        {
            item.transform.GetChild(0).gameObject.SetActive(false);
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            item = null;
        }

    }

}
