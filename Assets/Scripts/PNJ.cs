using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PNJ : MonoBehaviour, IPNJ
{
    public Quest Quete;
    public int StartSentence;
    public int EndSentence;
    public int IntermediateSentence;
    private DialogSystem _dialogSystem;

    public void Start ()
    {
        _dialogSystem = GetComponent<DialogSystem>();
        Quete.IsStarted = true;


        
    }
    public void InteractionPNJ()
    {
        if (!Quete.IsStarted)
        {
            _dialogSystem.StartTalking(StartSentence);
        }
        else
        {
            if (!Quete.IsFinished)
            {
                _dialogSystem.StartTalking(IntermediateSentence);
            }

            else
            {
                _dialogSystem.StartTalking(EndSentence);
            }
        }


    }

    
}
