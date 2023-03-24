using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    public GameObject player;
    public Light myLight;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        // 获取Light
        // myLight = GetComponent<Light>();

        // 检查对象活跃状态
        Debug.Log(player.activeSelf);

        // 检查对象在场景中是否活跃
        Debug.Log(player.activeInHierarchy);

        // 激活对象
        player.SetActive(false);
        player.SetActive(true);
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
        Turn();
        IsReach();
        ChangeColor();
        LightToggle();

        // 线性插值函数
        // 光线强度随时间变化
        myLight.intensity = Mathf.Lerp(myLight.intensity, 5f, 0.3f * Time.deltaTime);

        // 球体颜色随时间变化
        player.GetComponent<Renderer>().material.color = Color.Lerp(Color.black, Color.green, 0.2f * Time.deltaTime);

        // 场景随时间从A到B移动
        //Vector3 from = new Vector3(10f, 11f, 12f);
        //Vector3 to = new Vector3(14f, 15f, 16f);
        //player.transform.position = Vector3.Lerp(from, to, 0.1f * Time.deltaTime);

        // 删除游戏内组件和对象
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Destroy(target.GetComponent<Renderer>());
            Destroy(target);
        }
    }

    /*
     * 灯光开关，启用或者禁用组件
     */
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

    /*
     * 移动球体
     */
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

    /*
     * 转动方块
     */
    public void Turn()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            target.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            target.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
    }

    public void IsReach()
    {
        if (player.transform.position == target.transform.position)
        {
            print("游戏结束");
        }
    }
}
