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
            if (rnd < 2f / 3)
            {
                int id = Random.Range(0, 5);
                GameObject fallingObj = Instantiate(items[id]);
                fallingObj.transform.position = new Vector2(Random.Range(-xPos[0], xPos[0]), yPos[0]);
            }
            else
            {
                GameObject fallingObj = Instantiate(items[4]);
                fallingObj.transform.position = new Vector2(Random.Range(-xPos[1], xPos[1]), yPos[1]);
            }

            time = 0;
        }
    }
}
