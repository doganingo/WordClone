using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BoldScript : MonoBehaviour
{
    public TMP_Text textMeshProComponent; // Metni i�eren TextMeshProUGUI bile�eni

    // Butona t�kland���nda �a�r�lacak fonksiyon
    public void ToggleBold()
    {
        if (textMeshProComponent != null)
        {
            // Mevcut font stilini al
            FontStyles currentStyle = textMeshProComponent.fontStyle;

            // Kal�nla�t�rma kontrol� yap
            if (currentStyle.HasFlag(FontStyles.Bold))
            {
                // E�er metin zaten kal�n ise normal stile geri d�n
                textMeshProComponent.fontStyle &= ~FontStyles.Bold;
            }
            else
            {
                // Metni kal�nla�t�r
                textMeshProComponent.fontStyle |= FontStyles.Bold;
            }
        }
    }

    // Italik durumunu kontrol eden fonksiyon
    public void ToggleItalic()
    {
        if (textMeshProComponent != null)
        {
            // Mevcut font stilini al
            FontStyles currentStyle = textMeshProComponent.fontStyle;

            // Italik kontrol� yap
            if (currentStyle.HasFlag(FontStyles.Italic))
            {
                // E�er metin zaten italik ise normal stile geri d�n
                textMeshProComponent.fontStyle &= ~FontStyles.Italic;
            }
            else
            {
                // Metni italik yap
                textMeshProComponent.fontStyle |= FontStyles.Italic;
            }
        }
    }

    // Alt� �izili durumunu kontrol eden fonksiyon
    public void ToggleUnderline()
    {
        if (textMeshProComponent != null)
        {
            // Mevcut font stilini al
            FontStyles currentStyle = textMeshProComponent.fontStyle;

            // Alt� �izili kontrol� yap
            if (currentStyle.HasFlag(FontStyles.Underline))
            {
                // E�er metin zaten alt� �izili ise normal stile geri d�n
                textMeshProComponent.fontStyle &= ~FontStyles.Underline;
            }
            else
            {
                // Metni alt� �izili yap
                textMeshProComponent.fontStyle |= FontStyles.Underline;
            }
        }
    }

    // Metni b�y�ten fonksiyon
    public void IncreaseFontSize()
    {
        if (textMeshProComponent != null)
        {
            // Metin boyutunu art�r
            textMeshProComponent.fontSize += 1;
        }
    }

    // Metni k���lten fonksiyon
    public void DecreaseFontSize()
    {
        if (textMeshProComponent != null)
        {
            // Metin boyutunu azalt
            textMeshProComponent.fontSize -= 1;
        }
    }
}