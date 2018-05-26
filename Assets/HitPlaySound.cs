using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlaySound : MonoBehaviour
{
    /// <summary>
    /// 衝突効果音
    /// </summary>
    public AudioClip sound;

    /// <summary>
    /// 衝突時の処理
    /// </summary>
    /// <param name="collision"> 衝突オブジェクト </param>
    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}
