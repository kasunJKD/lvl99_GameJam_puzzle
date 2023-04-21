using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public int countdownTime;
    public Text countDownDisplay;
    bool countdownover;

    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while(countdownTime > 0)
        {
            GameManager.instance.DisableInput();
            countDownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countDownDisplay.text = "GO!";

        GameManager.instance.EnableInput();
        GameManager.instance.LiftWaterLevel();

        yield return new WaitForSeconds(1f);

        countDownDisplay.gameObject.SetActive(false);

    }

}
