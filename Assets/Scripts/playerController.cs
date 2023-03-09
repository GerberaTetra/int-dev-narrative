using UnityEngine;
using System.Collections;
public class playerController : MonoBehaviour
{
    public float speed;
    public bool getkey = false;
    public GameObject key;
    public SpriteRenderer spRenderer;
    public Sprite newSprite;
    public Sprite newSprite2;
    public Sprite newSprite3;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDirection = Vector2.zero;
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0)
        {
            moveDirection.x = 1;

        }
        else if (horizontal < 0)
        {
            moveDirection.x = -1;

        }
        else if (vertical > 0)
        {
            moveDirection.y = 1;

        }
        else if (vertical < 0)
        {
            moveDirection.y = -1;

        }
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "door") && (getkey == true))
        {
            Destroy(GameObject.FindWithTag("door"));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("text2"))
        {
            spRenderer.sprite = newSprite3;
        }

        if (other.CompareTag("key"))
        {
            getkey = true;
            Destroy(key);
        }

        if (other.CompareTag("text1") && (getkey = true))
        {
            spRenderer.sprite = newSprite2;
        }
        else if (other.CompareTag("text1"))
        {
            spRenderer.sprite = newSprite;
        }

       if (other.CompareTag("text2"))
        {
            spRenderer.sprite = newSprite3;
        }
    }

}