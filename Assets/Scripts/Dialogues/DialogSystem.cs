using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSystem : MonoBehaviour
{
    [SerializeField] private DialogueDatas _DialogDatas;
    [SerializeField] private UIDialogLong _UIDialog;
    [SerializeField] private UIDialogAnswers _UIDialogAnswers;
    private int actualSentence;

    public void StartTalking(int DialogueSentenceNumber)
    {
        actualSentence = DialogueSentenceNumber;
        _UIDialog.ShowLongDialog(_DialogDatas.Sentences[DialogueSentenceNumber].LongSentence);
        int[] answerNumber = new int[2];
        answerNumber[0] = _DialogDatas.Sentences[actualSentence].answer1;
        answerNumber[1] = _DialogDatas.Sentences[actualSentence].answer2;
        string[] answers = new string[2];
        for( int i = 0; i <answerNumber.Length; i++)
        {
            if (answerNumber[i] != -1)
            {
                answers[i] = _DialogDatas.Sentences[answerNumber[i]].ShortSentence;
            }
            else
            {
                answers[i] = "";
            }

        }
        

        _UIDialogAnswers.ShowAnswers(answers);

    }

    public void SelectAnswer(int  answerNumber)
    {
        if(answerNumber == 0)
        {
            StartTalking(_DialogDatas.Sentences[actualSentence].answer1);
        }else
        {
            StartTalking(_DialogDatas.Sentences[actualSentence].answer2);
        }
        
    }
}
