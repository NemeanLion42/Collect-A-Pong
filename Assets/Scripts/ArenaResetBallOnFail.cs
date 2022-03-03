using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaResetBallOnFail : MonoBehaviour
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

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other.ToString());
        if (other.gameObject.Equals(ball)) {
            ball.GetComponent<ControlBall>().Reset();
        }
    }
}
