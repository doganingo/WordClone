using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PageCreatorOlcar : MonoBehaviour
{
    public TMP_InputField inputField;

    public void CheckHeightAndCreateNewPage()
    {
        Debug.Log("Güncel Yükseklik" + inputField.preferredHeight);

        if(inputField.preferredHeight > 200)
        {
            Debug.Log("Yeni Sayfa oluşturuldu ve ona geçildi.");
        }
    }
}