using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        //if(currentHealth > 0)
        //{

        //}
        //else
        //{

        //}
    }

    private void Update()
    {
        if (currentHealth == 0)
        {
            Debug.Log("Hävisit");
            SceneManager.LoadScene("Lose");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin"))
        {
            TakeDamage(1);
        }
    }
}
