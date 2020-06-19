using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 0f;
    private Rigidbody2D rb2d;
    public float time = 5;
    private float actualTime = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(speed, 0);

        rb2d.MovePosition((Vector2)transform.position + move * Time.deltaTime);

        actualTime += Time.deltaTime;
        if(actualTime >= time)
        {
            Destroy(gameObject);
        }
    }


}
