using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class GameManager : MonoBehaviour {
    bool gameEnded = false;
    public void EndGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("lost");
            Invoke("Restart", 1f);
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Start()
    {
 
    }

}
