using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{

    KeyCode P1 = KeyCode.C;
    KeyCode P2 = KeyCode.N;

    bool p1Ready = false;
    bool p2Ready = false;

    public string sceneNm;

    public GameObject p1check;
    public GameObject p2check;

    public GameObject rules;
    public GameObject countdown;


    //// Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.N))
    //    {
    //        SceneManager.LoadScene(sceneNm);
    //    }       
    //}

    void Update()
    {
        if (Input.GetKeyDown(P1))
        {
            p1check.SetActive(true);
            p1Ready = true;
        }        
        
        if (Input.GetKeyDown(P2))
        {
            p2check.SetActive(true);
            p2Ready = true;
        }

        if(p1Ready == true && p2Ready == true)
        {
            StartCoroutine(countdownStart());
            p1Ready = false;
            p2Ready = false;
        }

    }

    IEnumerator countdownStart()
    {
        yield return new WaitForSeconds(0.3f);
        rules.SetActive(false);
        countdown.SetActive(true);
    }

}
