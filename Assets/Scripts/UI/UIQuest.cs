using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIQuest : MonoBehaviour
{
    [SerializeField] GameObject _questPanel;

    [SerializeField] Objective[] _objective;
    
    [SerializeField] TMP_Text BronzeValue;
    [SerializeField] TMP_Text IronValue;
    [SerializeField] TMP_Text GoldValue;

    public void ShowQuestUI()
    {
        _questPanel.SetActive(true);
    }
    public void HideQuesUI()
    {
        _questPanel.SetActive(false);
    }

    public void OnEnable()
    {
        Quest.OnQuestUpdate += UpdateObjectiveUI;
        UpdateObjectiveUI(4);
    }

    public void UpdateObjectiveUI(int scoreValue)
    {
       BronzeValue.text = _objective[0].ActualValue.ToString();
       IronValue.text = _objective[1].ActualValue.ToString();
       GoldValue.text = _objective[2].ActualValue.ToString();
    }
}
