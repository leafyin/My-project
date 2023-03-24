using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAndKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetKey();
    }

    void GetKey()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if (down)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (held)
        {
            GetComponent<Renderer>().material.color = Color.gray;
        }
        else if (up)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            Debug.Log("Button now is free!");
        }
    }

    void GetButton()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if (down)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else if (held)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (up)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            Debug.Log("Button now is free!");
        }
    }
}
