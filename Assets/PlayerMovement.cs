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
            bd.AddForce(sideways * Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey("a") || Input.GetKey("left"))
        {
            bd.AddForce(-sideways * Time.deltaTime, 0, 0);
        }
        //else if (Input.GetKey("w") || Input.GetKey("up"))
        //{
        //    bd.AddForce(0, 0, forward * Time.deltaTime);
        //}
        //else if (Input.GetKey("s") || Input.GetKey("down"))
        //{
        //    bd.AddForce(0, 0, -forward * Time.deltaTime);
        //}
    }
}
