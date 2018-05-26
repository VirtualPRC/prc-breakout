using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10;
    public float speedUpRate = 1.1f;
    public int speedUpCollisionCount = 10;
    private int collisionCount;

    private void Start()
    {
        var force = (transform.forward + transform.right) * speed;
        GetComponent<Rigidbody>().AddForce(force, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisionCount += 1;
        if (collisionCount > speedUpCollisionCount)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity * speedUpRate;
            collisionCount = 0;
        }
    }
}