using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BoldScript : MonoBehaviour
{
    public TMP_Text textMeshProComponent; // Metni içeren TextMeshProUGUI bileþeni

    // Butona týklandýðýnda çaðrýlacak fonksiyon
    public void ToggleBold()
    {
        if (textMeshProComponent != null)
        {
            // Mevcut font stilini al
            FontStyles currentStyle = textMeshProComponent.fontStyle;

            // Kalýnlaþtýrma kontrolü yap
            if (currentStyle.HasFlag(FontStyles.Bold))
            {
                // Eðer metin zaten kalýn ise normal stile geri dön
                textMeshProComponent.fontStyle &= ~FontStyles.Bold;
            }
            else
            {
                // Metni kalýnlaþtýr
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

            // Italik kontrolü yap
            if (currentStyle.HasFlag(FontStyles.Italic))
            {
                // Eðer metin zaten italik ise normal stile geri dön
                textMeshProComponent.fontStyle &= ~FontStyles.Italic;
            }
            else
            {
                // Metni italik yap
                textMeshProComponent.fontStyle |= FontStyles.Italic;
            }
        }
    }

    // Altý çizili durumunu kontrol eden fonksiyon
    public void ToggleUnderline()
    {
        if (textMeshProComponent != null)
        {
            // Mevcut font stilini al
            FontStyles currentStyle = textMeshProComponent.fontStyle;

            // Altý çizili kontrolü yap
            if (currentStyle.HasFlag(FontStyles.Underline))
            {
                // Eðer metin zaten altý çizili ise normal stile geri dön
                textMeshProComponent.fontStyle &= ~FontStyles.Underline;
            }
            else
            {
                // Metni altý çizili yap
                textMeshProComponent.fontStyle |= FontStyles.Underline;
            }
        }
    }

    // Metni büyüten fonksiyon
    public void IncreaseFontSize()
    {
        if (textMeshProComponent != null)
        {
            // Metin boyutunu artýr
            textMeshProComponent.fontSize += 1;
        }
    }

    // Metni küçülten fonksiyon
    public void DecreaseFontSize()
    {
        if (textMeshProComponent != null)
        {
            // Metin boyutunu azalt
            textMeshProComponent.fontSize -= 1;
        }
    }
}