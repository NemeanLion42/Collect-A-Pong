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

    void GoToMouse()
    {
        Transform paddleTransform = transform.GetChild(0);
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 localMouse = paddleTransform.worldToLocalMatrix * mouse;
        Vector3 paddle = paddleTransform.worldToLocalMatrix * paddleTransform.position;
        Vector3 diff = localMouse-paddle;
        // Debug.Log("Mouse: " + localMouse.ToString() + "\nPaddle: " + paddle.ToString() + "\nDiff: " + diff.ToString());
        paddleTransform.Translate(new Vector3(diff.x, 0, 0));
    }
}
