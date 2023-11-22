using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ScoreDatas;

[CreateAssetMenu(menuName = "QuestData")]
public class Quest : ScriptableObject
{
    [SerializeField] public bool IsFinished = false;
    [SerializeField] public bool IsStarted = false;
    public Objective[] Objectives;
    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnQuestUpdate;




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
        if (Objectives[NumObject].ActualValue >= Objectives[NumObject].MaxValue)
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
                OnQuestUpdate?.Invoke(1);
                break;
            }
            
        }
    }
}
