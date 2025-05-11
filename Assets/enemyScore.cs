using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyScore : MonoBehaviour
{

    public GameObject disk;
    Rigidbody rb;
    public TextMesh text;
    public GameObject defeatText;

    int points = 0;
    private void OnTriggerEnter(Collider other)
    {
        rb = disk.GetComponent<Rigidbody>();
        Vector3 resetPositon = new Vector3(8.22f, .3f, -3.36f);
        disk.transform.position = resetPositon;
        rb.linearVelocity = Vector3.zero;
        points++;
        text.text = points.ToString();
        if (points == 10)
        {
            defeatText.SetActive(true);
            resetGame();
        }

    }

    private void resetGame()
    {
        float time = 0f;
        while (time < 4)
        {
            time += Time.deltaTime;
        }
        SceneManager.LoadScene("GameScene");
    }
}
