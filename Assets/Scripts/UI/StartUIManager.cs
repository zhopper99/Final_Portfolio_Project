using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameStartScreen;

    private void Awake()
    {
        gameStartScreen.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ControlsMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
        //Used to test quit function
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
