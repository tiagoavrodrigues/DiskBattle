using UnityEngine;

public class createObstacle : MonoBehaviour
{
    public GameObject Obstacle;
    public GameObject HeighReference;
    public float minInterval = 0;
    public float maxInterval = 1.5f;
    public float interval = 2;
    public float timer = 0;
    public float x = 12.86f;
    public float z = 1.67f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        createObstacles();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < interval)
        {
            timer += Time.deltaTime;
        }
        else
        {
            createObstacles();
            timer = 0;
        }
    }


    void createObstacles()
    {
        Instantiate(Obstacle, new Vector3(x, HeighReference.transform.position.y, z), transform.rotation);
        interval = Random.Range(this.minInterval, this.maxInterval);
    }
}
