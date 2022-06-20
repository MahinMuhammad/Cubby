using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject levelComplete;

    public void GameOver()
    {
        if(gameHasEnded == false)
        {
            Debug.Log("Game Over!!!");
            gameHasEnded = true;
            Invoke("restart", restartDelay);
        }
    }
    void restart()
    {
        gameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LevelCompleted()
    {
        levelComplete.SetActive(true);
        //Debug.Log("Level Has SuccessFully Completed!!!");
    }
}
