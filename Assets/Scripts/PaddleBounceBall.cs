using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBounceBall : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.Equals(ball)) {
            ball.GetComponent<Move>().direction = (ball.transform.position - transform.position).normalized;
        }
    }
}
