using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


  
    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.left * GameManager.instance.enemySpeed;
        //gameObject.transform.Translate(-4, 0, 0);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="destroy")
        {
            Destroy(gameObject);
        }
    }


}
