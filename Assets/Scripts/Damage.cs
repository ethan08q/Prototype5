using UnityEngine;

public class Damage : MonoBehaviour
{
    public int health = 1;
    Rigidbody rb;

    private void Start()
    {
        health = 1;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Add death logic here
        Destroy(gameObject);
    }
}
