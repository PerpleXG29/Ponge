using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_BG : MonoBehaviour
{
    public Ball ball;
    public ComputerPaddle computer;
    public PlayerPaddle player;

    public TrailRenderer BallTrail;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RightWall")
        {
         
            BallTrail.enabled = false;

            resetPostion();
            this.ball.Restart();

        }

        if (collision.gameObject.name == "LeftWall")
        {

          

            BallTrail.enabled = false; ;

            resetPostion();
            this.ball.Restart();

        }

        
    }

    private void resetPostion()
    {
        this.computer.resetComputerPosition();
        this.player.resetPlayerPosition();
    }
}
