using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    [SerializeField] private int _coin = 0;
    private float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
   
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Damager")
        {
            currentHealth -= 60;
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Coin")
        {
            _coin += 5;
            Destroy(other.gameObject);
        }
    }

    public float UpdateHealth()
    {
        return currentHealth;
    }
    public int UpdateCoin()
    {
        return _coin;
    }
   
}
