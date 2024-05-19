using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsUIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameControlsScreen;

    private void Awake()
    {
        gameControlsScreen.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}