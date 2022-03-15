using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackScore : MonoBehaviour
{
    public float score = 0;
    public int pointsPerSecond = 100;
    public int secondsPerCoin = 5;
    public float[] highScore;
    public ControlBall ball;
    public GameObject highScoreObject;
    // Start is called before the first frame update
    void Start()
    {
        highScore = new float[] {0, 0, 0};
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime*pointsPerSecond;
        gameObject.GetComponent<UnityEngine.UI.Text>().text = Mathf.Round(score).ToString();
        if (score > highScore[ball.difficulty]) {
            highScore[ball.difficulty] = score;
            highScoreObject.GetComponent<UnityEngine.UI.Text>().text = Mathf.Round(highScore[ball.difficulty]).ToString();
        }
    }
}
