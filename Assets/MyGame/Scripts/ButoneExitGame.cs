using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ButoneExitGame : MonoBehaviour
{
    private Button _exitGame;
    // Start is called before the first frame update
    void Start()
    {
        _exitGame = GetComponent<Button>();
        _exitGame.onClick.AddListener(exitGame);

    }

    // Update is called once per frame
    void exitGame()
    {
        Application.Quit();
    }
}
