using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideWayForce = 2000f;
    private bool moveLeft = false;
    private bool moveRight = false;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Fun starts");
        //rb.useGravity = false;
        //rb.AddForce(0, 300, 2000);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(0, 0, 2000 * Time.deltaTime);
        moveLeft = Input.GetKey("a");
        moveRight = Input.GetKey("d");
    }

    //anything that needs to be applied to a rigidbody should happen in FixedUpdate (p.s. anything related with physics)
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(moveLeft)
        {
            rb.AddForce(-sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(moveRight)
        {
            rb.AddForce(sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(transform.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
