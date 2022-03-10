using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackScore : MonoBehaviour
{
    public float score = 0;
    public int pointsPerSecond = 100;
    public int secondsPerCoin = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime*pointsPerSecond;
        gameObject.GetComponent<UnityEngine.UI.Text>().text = Mathf.Round(score).ToString()/* + "." + (Mathf.Round(score*100) % 100).ToString().PadLeft(2, '0')*/;
    }
}
