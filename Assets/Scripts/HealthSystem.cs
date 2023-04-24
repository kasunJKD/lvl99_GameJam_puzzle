using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    Slider healthSlider;

    [SerializeField]
    float MaxHealth;

    [SerializeField]
    float damage;

    [SerializeField]
    float damageIntervalSeconds;

    //maybe remove the player with game over
    public static float currentHealth;

    public static bool isTakingDamage = false;


      Coroutine co;

    // Start is called before the first frame update
    private void Start()
    {
        currentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = currentHealth;
    }

    //call this in another script
    public void TakeDamage()
    {

        Debug.Log("TakeDamage");
            if (!isTakingDamage) // Only start taking damage if we're not already taking damage
            {
                isTakingDamage = true; // Set the flag to true

                co = StartCoroutine(ReduceHealthOverTime()); // Start the coroutine to reduce health over time
            }
        
        
    }

    private IEnumerator ReduceHealthOverTime()
    {
        Debug.Log("ReduceHealthOverTime");
            while (currentHealth > 0) // Keep reducing health until it reaches 0
        {
            currentHealth -= damage;

            yield return new WaitForSeconds(damageIntervalSeconds); // Wait for 2 seconds before reducing health again
        }

        isTakingDamage = false; // Set the flag to false when we're done taking damage
        
        
    }

    public void NoTakeDamage()
    {
        Debug.Log("NoTakeDamage");
        if (co != null){
            StopCoroutine(co);
        }     
    }
}

//after water transform go beyond player y transform
//take damage by second

//timer runs only till room filled with water
//after timer hold breath
