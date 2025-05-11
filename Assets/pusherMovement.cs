using UnityEngine;

public class PerfectMousePusher : MonoBehaviour
{
    [SerializeField] private float hitForce = 15f;
    [SerializeField] private float fixedHeight = 0.3f; // Set to your desired Y position

    private Camera mainCamera;
    private float zDistance;

    private void Start()
    {
        mainCamera = Camera.main;
        // Calculate the correct Z distance for mouse tracking
        zDistance = Mathf.Abs(mainCamera.transform.position.y - fixedHeight);
    }

    private void Update()
    {
        // Get mouse position with perfect depth calculation
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = zDistance;

        // Convert to world position and lock Y
        Vector3 worldPos = mainCamera.ScreenToWorldPoint(mousePos);
        worldPos.y = fixedHeight;

        // Apply position directly (no smoothing)
        transform.position = worldPos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Disk"))
        {
            Vector3 hitDirection = (collision.transform.position - transform.position).normalized;
            collision.rigidbody.AddForce(hitDirection * hitForce, ForceMode.Impulse);
        }
    }
}