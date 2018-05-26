using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 衝突時の処理
    /// </summary>
    /// <param name="collision"> 衝突オブジェクト </param>
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
