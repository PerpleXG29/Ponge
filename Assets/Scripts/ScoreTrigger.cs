using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class ScoreTrigger : MonoBehaviour
{
    public int playerScore;
    public int computerScore;

    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI computerScoreText;

    public Ball ball;
    public ComputerPaddle computer;
    public PlayerPaddle player;

    public Animator animator;

    public GameObject leftWall;
    public GameObject rightWall;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(rightWall.tag))
        {

            playerScore++;

            this.playerScoreText.text = playerScore.ToString();

            resetPostion();
            this.ball.Restart();
         
            Debug.Log("Player Score = " + playerScore);

        }

        if (collision.gameObject.CompareTag(leftWall.tag))
        {

            computerScore++;

            this.computerScoreText.text = computerScore.ToString();
            resetPostion();
            this.ball.Restart();
           
            Debug.Log("Computer Score = " + computerScore);
        }
    }

    private void resetPostion()
    {
        this.computer.resetComputerPosition();
        this.player.resetPlayerPosition();
    }
}
