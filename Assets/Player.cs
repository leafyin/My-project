using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject sphere;
    private Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        // 获取Light
        myLight = GetComponent<Light>();
        print("游戏开始");
    }

    private void FixedUpdate()
    {

    }

    private void LateUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        IsReach();
        ChangeColor();
        LightToggle();
    }

    private void LightToggle()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }

    void ChangeColor() {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

    public void Move()
    {
        if (Input.GetKeyDown(KeyCode.W) && transform.position.z != 1)
        {
            transform.Translate(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.S) && transform.position.z != -1)
        {
            transform.Translate(Vector3.back);
        }
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x != -1)
        {
            transform.Translate(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x != 1)
        {
            transform.Translate(Vector3.right);
        }
    }

    public void IsReach()
    {
        if (transform.position == sphere.transform.position)
        {
            print("游戏结束");
        }
    }
}
