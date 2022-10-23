using UnityEngine;

public class Collsion : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Debug.Log(collisionInfo.collider);
        }
    }
}
