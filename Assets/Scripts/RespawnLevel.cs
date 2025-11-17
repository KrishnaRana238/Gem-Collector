using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnLevel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        ScoreControl.totalScore = 0;
        SceneManager.LoadScene(4);
    }
}
