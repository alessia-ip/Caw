using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCounter : MonoBehaviour
{

    public int p1Win = 0;
    public int p2Win = 0;


    public GameObject winP1;
    public GameObject winP2;

    private void Update()
    {
        if(p1Win + p2Win == 5)
        {
            Debug.Log("DONE");

            if(p1Win > p2Win)
            {
                winP1.SetActive(true);
            } else
            {
                winP2.SetActive(true);
            }

        }
    }

}
