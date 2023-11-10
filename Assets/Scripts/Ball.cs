using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D _rigidbody;
    public float speed = 100.0f;

    public AudioSource CollideSound;

    public TrailRenderer BallTrail;
    public ParticleSystem ParticleAffects;

    public ShakeEffect ShakeEffect;

    private void Awake()
    {
        
        _rigidbody = GetComponent<Rigidbody2D>();
        
    }

    private void Start()
    {

        StartForce();
        CollideSound.enabled = false;
       

    }

    public void StartForce()
    
    {
        Debug.Log("Start");
        
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        BallTrail.enabled = true;

        Vector2 direction = new Vector2(x, y);
        
        _rigidbody.AddForce(direction * this.speed);
    }

   public void AddForce(Vector2 force)
    {
        CollideSound.enabled = true;
        _rigidbody.AddForce(force);
        CollideSound.Play();
        
        ReleaseParticles(30);

        ShakeEffect.StartShake(0.2f,0.2f);
        
    }

    public void Restart()
    {
               

        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
        
        StartForce();
    
    }

    private void ReleaseParticles(int amount)
    {
        ParticleAffects.Emit(amount);
    }
    
}
