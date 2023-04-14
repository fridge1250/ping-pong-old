using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed0 = 65f;
    [SerializeField] private Rigidbody2D rb;
    private void Click()
    {
        Vector2 dir = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            dir = Vector2.up * speed0 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            dir = Vector2.down * speed0 * Time.deltaTime;
        }
        rb.velocity = dir * speed0;
    }

    void Start()
    {
        
    }
    void Update()
    {
        Click();
    }
}
