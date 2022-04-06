using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputBehavior : MonoBehaviour
{
    private PlayerMovementBehavior _playerMovement;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovementBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.P))
            _playerMovement.MoveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
    }
}
