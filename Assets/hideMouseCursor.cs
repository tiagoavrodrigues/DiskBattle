using UnityEngine;
using UnityEngine.InputSystem;

public class HideMouseCursor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
    }

}
