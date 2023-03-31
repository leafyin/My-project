using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvent : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("点击了");
        Debug.Log(Time.deltaTime);
        //GetComponent<Rigidbody>().AddForce(-transform.forward * 500f);
        //GetComponent<Rigidbody>().useGravity = true;
    }

}
