using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PNJ : MonoBehaviour, IPNJ
{
    public Dialogue[] Sentences;
    public Quest Quete;
    public int StartSentence;
    public int EndSentence;
    public int IntermediateSentence;

    public void DialogueStart(int StartLineNumber)
    {
        Quete.IsStarted = true;


        
    }
    public void InteractionPNJ()
    {
        if (!Quete.IsStarted)
        {
            DialogueStart(StartSentence);

            if (Quete.IsStarted)
            {
                return;
            }


        }
        else
        {
            if (!Quete.IsFinished)
            {
                DialogueStart(IntermediateSentence);
            }

            else
            {
                DialogueStart(EndSentence);
            }
        }


    }

    
}
