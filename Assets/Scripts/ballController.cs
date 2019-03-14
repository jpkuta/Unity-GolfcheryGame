using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class ballController : MonoBehaviour
{
    private AudioSource holeAudio;
    // Start is called before the first frame update
    void Start()
    {
        holeAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "hole")
        {
          //  Scene currentScene = SceneManager.GetActiveScene();
          //  string sceneName = currentScene.name;

            setScores();
            // Destroy(gameObject);
            //Attempts to delay next scene load below; currently not working
            // Invoke("LoadNext", 2);
            holeAudio.Play();
            StartCoroutine(LoadScene());

          /*  if (sceneName == "hole1")
            {
                SceneManager.LoadScene("hole2");
            }
            if (sceneName == "hole2")
            {
                SceneManager.LoadScene("hole3");
            }
            if (sceneName == "hole3")
            {
                SceneManager.LoadScene("hole4");
            }
            if (sceneName == "hole4")
            {
                SceneManager.LoadScene("end");
            }*/
        }

        if(other.gameObject.tag == "arrow")
        {
            gameFlow.ballHits = gameFlow.ballHits + 1;
            gameFlow.ballMisses = gameFlow.ballMisses - 1;
            if (gameFlow.ballMisses < 0)
            {
                gameFlow.ballMisses = 0;
                gameFlow.currentScore += 20;
            }

        }
    }

   private void LoadNext()
    {
        Debug.Log("In Load Next");
        SceneManager.LoadScene("hole2");
    }

    IEnumerator LoadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        yield return new WaitForSeconds(3);
        Debug.Log("Wait is over");
        if (sceneName == "hole1")
        {
            SceneManager.LoadScene("hole2");
        }
        if (sceneName == "hole2")
        {
            SceneManager.LoadScene("hole3");
        }
        if (sceneName == "hole3")
        {
            SceneManager.LoadScene("hole4");
        }
        if (sceneName == "hole4")
        {
            SceneManager.LoadScene("end");
        }
    }

   private void setScores()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "hole1")
        {
            gameFlow.HoleOneScore = gameFlow.currentScore;
         if(gameFlow.currentStrokes <5)
            {
                gameFlow.HoleOneScore += 500;
            }
        }
        if (sceneName == "hole2")
        {
            gameFlow.HoleTwoScore = gameFlow.currentScore;
            if (gameFlow.currentStrokes < 7)
            {
                gameFlow.HoleTwoScore += 500;
            }
        }
        if (sceneName == "hole3")
        {
            gameFlow.HoleThreeScore = gameFlow.currentScore;
            if (gameFlow.currentStrokes < 9)
            {
                gameFlow.HoleThreeScore += 500;
            }
        }
        if (sceneName == "hole4")
        {
            gameFlow.HoleFourScore = gameFlow.currentScore;
            if (gameFlow.currentStrokes < 15)
            {
                gameFlow.HoleFourScore += 500;
            }
        }
        gameFlow.totalMisses += gameFlow.ballMisses;
        gameFlow.ballMisses = 0;
        gameFlow.totalStrokes += gameFlow.currentStrokes;
        gameFlow.currentStrokes = 0;
        gameFlow.currentScore = 1000;

    }


}
