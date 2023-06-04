using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private bool isUp=true;
    AudioSource audio;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }





   
    // Update is called once per frame
    void Update()
    {
        if (isUp == true)
        {
            rb.velocity = Vector2.up* GameManager.instance.playerSpeed;
            //transform.Translate(0, speed, 0);
        }
        else if (isUp == false)
        {
            rb.velocity = Vector2.down * GameManager.instance.playerSpeed;
            //transform.Translate(0, -speed, 0);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (isUp == true)
            {
                isUp = false;
            }
            else if (isUp == false)
            {
                isUp = true;
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="upper")
        {
            isUp = false;
        }
        else if(collision.gameObject.tag=="lower")
        {
            isUp = true;
        }

        if(collision.gameObject.tag=="enemy")
        {
            Debug.Log("enemy");
            SceneManager.LoadScene(0);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="point")
        {
            GameManager.instance.score++;
            Debug.Log(GameManager.instance.score);
            Destroy(collision.gameObject);
            //play audio
            audio.Play();
        }
    }
}
