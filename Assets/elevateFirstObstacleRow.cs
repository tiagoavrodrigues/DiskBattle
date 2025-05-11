using UnityEngine;

public class ElevateFirstObstacleRow : MonoBehaviour
{
    public GameObject heightReference;

    private void OnTriggerEnter(Collider other)
    {
        // Find all objects with the tag
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("obst1");

        // Raise each one
        if (heightReference.transform.position.y == .35f) { 
            Vector3 newPosition = new Vector3(
                heightReference.transform.position.x,
                0.7f,
                heightReference.transform.position.z);
            heightReference.transform.position = newPosition;

            // Raise each one
            foreach (GameObject obj in obstacles)
            {
                newPosition = new Vector3(
                    obj.transform.position.x,
                    0.7f,
                    obj.transform.position.z
                );
                obj.transform.position = newPosition;
            }
        }
    }
}
