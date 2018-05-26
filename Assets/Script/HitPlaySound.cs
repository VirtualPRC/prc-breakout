using UnityEngine;

public class HitPlaySound : MonoBehaviour
{
    public AudioClip sound;

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}