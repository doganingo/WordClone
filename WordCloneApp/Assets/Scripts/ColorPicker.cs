using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    public FlexibleColorPicker fCP;
    public Color color;

    private void Start()
    {

    }
    private void Update()
    {
        color = fCP.color;
    }
}
