using UnityEngine;


public class MenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject creditsCanvasPrefab;
    
    [SerializeField]
    private AudioSource audioSource;
    
    public void OpenCredits()
    {
        Instantiate(creditsCanvasPrefab);
    }
    public void CloseCredits()
    {
        Destroy(creditsCanvasPrefab);
    }
    public void ButtonSound()
    {
        audioSource.Play();
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
