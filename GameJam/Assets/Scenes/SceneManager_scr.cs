using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager_scr : MonoBehaviour
{
    public void gotoscene(string s)
    {
        SceneManager.LoadScene(s);
    }
}
