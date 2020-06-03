using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackKeyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_ANDROID
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.runInBackground = false;
            Application.Quit();
        }
#endif
    }
}
