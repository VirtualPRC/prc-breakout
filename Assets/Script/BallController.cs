using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10;
    public float speedUpRate = 1.1f;
    private int collisionCount;

    private void Start()
    {
        var force = (transform.forward + transform.right) * speed;
        GetComponent<Rigidbody>().AddForce(force, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisionCount += 1;
        if (collisionCount > 10)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity * speedUpRate;
            collisionCount = 0;
        }
    }
}