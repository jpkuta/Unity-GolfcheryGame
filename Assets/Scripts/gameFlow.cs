using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameFlow : MonoBehaviour
{

    public static float totalStrokes = 0;
    public static float totalMisses = 0;
    public static float currentStrokes = 0;
    public static float crossbowPower = 3000;
    public static float ballHits = 0;
    public static float ballMisses = 0;
    public static float HoleOneScore = 1000;
    public static float HoleTwoScore = 1000;
    public static float HoleThreeScore = 1000;
    public static float HoleFourScore = 1000;
    public static float currentScore = 1000;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ballMisses < 0)
        {
            ballMisses = 0;
        }

        if (crossbowPower < 0)
        {
            crossbowPower = 0;
        }
        if(crossbowPower > 10000)
        {
            crossbowPower = 10000;
        }
    }
}
