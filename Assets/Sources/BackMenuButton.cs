using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenuButton : MonoBehaviour
{
    public void OnClickBackMenuButton()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
