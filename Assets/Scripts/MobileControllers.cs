using UnityEngine;

public class MobileControllers : MonoBehaviour
{
    [SerializeField] GameObject player;
    Rigidbody rb;
    float sidewaysForce;

    void Awake ()
    {
        rb = player.GetComponent<Rigidbody>();
        sidewaysForce = player.GetComponent<PlayerMovement>().sidewaysForce;
    }

    public void BtnMoveLeft()
    {
        rb.AddForce(-(sidewaysForce * 3) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void BtnMoveRight()
    {
        rb.AddForce((sidewaysForce * 3) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
