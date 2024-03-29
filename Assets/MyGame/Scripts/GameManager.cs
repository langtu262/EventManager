using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.BackGroundMusic();
        EventManagerGame.onHealth.AddListener(UpdateHealth);
    }
    void UpdateHealth(int health)
    {
        if (health < 0) 
        {
            FinishGame();
        }
    }

    // Update is called once per frame
  
    void FinishGame()
    {
        SceneManager.LoadScene("GameOver");
    }
    private void OnDisable()
    {
        EventManagerGame.onHealth.RemoveListener(UpdateHealth);
    }
}
