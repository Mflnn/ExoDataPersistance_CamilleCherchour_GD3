using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJ : MonoBehaviour, IPNJ
{
    public Dialogue[] Sentences;
    public Quest Quete;
    public int StartSentence;
    public int EndSentence;
    public int IntermediateSentence;
    public void InteractionPNJ()
    {
        if (!Quete.IsStarted)
        {
            DialogueStart(StartSentence);
            
            if(DialogueStart:QuestStarted)
            { 
                
            }
        }
        else
        {
            if (!Quete.IsFinished)
            {
                DialogueStart(IntermediateSentence);
            }
        }
        
        
    }

    public void DialogSystem()
    {
        Start(int StartLineNumber);
        Quete.IsStarted = true;
    }
}
