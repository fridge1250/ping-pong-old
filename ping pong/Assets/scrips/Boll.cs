using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boll : MonoBehaviour
{
    [SerializeField] private float speed1 = 10f;
    [SerializeField] private Rigidbody2D rb2;
    [SerializeField] private Vector2 dir;
    void Start()
    {
        dir = new Vector2(Random.Range(0.5f,1), Random.Range(0.5f, 1));
    }
    private void Boll1()
    {
        rb2.velocity = dir.normalized * speed1; 
    }
    void Update()
    {
        Boll1();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            dir.x = -dir.x; //dir.y = -dir.y;
        }
        if (col.gameObject.CompareTag("wall"))
        {
            dir.y = -dir.y; //dir.y = dir.y;
        }
        if (col.gameObject.CompareTag("wall1"))
        {
            dir.x = dir.y; //dir.y = dir.y;
        }
        if (col.gameObject.CompareTag("wall2"))
        {
            dir.y = -dir.y; //dir.y = dir.y;
        }
    }
}
