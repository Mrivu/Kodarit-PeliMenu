using System.Collections;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Selector : MonoBehaviour
{
    public Color normalColor = Color.white;
    public Color selectColor = Color.yellow;
    public TMP_Text[] items; // Meidän napit listassa
    public Color[] colors;
    private int index = 0;

    public FadeControl fade;

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

        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
        {
            ActivateItem(index);
        }
    }

    public void ActivateItem(int i)
    {
        Debug.Log("Painoit nappia: " + items[i].text);

        if (items[i].text == "Start Game")
        {
            StartCoroutine(ChangeScene("Minigames"));
        }
        else if (items[i].text == "Settings")
        {
            StartCoroutine(ChangeScene("Settings"));
        }
    }

    public void SetIndex(int i)
    {
        index = i;
        ChangeColors();
    }

    private IEnumerator ChangeScene(string sceneName)
    {
        fade.FadeIn();

        yield return new WaitForSeconds(fade.fadeDuration);

        SceneManager.LoadScene(sceneName);
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
