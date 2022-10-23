using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        this.transform.position = player.position + new Vector3(0f,2f,-7f);
    }
}
