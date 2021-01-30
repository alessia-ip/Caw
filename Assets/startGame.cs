using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{

    public string sceneNm;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene(sceneNm);
        }       
    }
}
