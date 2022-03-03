using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBall : MonoBehaviour
{
    public Vector2 direction;
    private float startingSpeed = 2;
    public float speed;
    public float acceleration = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    public void Reset() {
        speed = startingSpeed;
        transform.position = new Vector2();
        float angle = Random.Range(0, 2*Mathf.PI);
        direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction.normalized*speed*Time.deltaTime);
        speed += acceleration * Time.deltaTime;
        transform.GetChild(0).transform.eulerAngles = new Vector3(0, 0, (Mathf.Sign(direction.x)-1)*90 + Mathf.Atan(direction.y/direction.x)*180/Mathf.PI);
    }
}
