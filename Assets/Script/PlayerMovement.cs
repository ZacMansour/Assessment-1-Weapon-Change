using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.W))
        {
            float moveVertical = (Input.GetAxis("Vertical") * speed);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //transform.Translate(new Vector3(1, 0, 0));
            float moveHorizontal = (Input.GetAxis("Horizontal") * speed);
        }*/

        float moveHorizontal = (Input.GetAxis("Horizontal"));
        float moveVertical = (Input.GetAxis("Vertical"));

        transform.Translate(new Vector3(moveHorizontal, 0.0f, moveVertical) * speed);
    }
}
