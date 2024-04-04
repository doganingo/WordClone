using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class TextStyleChangerDogan : MonoBehaviour
{
    public TMP_InputField inputField, sizeInputField;
    private int selectionStartIndex;
    private int selectionEndIndex;
    public bool styleBoldChanged = false;
    public bool styleItalicChanged = false;
    public bool styleUnderLineChanged = false;
    public int fontSize;
    public GameObject textInMainInputField;
    public TMP_Text tmpTextInMainInputField;
    public GameObject textObject;
    public TMP_Text text1;

    public bool isFontSizeChanged;

    private void Start()
    {
        textObject = GameObject.FindGameObjectWithTag("TextInMainInputField");
        text1 = textObject.gameObject.GetComponent<TMP_Text>();
        sizeInputField.onValueChanged.AddListener(OnInputFieldValueChanged);
    }

    public void ChangeSelectedTextToBold()
    {
        if (inputField != null)
        {
            selectionStartIndex = inputField.selectionStringAnchorPosition;
            selectionEndIndex = inputField.selectionStringFocusPosition;

            if (selectionStartIndex > selectionEndIndex)
            {
                int temp = selectionStartIndex;
                selectionStartIndex = selectionEndIndex;
                selectionEndIndex = temp;
            }

            string originalText = inputField.text;
            string selectedText = originalText.Substring(selectionStartIndex, selectionEndIndex - selectionStartIndex);
            string boldText = "<b>" + selectedText + "</b>";
            string newText = originalText.Substring(0, selectionStartIndex) + boldText + originalText.Substring(selectionEndIndex);

            inputField.text = newText;
            styleBoldChanged = true;
        }
    }
    public void RestoreBoldToUnBold()
    {
        if (styleBoldChanged)
        {
            inputField.text = inputField.text
                .Replace("<b>", "").Replace("</b>", "");
            styleBoldChanged = false;
        }
    }

    public void ChangeSelectedTextToItalic()
    {
        if (inputField != null)
        {
            selectionStartIndex = inputField.selectionStringAnchorPosition;
            selectionEndIndex = inputField.selectionStringFocusPosition;

            if (selectionStartIndex > selectionEndIndex)
            {
                int temp = selectionStartIndex;
                selectionStartIndex = selectionEndIndex;
                selectionEndIndex = temp;
            }

            string originalText = inputField.text;
            string selectedText = originalText.Substring(selectionStartIndex, selectionEndIndex - selectionStartIndex);
            string italicText = "<i>" + selectedText + "</i>";
            string newText = originalText.Substring(0, selectionStartIndex) + italicText + originalText.Substring(selectionEndIndex);

            inputField.text = newText;
            styleItalicChanged = true;
        }
    }
    public void RestoreItalicToNonItalic()
    {
        if (styleItalicChanged)
        {
            inputField.text = inputField.text.Replace("<i>", "").Replace("</i>", "");
            styleItalicChanged = false;
        }
    }

    public void ChangeSelectedTextToUnderline()
    {
        if (inputField != null)
        {
            selectionStartIndex = inputField.selectionStringAnchorPosition;
            selectionEndIndex = inputField.selectionStringFocusPosition;

            if (selectionStartIndex > selectionEndIndex)
            {
                int temp = selectionStartIndex;
                selectionStartIndex = selectionEndIndex;
                selectionEndIndex = temp;
            }

            string originalText = inputField.text;
            string selectedText = originalText.Substring(selectionStartIndex, selectionEndIndex - selectionStartIndex);
            string underlineText = "<u>" + selectedText + "</u>";
            string newText = originalText.Substring(0, selectionStartIndex) + underlineText + originalText.Substring(selectionEndIndex);

            inputField.text = newText;
            styleUnderLineChanged = true;
        }
    }
    public void RestoreUnderlineToText()
    {
        if (styleUnderLineChanged)
        {
            inputField.text = inputField.text
                .Replace("<u>", "").Replace("</u>", "");
            styleUnderLineChanged = false;
        }
    }

    public void ChangeSelectedTextFontSize(int newSize)
    {
        if (inputField != null)
        {
            selectionStartIndex = inputField.selectionStringAnchorPosition;
            selectionEndIndex = inputField.selectionStringFocusPosition;

            if (selectionStartIndex > selectionEndIndex)
            {
                int temp = selectionStartIndex;
                selectionStartIndex = selectionEndIndex;
                selectionEndIndex = temp;
            }

            string originalText = inputField.text;
            string selectedText = originalText.Substring(selectionStartIndex, selectionEndIndex - selectionStartIndex);
            string fontSizeText = "<size=" + newSize + ">" + selectedText + "</size>";
            string newText = originalText.Substring(0, selectionStartIndex) + fontSizeText + originalText.Substring(selectionEndIndex);

            inputField.text = newText;
            fontSize = newSize;
        }
    }
    public void ChangeSelectedTextFontSizeFromInputField()
    {
        if (sizeInputField != null)
        {
            if (int.TryParse(sizeInputField.text, out int newSize))
            {
                ChangeSelectedTextFontSize(newSize);
            }
            else
            {
                Debug.LogError("Invalid font size input.");
            }
        }
        else
        {
            Debug.LogError("Input field is not assigned.");
        }
    }

    private void OnInputFieldValueChanged(string newValue)
    {
        Debug.Log("Yeni deðer: " + newValue);
        isFontSizeChanged = true;
    }
    public void OnApplyButtonToAllPage()
    {
        int fontsize = int.Parse(sizeInputField.text);
        text1.fontSize = fontsize;
    }
}
