using UnityEngine;
using UnityEngine.UI;

public class LevelScroll : MonoBehaviour
{

    public Image selectedLevel;
    public Image rightLevel;
    public Image leftLevel;

    public Sprite[] levelImages;
    public int currentIndex;
    // Level index

    void Update()
    {
        selectedLevel.sprite = levelImages[currentIndex % levelImages.Length];
        rightLevel.sprite = levelImages[(currentIndex + 1) % levelImages.Length];
        leftLevel.sprite = levelImages[(currentIndex - 1) % levelImages.Length]; 


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
        }    
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
        }     

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Valitsit Levelin: " + levelImages[currentIndex % levelImages.Length].name);
        } 
    }
}
