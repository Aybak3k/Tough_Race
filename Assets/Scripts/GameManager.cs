using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public void EndGame ()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", 1f);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


// TODOs
// add audio:- https://www.youtube.com/watch?v=rBwXhwilb5k&list=RDMMvadssi77q-U&index=27 - XD without any cheat codes
// Create Night Scene