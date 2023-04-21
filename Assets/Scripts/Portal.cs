using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    public GameObject LevelComplete;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTrigger Triggered");
        if (other.gameObject.tag == "Player"){
            //open complete UI
            LevelComplete.SetActive(true);
            GameManager.instance.DisableInput();
            GameManager.instance.StopWaterLevel();
        }
    }
}
