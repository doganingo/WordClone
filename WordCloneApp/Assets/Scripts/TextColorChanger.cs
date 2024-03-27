using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.UI;
using System.Collections;

public class TextColorChanger : MonoBehaviour
{
    public TMP_InputField inputField;
    //public Color targetColor = Color.red; // Deðiþtirmek istediðiniz hedef renk
    public Color targetColor;
    private int selectionStartIndex; // Seçimin baþlangýç indeksi
    private int selectionEndIndex; // Seçimin bitiþ indeksi
    private bool colorChanged = false; // Metnin rengi deðiþtirildi mi?
    public FlexibleColorPicker fCP;
    public bool isColorButtonClicked;
    public float delay = 5.0f;
    
    public GameObject colorButton;
    public UnityEngine.UI.Image colorButtonBackGround;

    private void Start()
    {
        colorButtonBackGround = colorButton.GetComponent<UnityEngine.UI.Image>();
    }
    private void Update()
    {
        targetColor = fCP.color;
    }
    public void ChangeSelectedTextToColor()
    {
        if (inputField != null)
        {
            //colorButtonBackGround.color = targetColor;
            // Seçimin baþlangýç ve bitiþ indekslerini al
            selectionStartIndex = inputField.selectionStringAnchorPosition;
            selectionEndIndex = inputField.selectionStringFocusPosition;

            // Baþlangýç indeksini bitiþ indeksinden küçük yap
            if (selectionStartIndex > selectionEndIndex)
            {
                int temp = selectionStartIndex;
                selectionStartIndex = selectionEndIndex;
                selectionEndIndex = temp;
            }

            // Seçili metni deðiþtir
            string originalText = inputField.text;
            string selectedText = originalText.Substring(selectionStartIndex, selectionEndIndex - selectionStartIndex);
            string coloredText = "<color=#" + ColorUtility.ToHtmlStringRGB(targetColor) + ">" + selectedText + "</color>";
            string newText = originalText.Substring(0, selectionStartIndex) + coloredText + originalText.Substring(selectionEndIndex);

            // Metni güncelle
            inputField.text = newText;
            colorChanged = true;
        }
    }

    public void RestoreOriginalText()
    {
        if (colorChanged)
        {
            // Metni orijinal haline geri döndür
            inputField.text = inputField.text.Replace("<color=#" + ColorUtility.ToHtmlStringRGB(targetColor) + ">", "");
            inputField.text = inputField.text.Replace("</color>", "");
            colorChanged = false;
        }
    }
}
