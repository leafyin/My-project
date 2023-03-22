using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        print("游戏开始");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        IsReach();
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
