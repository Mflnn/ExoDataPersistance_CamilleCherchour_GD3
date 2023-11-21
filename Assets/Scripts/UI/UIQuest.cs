using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIQuest : MonoBehaviour
{
    [SerializeField] GameObject _questPanel;

    public void ShowQuestUI()
    {
        _questPanel.SetActive(true);
    }
    public void HideQuesUI()
    {
        _questPanel.SetActive(false);
    }
}
