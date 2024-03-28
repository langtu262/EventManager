using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private PlayerManager _playManager;
    // Start is called before the first frame update
    void Start()
    {
        _playManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
        AudioManager.Instance.BackGroundMusic();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playManager != null && _playManager.UpdateHealth() <= 0)
        {
            FinishGame();
        }

    }
    void FinishGame()
    {
        SceneManager.LoadScene("GameOver");
    }
}
