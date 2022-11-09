using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerScript : MonoBehaviour
{
    public IntData counterNum;
    public int timeCount = 60;
    private WaitForSeconds wfsObj;
    
    public UnityEvent startEvent, counterStart, counterEnd, repeatCount, repeatUntilFalse;
    public bool canRun;
    
    
    public bool CanRun
    {
        get => canRun;
        set => canRun = value;
    }
    // Start is called before the first frame update
    void Start()
    {
        startEvent.Invoke();
        wfsObj = new WaitForSeconds(timeCount);
        InvokeRepeating("Subtract", 1, 1);
        
    }
    // ref my shield behaviour script here and make it countdown for it to turn off also using == true but we have all the code
    
    public void StartCounting()
    {
        StartCoroutine(RepeatCount());
    }

    private IEnumerator RepeatCount()
    {
        startEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0)
        {  
            
            repeatCount.Invoke();
            counterNum.value--;
            yield return wfsObj;
            
        }
        counterEnd.Invoke();
   }
    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfsObj;
            repeatUntilFalse.Invoke();
        }
    }

    void Subtract()
    {
        timeCount -= 1;
    }

    private IEnumerator ShieldCountDown()
    {
        yield return wfsObj;
    }

}
