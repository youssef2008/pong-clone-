#pragma warning disable IDE0005 // Using directive is unnecessary.
using System.Collections;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using UnityEngine;
using UnityEngine.UI;//We have to add the UnityEngine.UI name space in order to work to work with text variables

public class Ball : MonoBehaviour
{
    public float speed = 30;
    public Text scorerightText;
    public Text scoreleftText;
    public int scoreRight;
    public int scoreLeft;
    public Vector2 dir;
    public int scoreleft;

    public Ball()
    {
    }
    public void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }


    private float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {

        return (ballPos.y - racketPos.y) / racketHeight;


    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //this is our condition (if the ball collides with an object with the name wallright )
        if (col.gameObject.name == "Wallright")
        {
            //this line will just add 1 point to the score 
            scoreleft++;
            //this line will convert the int score variable to a string variable 
            scoreleftText.text = scoreLeft.ToString();
        }
        if (col.gameObject.name == "Wallleft")
        {
            scoreRight++;
            scorerightText.text = scoreRight.ToString();
        }


        if (col.gameObject.name == "RacketLeft")
        {
            // Calculate hit Factor
            float y = HitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            _ = new Vector2(1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        // Hit the right Racket?
        if (col.gameObject.name == "RacketRight")
        {
            // Calculate hit Factor
            float y = HitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            Vector2 speed = default;
            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }
#pragma warning disable IDE0040 // Add accessibility modifiers
#pragma warning disable UNT0001 // Empty Unity message
    void Update()
#pragma warning restore UNT0001 // Empty Unity message
#pragma warning restore IDE0040 // Add accessibility modifiers
    {

    }
}

