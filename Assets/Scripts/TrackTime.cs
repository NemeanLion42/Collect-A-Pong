using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTime : MonoBehaviour
{
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        gameObject.GetComponent<UnityEngine.UI.Text>().text = Mathf.Round(time).ToString() + "." + (Mathf.Round(time*100) % 100).ToString().PadLeft(2, '0');
    }
}
