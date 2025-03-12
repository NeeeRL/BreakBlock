using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float speed = 1.0f;

    private Rigidbody myRidid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRidid = this.GetComponent<Rigidbody>();
        myRidid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
