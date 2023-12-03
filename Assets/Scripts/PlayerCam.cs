using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX, sensY;
    public Transform orientation;
    public Vector2 turn;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        turn.x += Input.GetAxisRaw("Mouse X") * sensX;
        turn.y += Input.GetAxisRaw("Mouse Y")  * sensY;

        turn.y = Mathf.Clamp(turn.y, -90f, 90f);

        transform.rotation = Quaternion.Euler(-turn.y, turn.x, 0);
        orientation.rotation = Quaternion.Euler(0, turn.x, 0);
    }
}
