using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SFB;
using System.Collections;
using TMPro;

public class FileManager : MonoBehaviour//, IPointerDownHandler
{
    // Sample text data
    public TMP_InputField dataText;

    //public Button saveFile, saveAs, openFile;

    //public void OnPointerDown(PointerEventData eventData) { }

    public void OnSaveButtonClicked()
    {
        if (PlayerPrefs.GetInt("isSaved") == 1)
        {
            string filePath = PlayerPrefs.GetString("localPath");

            // Veriyi metin belgesine yaz
            File.WriteAllText(filePath, dataText.text);

            Debug.Log("File saved to desktop: " + filePath);
        }
        else
        {
            OnSaveAsButtonClick();
        }
        
    }
    public void OnSaveAsButtonClick()
    {
        var path = StandaloneFileBrowser.SaveFilePanel("Title", "", "sample", "txt");
        if (!string.IsNullOrEmpty(path))
        {
            File.WriteAllText(path, dataText.text);
            Debug.Log("path: " + path);
            PlayerPrefs.SetString("localPath", path);
            PlayerPrefs.SetInt("isSaved", 1);
        }
    }

    public void OnOpenFileClick()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Title", "", "txt", false);
        if (paths.Length > 0)
        {
            StartCoroutine(OutputRoutine(new System.Uri(paths[0]).AbsoluteUri));
            PlayerPrefs.SetString("localPath", "");
            PlayerPrefs.SetInt("isSaved", 0);
        }
    }
    private IEnumerator OutputRoutine(string url)
    {
        var loader = new WWW(url);
        yield return loader;
        dataText.text = loader.text;
    }
}