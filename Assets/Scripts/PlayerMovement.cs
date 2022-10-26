using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 50f;

    void FixedUpdate ()
    {
        // ...
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        // Movement Input
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        // End Game on Fall
        if (transform.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
