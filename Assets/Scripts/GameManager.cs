using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;

    bool gameHasEnded = false;

    public void EndGame ()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", 1f);
        }
    }

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
