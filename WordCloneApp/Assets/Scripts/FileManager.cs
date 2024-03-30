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

    public void OnSaveAsButtonClick()
    {
        var path = StandaloneFileBrowser.SaveFilePanel("Title", "", "sample", "txt");
        if (!string.IsNullOrEmpty(path))
        {
            File.WriteAllText(path, dataText.text);
        }
    }

    public void OnOpenFileClick()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Title", "", "txt", false);
        if (paths.Length > 0)
        {
            StartCoroutine(OutputRoutine(new System.Uri(paths[0]).AbsoluteUri));
        }
    }
    private IEnumerator OutputRoutine(string url)
    {
        var loader = new WWW(url);
        yield return loader;
        dataText.text = loader.text;
    }
}