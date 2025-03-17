using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 1.0f;
    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isGameNow)
        {
            if(Input.GetKey(KeyCode.LeftArrow)) 
            {
                if(this.transform.position.x > -4)
                {
                    this.transform.position += Vector3.left  * speed * Time.deltaTime;
                }
            }
            if(Input.GetKey(KeyCode.RightArrow))
            {
                if(this.transform.position.x < 4)
                    this.transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    }
}
