using UnityEngine;

public class QuitGame : MonoBehaviour
{
     public void QuitGameFunc ()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
