using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour
{
    public Material GoalTouch;
    public Material MainGoal;
    public Material BuddyGoal;
    [SerializeField]
    private Transform _players;
    private bool _goal1Triggerd;
    private bool _goal2Triggerd;

    public bool Goal1Triggererd
    {
        get { return _goal1Triggerd; }
    }

    public bool Goal2Triggered
    {
        get { return _goal2Triggerd; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _players)
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            if (renderer)
                renderer.material = GoalTouch;

            if (tag == "GoalA")
            {
                _goal1Triggerd = true;
            }
            else if (tag == "GoalB")
            {
                _goal2Triggerd = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform == _players)
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();

            if (renderer)
            {
                if (tag == "GoalA")
                {
                    renderer.material = MainGoal;
                    _goal1Triggerd = false;
                }
                else if (tag == "GoalB")
                {
                    renderer.material = BuddyGoal;
                    _goal2Triggerd = false;
                }
            }
        }
    }
}
