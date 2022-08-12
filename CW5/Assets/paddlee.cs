using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlee : MonoBehaviour
{
    Rigidbody2D RB;
    float platerInput;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        platerInput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(platerInput * speed, 0);
    }
}
