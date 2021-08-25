using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody bd;
    public float forward = 850f;
    public float sideways = 500f;


    // Start is called before the first frame update
    void Start()
    {
        // bd.AddForce(0,100,500);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bd.AddForce(0,0,forward * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            bd.AddForce(sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if(Input.GetKey("a") || Input.GetKey("left"))
        {
            bd.AddForce(-sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
