using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjCreator : MonoBehaviour
{
    public GameObject[] items;
    public float interval = 3.0f;
    private float time;
    float[] xPos = new[] { 3.2f, 2.9f };
    float[] yPos = new[] { -0.3f, -0.62f };
    public GameObject ClearUi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= interval && !ClearUi.activeInHierarchy)
        {
            var rnd = Random.value;
            var id = rnd < 2f / 3 ? 0 : 1;
            GameObject fallingObj =
                Instantiate(items[id]) as GameObject;
            fallingObj.transform.position = new Vector2(Random.Range(-xPos[id], xPos[id]), yPos[id]);
            time = 0;
        }
    }
}
