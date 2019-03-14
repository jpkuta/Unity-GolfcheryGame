using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class targetTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "arrow")
        {
            gameFlow.totalStrokes = 0;
            gameFlow.totalMisses = 0;
            gameFlow.currentStrokes = 0;
            gameFlow.ballMisses = 0;
            gameFlow.currentScore = 1000;


        SceneManager.LoadScene("hole1");


        }
    }
}
