using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private WaterLiftSystem waterLiftSystem;
    private StopWatch stopWatch;
    private HealthSystem healthSystem;
    private MovementSystem movementsys;

    public float currentTime;

    private void Awake() 
    {
        if (instance == null) {
            instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }

        waterLiftSystem = gameObject.GetComponent<WaterLiftSystem>();
        stopWatch = gameObject.GetComponent<StopWatch>();
        healthSystem = gameObject.GetComponent<HealthSystem>();
        movementsys = gameObject.GetComponent<MovementSystem>();
    }
    
    public void Start()
    {
        stopWatch.SetCurrentTime(currentTime);
        waterLiftSystem.SetCurrentTime(currentTime);
    }

    public void LiftWaterLevel () {
        startStopWatch();
        waterLiftSystem.canLift();
    }

    public void startStopWatch () {
        stopWatch.canStartWatch();
    }

    public void takeDamage() {
        healthSystem.TakeDamage();
    }

    public void DisableInput() {
        movementsys.DisableInput();
    }

    public void EnableInput() {
        movementsys.EnableInput();
    }

    public void StopWaterLevel () {
        stopWatch.stopStopWatch();
        waterLiftSystem.cannotLift();
    }
}
