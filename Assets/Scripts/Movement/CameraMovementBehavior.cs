using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform _player1;
    [SerializeField]
    private Transform _player2;
    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.P))
            transform.position = _player1.transform.position + new Vector3(0, 3, -8);
        else if (Input.GetKey(KeyCode.P))
            transform.position = _player2.transform.position + new Vector3(0, 3, -8);
    }
}
