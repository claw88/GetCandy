using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEngine : MonoBehaviour
{
    public GameObject clearUi;
    // Start is called before the first frame update
    void Start()
    {
        Score.score = 0;
        clearUi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.score >= 5)
        {
            clearUi.SetActive(true);
        }
#if UNITY_ANDROID
        // Backキー押下
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // アプリ終了
            Application.Quit();
            return;
        }
#endif
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);      
    }
}
