using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyInputBehavior : MonoBehaviour
{
    private BuddyMovementBehavior _buddyMovement;

    private void Awake()
    {
        _buddyMovement = GetComponent<BuddyMovementBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
            _buddyMovement.MoveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
    }
}
