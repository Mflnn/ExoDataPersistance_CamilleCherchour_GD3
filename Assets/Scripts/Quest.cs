using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Quest : MonoBehaviour
{
    [SerializeField] bool IsFinished;
    [SerializeField] bool IsStarted;
    public int[] Objectives;

   public void QuestFinished()
        {
        IsFinished = true;
        }

   public void StartQuest()
    {
        IsStarted = true;
    }


}
