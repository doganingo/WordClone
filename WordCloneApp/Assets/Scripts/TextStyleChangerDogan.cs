using UnityEngine;
using TMPro;

public class TextStyleChangerDogan : MonoBehaviour
{
    public TMP_InputField inputField;
    private int selectionStartIndex;
    private int selectionEndIndex;
    public bool styleBoldChanged = false;
    public bool styleItalicChanged = false;
    public bool styleUnderLineChanged = false;
    public int fontSize;

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

    public void RestoreBoldToUnBold()
    {
        if (styleBoldChanged)
        {
            inputField.text = inputField.text
                .Replace("<b>", "").Replace("</b>", "");
            styleBoldChanged = false;
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
    public void RestoreUnderlineToText()
    {
        if (styleUnderLineChanged)
        {
            inputField.text = inputField.text
                .Replace("<u>", "").Replace("</u>", "");
            styleUnderLineChanged = false;
        }
    }
}
