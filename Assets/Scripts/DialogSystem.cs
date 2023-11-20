using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSystem : MonoBehaviour
{
    [SerializeField] private DialogueDatas _DialogDatas;
    [SerializeField] private UIDialogLong _UIDialog;
    [SerializeField] private UIDialogAnswers _UIDialogAnswers;

    public void StartTarlking(int DialogueSentenceNumber)
    {
        _UIDialog.ShowLongDialog(_DialogDatas.Sentences[DialogueSentenceNumber].LongSentence);
        string[] answers = new string[2];
        if (_DialogDatas.Sentences [DialogueSentenceNumber].answer1 != -1)
        {
            answers[0] = _DialogDatas.Sentences[_DialogDatas.Sentences[DialogueSentenceNumber].answer1].ShortSentence;
        }else
        {
            answers[0] = "";
        }

        if (_DialogDatas.Sentences[DialogueSentenceNumber].answer2 != -1)
        {
            answers[0] = _DialogDatas.Sentences[_DialogDatas.Sentences[DialogueSentenceNumber].answer2].ShortSentence;
        }
        else
        {
            answers[0] = "";
        }

        _UIDialogAnswers.ShowAnswers(answers);

    }
}
