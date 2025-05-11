using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
