using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float speed = 1.0f;

    private Rigidbody myRidid;

    public GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRidid = this.GetComponent<Rigidbody>();
        myRidid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
            gameManager.GameOver();
        }
            
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
