using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private int scrapCount = 0;

    private int lockpickCost = 5;

    [SerializeField]
    private int lockpickCount = 0;

    [SerializeField]
    private AudioSource errorAudio;

    [SerializeField]
    private TextMeshProUGUI scrapText;

    [SerializeField]
    private TextMeshProUGUI lockpickText;
    public void UpdateScrap()
    {
        scrapCount++;
        scrapText.text = "Scrap: " + scrapCount;
    }
    public void UpdateLockpick()
    {
        if (scrapCount >= lockpickCost)
        {
            lockpickCount++;
            scrapCount -= lockpickCost;
            scrapText.text = "Scrap: " + scrapCount;
            lockpickText.text = "Lockpicks: " + lockpickCount;
        }
        else
        {
            errorAudio.Play();
        }
    }
}
