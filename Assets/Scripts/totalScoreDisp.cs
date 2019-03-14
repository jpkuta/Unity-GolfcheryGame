using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalScoreDisp : MonoBehaviour
{
    float total = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        total = gameFlow.HoleOneScore + gameFlow.HoleTwoScore + gameFlow.HoleThreeScore + gameFlow.HoleFourScore;
        GetComponent<Text>().text = " " + total;
    }
}
