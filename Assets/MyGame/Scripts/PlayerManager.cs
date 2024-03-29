using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int _coin = 0;
    [SerializeField] private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Damager")
        {
            currentHealth -= 60;
            Destroy(other.gameObject);
            EventManagerGame.onHealth?.Invoke(currentHealth);
        }
        if (other.gameObject.tag == "Coin")
        {
            _coin = 5;
            Destroy(other.gameObject);
            EventManagerGame.onCoin?.Invoke(_coin);
        }
    }
   
}
