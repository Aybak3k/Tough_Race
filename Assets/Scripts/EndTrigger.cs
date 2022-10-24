using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter (Collider colliderObj)
    {
        if (colliderObj.CompareTag("Player"))
        {
            gameManager.CompleteLevel();
        }
    }
}
