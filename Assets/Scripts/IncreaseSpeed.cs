using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{
    public float bounceStrength = 1000000000.0f;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
       Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;

            
            ball.AddForce(-normal * this.bounceStrength);
        }
    }

   
}
