using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIQuest : MonoBehaviour
{
    [SerializeField] GameObject _questPanel;
    [SerializeField] Quest _quest;

    public void ShowQuestUI()
    {
        _questPanel.SetActive(true);
    }
    public void HideQuesUI()
    {
        _questPanel.SetActive(false);
    }
    public void UpdateObjectiveUI()
    {
        _quest.Objectives[0].ActualValue.ToString();
        _quest.Objectives[1].ActualValue.ToString();
        _quest.Objectives[2].ActualValue.ToString();
    }
}
