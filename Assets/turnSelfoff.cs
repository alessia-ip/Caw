using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnSelfoff : MonoBehaviour
{

    private void OnEnable()
    {
        StartCoroutine(turnOff());
    }

    IEnumerator turnOff()
    {
        yield return new WaitForSeconds(1);
        this.gameObject.SetActive(false);
    }
}
