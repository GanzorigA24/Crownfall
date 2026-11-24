using UnityEngine;

public class UnitHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        Debug.Log(gameObject.name + " health: " + currentHealth);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        Debug.Log(gameObject.name + " took damage. Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    public float GetCurrentHealth()
    {
        return currentHealth;
    }
}