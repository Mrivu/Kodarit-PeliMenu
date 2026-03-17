using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Selector : MonoBehaviour
{
    public Color normalColor = Color.white;
    public Color selectColor = Color.yellow;

    public TMP_Text[] items; // Meidän napit listassa
    public Color[] colors;
    private int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeColors();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            index = (index - 1 + items.Length) % items.Length;
            ChangeColors();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            index = (index + 1) % items.Length;
            ChangeColors();
        }
    }

    void ChangeColors()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (i == index)
            {
                items[i].color = selectColor;
            }
            else
            {
                items[i].color = colors[i];
            }
        }
    }
}
