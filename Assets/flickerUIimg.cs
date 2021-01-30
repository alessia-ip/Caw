using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flickerUIimg : MonoBehaviour
{
    public Sprite img1;
    public Sprite img2;
    Image spr;

    // Update is called once per frame
    void OnEnable()
    {
        spr = this.gameObject.GetComponent<Image>();
        StartCoroutine(FLICK());
    }

    IEnumerator FLICK()
    {
        yield return new WaitForSeconds(0.2f);
        if (spr.sprite == img1)
        {
            spr.sprite = img2;
        }
        else
        {
            spr.sprite = img1;
        }
        StartCoroutine(FLICK());


    }
}
