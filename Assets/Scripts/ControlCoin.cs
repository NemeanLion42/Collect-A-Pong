using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCoin : MonoBehaviour
{
    public GameObject ball;
    public GameObject score;
    public GameObject particles;
    float size = 0.4f;
    float angle = 0;
    float rotationSpeed = Mathf.PI;
    // Start is called before the first frame update
    void Start()
    {
        InitializeCoin();
    }

    // Update is called once per frame
    void Update()
    {
        angle += (rotationSpeed * Time.deltaTime) % Mathf.PI;
        transform.localScale = new Vector3(Mathf.Cos(angle)*size, size, 1);
    }

    void InitializeCoin() {
        Vector3 newPosition = transform.position;
        while ((transform.position-newPosition).magnitude < 1) {
            transform.position = new Vector2(Random.Range(-3, 3), Random.Range(-3, 3));
        }
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.HSVToRGB(Random.Range(0.12f, 0.16f), Random.Range(0.8f, 0.95f), Random.Range(0.9f, 0.95f));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.Equals(ball)) {
            particles.transform.position = transform.position;
            particles.GetComponent<ParticleSystem>().Play();
            TrackScore tracker = score.GetComponent<TrackScore>();
            tracker.score += tracker.pointsPerSecond*tracker.secondsPerCoin;
            InitializeCoin();
        }
    }
}
