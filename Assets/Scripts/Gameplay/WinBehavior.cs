using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinBehavior : MonoBehaviour
{
    [SerializeField]
    private GoalBehavior _goal1;
    [SerializeField]
    private GoalBehavior _goal2;
    [SerializeField]
    private Text _text;


    // Update is called once per frame
    void Update()
    {
        if (_goal1.Goal1Triggererd && _goal2.Goal2Triggered)
            _text.text = "YOU WIN";
    }
}
