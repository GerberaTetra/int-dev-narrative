using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textcode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
       
     if ((collision.gameObject.tag == "GameController"))
       {
            Debug.Log("bruh");
            //changeSprite("text 1");
        }
    }
}