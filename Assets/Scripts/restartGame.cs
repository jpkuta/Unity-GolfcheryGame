using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    public void restartGam()
    {
        gameFlow.totalStrokes = 0;
        gameFlow.totalMisses = 0;
        gameFlow.currentStrokes = 0;
        gameFlow.ballMisses = 0;
        gameFlow.currentScore = 1000;
        gameFlow.ballHits = 0;
        gameFlow.ballMisses = 0;
        gameFlow.HoleOneScore = 1000;
        gameFlow.HoleTwoScore = 1000;
        gameFlow.HoleThreeScore = 1000;
        gameFlow.HoleFourScore = 1000;
    SceneManager.LoadScene("hole1");

    }


}
