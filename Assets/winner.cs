using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winner : MonoBehaviour
{

    public string scenename;

    void Update()
    {
    if(Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene(scenename);
        }   
    }
}
