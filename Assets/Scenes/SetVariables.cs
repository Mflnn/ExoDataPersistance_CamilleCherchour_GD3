using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVariables : MonoBehaviour
{
    [SerializeField] private Quest _quete;
    void Start()
    {
        _quete.IsStarted = false;
        _quete.IsFinished = false;
    }

}
