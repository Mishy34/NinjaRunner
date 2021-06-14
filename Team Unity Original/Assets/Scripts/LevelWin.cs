using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelWin : MonoBehaviour
{
    public Text finalScore;
    
    public void updateScore(int scr){

        finalScore.text = scr.ToString();
    }
    public void LoadMainMenu(){

        SceneManager.LoadScene("GameMenu");
    }
    
}
