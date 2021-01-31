using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newscene : MonoBehaviour
{


    public string sceneNm;

    void OnEnable()
    {
        SceneManager.LoadScene(sceneNm);
    }
}
