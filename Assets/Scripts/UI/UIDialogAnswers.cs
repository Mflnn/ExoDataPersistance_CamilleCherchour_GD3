using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIDialogAnswers : MonoBehaviour
{
    [SerializeField] GameObject _AnswersPanel;
    [SerializeField] Button[] _AnswerButton;
    [SerializeField] DialogSystem _dialogSystem;

    public void ShowAnswers(string[]answers)
    {
        for(int i=0; i< _AnswerButton.Length; i++)
        {
            _AnswerButton[i].transform.GetChild(0).GetComponent<TMP_Text>().text = answers[i];
            if (answers[i] == "")
            {
                _AnswerButton[i].gameObject.SetActive(false);
            }
            else
            {
                _AnswerButton[i].gameObject.SetActive(true);
            }
        }
        if (!_AnswersPanel.activeInHierarchy)
        {
            _AnswersPanel.SetActive(true);
        }
        
    }
}
