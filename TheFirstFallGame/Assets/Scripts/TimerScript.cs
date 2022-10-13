using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerScript : MonoBehaviour
{

    public int timeCount = 60;
    private WaitForSeconds wfsObj;
    
    public UnityEvent startEvent, counterStart, counterEnd, repeatCount;
    public bool canRun;
    
    public IntData counterNum;
    
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
        
    }
    
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

}
