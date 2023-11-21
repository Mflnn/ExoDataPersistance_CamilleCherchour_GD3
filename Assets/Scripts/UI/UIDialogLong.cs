using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDialogLong : MonoBehaviour
{
    [SerializeField] GameObject _DialogPanel;
    [SerializeField] TMP_Text _longSentenceText;

    public void ShowLongDialog(string LongSentence)
    {
        _longSentenceText.text = LongSentence;
        if(!_DialogPanel.activeInHierarchy)
        {
            _DialogPanel.SetActive(true);
        }
    }

    public void HideDialog()
    {
        _DialogPanel.SetActive(false);
    }
}
