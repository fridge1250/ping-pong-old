using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] int score;
    public Text textScore;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("bol"))
        {
            score++;
        }
    }
    private void Update()
    { 
        textScore.text = score + "$";
    }
}
