using UnityEngine;
using TMPro;


public class PocketHandler : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    


    private void Start()
    {
        winTextObject.SetActive(false);
        count = 15;
        SetCountText();
    }

    public void Decrement()
    {
        count -= 1;
    }

    public void SetCountText()
    {
        countText.text = "Balls Left: " + count.ToString();
        if (count == 0)
        {
            winTextObject.SetActive(true);
        }
    }


}
