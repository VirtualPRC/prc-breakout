using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    /// <summary>
    /// 初速
    /// </summary>
    public float speed = 10;


    // Use this for initialization
    void Start()
    {
        // 初速を設定
        var force = (this.transform.forward + this.transform.right) * speed;
        GetComponent<Rigidbody>().AddForce(force, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
