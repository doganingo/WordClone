using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordCountDogan : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text wordCountText;

    int wordCount;

    public void CountWords()
    {
        string text = inputField.text;
        string[] words = text.Split(new char[] { ' ', '\n', '\t' }, System.StringSplitOptions.RemoveEmptyEntries);
        wordCount = words.Length;
        Debug.Log("Word count: " + wordCount);
    }
    private void Update()
    {
        CountWords();
        wordCountText.text = "Word Count: " + wordCount.ToString();
    }
}
