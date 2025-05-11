using UnityEngine;

public class ResetObstacleHeight : MonoBehaviour
{
    public GameObject heightReference;
    public GameObject heightReference2;

    private void OnTriggerEnter(Collider other)
    {
        // Find all objects with the tag
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("obst1");
        GameObject[] obstacles2 = GameObject.FindGameObjectsWithTag("obst2");

        // Raise each one
        if (heightReference.transform.position.y != .35f)
        {
            Vector3 newPosition = new Vector3(
                heightReference.transform.position.x,
                .35f,
                heightReference.transform.position.z
            );

            heightReference.transform.position = newPosition;

            // Raise each one
            foreach (GameObject obj in obstacles)
            {
                newPosition = new Vector3(
                    obj.transform.position.x,
                    .35f,
                    obj.transform.position.z
                );
                obj.transform.position = newPosition;
            }
        }

        if (heightReference2.transform.position.y != .35f)
        {
            Vector3 newPosition = new Vector3(
                heightReference2.transform.position.x,
                .35f,
                heightReference2.transform.position.z
            );

            heightReference2.transform.position = newPosition;

            // Raise each one
            foreach (GameObject obj in obstacles2)
            {
                newPosition = new Vector3(
                    obj.transform.position.x,
                    .35f,
                    obj.transform.position.z
                );
                obj.transform.position = newPosition;
            }
        }
    }
}