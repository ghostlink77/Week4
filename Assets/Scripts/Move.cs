using UnityEngine;

public class Move : MonoBehaviour
{
    private void Start()
    {
        //Vector3 vec = new Vector3(0.5f, 0, 0);
        //transform.Translate(vec);
    }

    Vector3 target = new Vector3(2.2f, 1.5f, 0.3f);

    void Update()
    {
        //if(Input.anyKeyDown)    
        //    Debug.Log("Key Pressed");
        //if (Input.anyKey)       
        //    Debug.Log("Key Held");

        //if (Input.GetKeyDown(KeyCode.Return)) 
        //    Debug.Log("Enter Pressed");
        //if (Input.GetKey(KeyCode.W))
        //    Debug.Log("W Held");
        //if (Input.GetKeyUp(KeyCode.W)) 
        //    Debug.Log("W Released");

        if(Input.GetMouseButtonDown(0)) 
            Debug.Log("Left Mouse Button Pressed");

        if(Input.GetButtonDown("Jump"))
            Debug.Log("Jump Pressed");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Hrizontal Held : " + Input.GetAxis("Horizontal"));
            //Debug.Log("Hrizontal Held : " + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("Hrizontal Held : " + Input.GetAxis("Vertical"));
            //Debug.Log("Hrizontal Held : " + Input.GetAxisRaw("Horizontal"));
        }

        Vector3 movement = new Vector3(
            Input.GetAxis("Horizontal") * Time.deltaTime, 
            0, 
            Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Translate(movement);


        //transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);

        Vector3 vel = Vector3.zero; 
        transform.position = Vector3.SmoothDamp(transform.position, target, ref vel, 0.1f);
    }
}
