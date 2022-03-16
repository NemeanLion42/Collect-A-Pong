using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBall : MonoBehaviour
{
    public Vector2 direction;
    public float[] startingSpeed;
    public float speed;
    public float[] acceleration;
    public int difficulty;
    // Start is called before the first frame update
    void Start()
    {
        startingSpeed = new float[] {2.5f, 4f, 6f};
        acceleration = new float[] {0.025f, 0.05f, 0.1f};
        InitializeBall();
    }

    public void InitializeBall() {
        speed = startingSpeed[difficulty];
        transform.position = new Vector2();
        float angle = Random.Range(0, 2*Mathf.PI);
        direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction.normalized*speed*Time.deltaTime);
        speed += acceleration[difficulty] * Time.deltaTime;
        transform.GetChild(0).transform.eulerAngles = new Vector3(0, 0, (Mathf.Sign(direction.x)-1)*90 - 90 + Mathf.Atan(direction.y/direction.x)*180/Mathf.PI);
    }
}
