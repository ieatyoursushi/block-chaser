using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    //Movement vars
    public Rigidbody Rb;
    public float Plus;
    public float Minus;
    public float fForce = 1000f;
    public GameObject player;
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, fForce * Time.deltaTime);
        if (Input.GetKey("a"))
        {
            Rb.AddForce(Minus * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("d"))
        {
            Rb.AddForce(Plus * Time.deltaTime, 0, 0);
        }

        if (Rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
            
        }
        
    }

}
