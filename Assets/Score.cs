using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour {
    //get the z position of the player
    public Transform player;
    // UI text
    public Text ScoreText;

	// Update is called once per frame
	void Update () {
        //update score text with z position of the player
        ScoreText.text = player.position.z.ToString("0");
        if (player.position.z >= 5400)
        {
            Debug.Log("reached the finish");
            // grabs the current scene and adds one to it.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    
 
    
}
