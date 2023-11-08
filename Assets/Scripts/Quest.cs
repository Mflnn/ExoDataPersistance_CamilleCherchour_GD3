using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "QuestData")]
public class Quest : ScriptableObject
{
    public bool IsFinished;
    public bool IsStarted;
    public Objective[] Objectifs;

   public void QuestFinished()
    {
        IsFinished = true;
    }

   public void StartQuest()
    {
        IsStarted = true;
    }


}
