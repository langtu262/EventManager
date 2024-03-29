using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textHealth;
    [SerializeField] TextMeshProUGUI _textCoin;
    // Start is called before the first frame update
    void Start()
    {
        EventManagerGame.onHealth.AddListener(UpdateHealth);
        EventManagerGame.onCoin.AddListener(UpdateCoin);
       
    } 

  
    void UpdateHealth(int health)
    {
        _textHealth.text = ("Health: " + health.ToString());
    }
    void UpdateCoin(int coin)
    {
        _textCoin.text = ("Coin: " + coin.ToString());
    }
    private void OnDisable()
    {
        EventManagerGame.onHealth.RemoveListener(UpdateHealth);
        EventManagerGame.onCoin.RemoveListener(UpdateCoin);
    }
}
 