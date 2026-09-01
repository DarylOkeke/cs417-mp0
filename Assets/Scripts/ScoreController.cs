using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private int scrapCount = 0;

    [SerializeField]
    private TextMeshProUGUI scrapText;

    public void UpdateScrap()
    {
    scrapCount++;
    scrapText.text = "Scrap: " + scrapCount;
    }
}
