using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FindAndRePlace : MonoBehaviour
{
    public TMP_InputField mainInputField;
    public TMP_InputField findInputField;
    public TMP_InputField rePlaceInputField;

    string mainText;
    string outputText;

    string findKey;
    string rePlaceKey;

    public void FindAndRePlaceWord()
    {
        outputText = "";
        findKey = findInputField.text;
        rePlaceKey = rePlaceInputField.text;
        mainText = mainInputField.text;
        outputText = mainText.Replace(findKey, rePlaceKey);
        mainInputField.text = outputText;

    }
}
