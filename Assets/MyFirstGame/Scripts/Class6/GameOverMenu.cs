using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{



    public void RestartGame()
    {
        SceneManager.LoadScene("MyFirstGame");
    }
}
