using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLiftSystem : MonoBehaviour
{
    private float timer = 10f;
    public float maxYPosition = 3f;
    public GameObject objectToMove;
    bool lift = false;
    // Start is called before the first frame update

    void Update()
    {
        if (lift) {
            LiftWaterLevel ();
        }
        
    }


    public void LiftWaterLevel () {
        if (timer > 0) {
            // Calculate the amount to move the object by based on the remaining time and maximum Y position
            float moveAmount = (maxYPosition / timer) * Time.deltaTime;

            // If the object's Y position would exceed the maximum, set it to the maximum
            if (objectToMove.transform.position.y + moveAmount > maxYPosition) {
                moveAmount = maxYPosition - objectToMove.transform.position.y;
            }

            // Move the object up by the calculated amount
            objectToMove.transform.position += new Vector3(0f, moveAmount, 0f);

            // Decrement the timer by Time.deltaTime
            timer -= Time.deltaTime;
        }
    }

    public void canLift () {
        lift = true;
    }

    public void cannotLift () {
        lift = false;
    }

    public void SetCurrentTime(float time){
        timer = time;
    } 
}
