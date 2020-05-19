using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0f;
    Rigidbody2D rigid;
    readonly int ScreenWidth = Screen.width;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            //Debug.Log($"TouchPosition:{touch.position}");
            float dir = 0f;
            if (touch.position.x < Screen.width * 0.33f)
            {
                dir = -1f;
            }
            else if (ScreenWidth * 0.66f < touch.position.x)
            {
                dir = 1f;
            }
            rigid.velocity = transform.right * dir * speed;
        }
        else if (Application.platform == RuntimePlatform.WindowsPlayer ||
            Application.platform == RuntimePlatform.WindowsEditor)
        {
            rigid.velocity = transform.right * Input.GetAxisRaw("Horizontal") * speed;
        }
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Egg"))
        {
            Score.score++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Bomb"))
        {
            Score.score--;
            Destroy(collision.gameObject);
        }
    }
}
