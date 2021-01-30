using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class flicker : MonoBehaviour
{

    public Sprite img1;
    public Sprite img2;
    SpriteRenderer spr;

    // Update is called once per frame
    void OnEnable()
    {
        spr = this.gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine(FLICK());
    }

    IEnumerator FLICK()
    {
        yield return new WaitForSeconds(0.2f);
        if (spr.sprite == img1)
        {
            spr.sprite = img2;
        } else
        {
            spr.sprite = img1;
        }
        StartCoroutine(FLICK());


    }
}
