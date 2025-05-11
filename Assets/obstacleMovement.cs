using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float velocity = 5;
    public float destroy = 3.8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * velocity) * Time.deltaTime;

        if (transform.position.x < destroy) Destroy(gameObject);
    }
}