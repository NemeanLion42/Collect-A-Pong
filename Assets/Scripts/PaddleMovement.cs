using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GoToMouse();
    }

    void OnMouseOver() {
        // Called if mouse is in quadrant
        // GoToMouse();
    }

    float paddleLimit = 2.5f;
    void GoToMouse()
    {
        Transform paddleTransform = transform.GetChild(0);
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 localMouse = paddleTransform.worldToLocalMatrix * mouse;
        Vector3 paddle = paddleTransform.worldToLocalMatrix * paddleTransform.position;
        Vector3 diff = localMouse-paddle;
        paddleTransform.Translate(new Vector3(diff.x, 0, 0));
        // Debug.Log("Mouse: " + localMouse.ToString() + "\nPaddle: " + paddle.ToString() + "\nDiff: " + diff.ToString());
        paddle = paddleTransform.worldToLocalMatrix * paddleTransform.position;
        paddle.x = Mathf.Min(Mathf.Max(paddle.x, -paddleLimit), paddleLimit);
        paddleTransform.position = paddleTransform.localToWorldMatrix * paddle;
        // paddleTransform.position = new Vector2(Mathf.Min(Mathf.Max(paddleTransform.position.x, -5.5f), 5.5f), 0);
    }
}
