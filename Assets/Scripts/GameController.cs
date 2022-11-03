using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    bool gameEnded = false;
    [SerializeField] GameObject timeDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded && timeDisplay.active == false)
        {
            print("Finished");
            timeDisplay.SetActive(true);
            timeDisplay.GetComponent<Text>().text = "Your score: " + ((int)Time.timeSinceLevelLoad).ToString();
        }
    }
    public void endGame()
    {
        gameEnded = true;
    }
}
