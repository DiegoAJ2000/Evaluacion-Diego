using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public GameObject nave1;
    public GameObject nave2;
    public GameObject meta;
    public float vel = 0f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            move.y = 1; 
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move.x = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move.x = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move.y = -1;
        }

        rb2d.MovePosition((Vector2)this.transform.position + (move * vel * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == nave1)
        {
            Debug.Log("AUCH!!!");
        }
        if (collision.gameObject == nave2)
        {
            Debug.Log("AUCH!!!");
        }
        if (collision.gameObject == meta)
        {
            Debug.Log("Ganaste!!!");
        }
    }
}
