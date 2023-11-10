using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Human_GameManager : MonoBehaviour
{
    public int playerScore;
    public int computerScore;

    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI computerScoreText;

    public Ball ball;
    public PlayerPaddle player;
    public Player2Paddle player2;

    public GameObject ComputerWinScreen;
    public GameObject PlayerWinScreen;
    

    public TrailRenderer BallTrail;
    public AudioSource ScoreSound;

    private void Start()
    {
        ComputerWinScreen.SetActive(false);
        PlayerWinScreen.SetActive(false);
        ScoreSound.enabled = false;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RightWall")
        {

            ScoreSound.enabled = true;
            ScoreSound.Play();

            playerScore++;
      
            this.playerScoreText.text = playerScore.ToString();

            BallTrail.enabled = false;

            resetPostion();
            this.ball.Restart();

            Debug.Log("Player Score = " + playerScore);

        }

        if (collision.gameObject.name == "LeftWall")
        {

            ScoreSound.enabled = true;
            ScoreSound.Play();

            computerScore++;

            this.computerScoreText.text = computerScore.ToString();

            BallTrail.enabled = false; ;

            resetPostion();
            this.ball.Restart();

            Debug.Log("Computer Score = " + computerScore);
        }

        WinMenu();
    }

    private void resetPostion()
    {
        
        this.player2.resetPlayerPosition();
        this.player.resetPlayerPosition();
    }

    private void WinMenu()
    {
        if (computerScore == 4)
        {
            Debug.Log("Computer Wins");
            ComputerWinScreen.SetActive(true);
            Time.timeScale = 0f;
        }
        else if(playerScore == 4)
        {
            Debug.Log("PlayerWins");
            PlayerWinScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
