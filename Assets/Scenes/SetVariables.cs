using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVariables : MonoBehaviour
{
    [SerializeField] private Quest _quete;
    [SerializeField] private Objective[] _objective;
    void Start()
    {
        _quete.IsStarted = false;
        _quete.IsFinished = false;
        for (int i = 0; i < _objective.Length; i++)
            {
            if (_objective[i] != null)
            {
                _objective[i].StartValue = 0;
                _objective[i].ActualValue = 0;
                _objective[i].IsFinished = false;
            }
            else
            {
                return;
            }
             }
        

    }

}
