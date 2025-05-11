using UnityEngine;
using UnityEngine.SceneManagement;

public class resetDiskPos : MonoBehaviour
{
    public GameObject disk;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            rb = disk.GetComponent<Rigidbody>();
            Vector3 resetPositon = new Vector3(8.22f, .3f, -3.36f);
            disk.transform.position = resetPositon;
            rb.linearVelocity = Vector3.zero;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
}
