using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnOff : MonoBehaviour
{

    public KeyCode key;
    public GameObject turnOn;
    public GameObject turnOff;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            turnOn.SetActive(true);
            turnOff.SetActive(false);
        }
    }
}
