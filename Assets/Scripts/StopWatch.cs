using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StopWatch : MonoBehaviour
{

    public TextMeshProUGUI timerText;

    private float currentTime;
    public bool countDown;

    public bool hasLimit;
    public float timerLimit;
    bool canstart = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canstart) {
            startStopWatch ();
        }

        if(currentTime <= timerLimit) {
            Debug.Log("hit");
            GameManager.instance.takeDamage();
        }
        
    }

    private void SetTimeText(){
        timerText.text = currentTime.ToString("0.0");
    }

    public void SetCurrentTime(float time){
        currentTime = time;
    }

    public void canStartWatch () {
        canstart = true;
    }

    public void startStopWatch() {
        Debug.Log(currentTime + " stopwatch time");
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        if (hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
        {
            currentTime = timerLimit;
            SetTimeText();
            enabled = false;
        }

        SetTimeText();
    }
}
