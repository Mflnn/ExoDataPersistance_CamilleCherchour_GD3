using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "QuestData")]
public class Quest : ScriptableObject
{
    public bool IsFinished = false;
    public bool IsStarted= false;
    public Objective[] Objectives;
    

   public void QuestFinished()
    {
        IsFinished = true;
    }

   public void StartQuest()
    {
        IsStarted = true;
    }

    public void CheckQuest()
    {
        bool result = true;
        for (int i = 0; i < Objectives.Length; i++)
        {
            if (!Objectives[i].IsFinished)
            {
                result = false;
                break;
            }
        }
        if (result)
        {
            QuestFinished();
        }
    }

    public void CheckObjective(int NumObject)
    {
        if (Objectives[NumObject].ActualValue == Objectives[NumObject].MaxValue)
        {
            Objectives[NumObject].IsFinished = true;
            CheckQuest();
        }
    }

    public void UpdateObjective(Collectible collectible)
    {
        for (int i = 0; i < Objectives.Length; i++)
        {
            if (collectible.collectibleType == Objectives[i].CollectibleType)
            {
                Objectives[i].ActualValue += collectible._value;
                CheckObjective(i);
            }
            
        }
    }
}
