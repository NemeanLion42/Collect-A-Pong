using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    public GameObject menu;
    public GameObject game;
    public ControlBall ball;
    public GameObject instructions;
    public GameObject credits;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            ShowMenu();
        }
    }

    public void ShowMenu() {
        menu.SetActive(true);
        game.SetActive(false);
        instructions.SetActive(false);
        credits.SetActive(false);
    }

    public void StartEasy() {
        menu.SetActive(false);
        ball.difficulty = 0;
        game.SetActive(true);
        ball.InitializeBall();
    }

    public void StartMedium() {
        menu.SetActive(false);
        ball.difficulty = 1;
        game.SetActive(true);
        ball.InitializeBall();
    }

    public void StartHard() {
        menu.SetActive(false);
        ball.difficulty = 2;
        game.SetActive(true);
        ball.InitializeBall();
    }

    public void ShowInstructions() {
        menu.SetActive(false);
        instructions.SetActive(true);
    }

    public void ShowCredits() {
        menu.SetActive(false);
        credits.SetActive(true);
    }
}
