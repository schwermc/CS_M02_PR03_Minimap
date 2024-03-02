using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform player;
    public GameObject minimap;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            minimap.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            minimap.SetActive(false);
        }
    }

    private void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = player.position.y + 5;
        transform.position = newPosition;

        // Rotate with player code
        // transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }
}
