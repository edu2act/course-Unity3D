using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerPrefsTest : MonoBehaviour {
    public Text currentText;
    public Text bestText;

    public int currentScore;

	// Use this for initialization
	void Start () {
        //currentText.GetComponent<Text>().text = "Current Score:"+10;
        //bestText.GetComponent<Text>().text = "Best Score:"+20;
        //PlayerPrefs.DeleteAll();
        if (!PlayerPrefs.HasKey("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", currentScore);
        }
        if (currentScore > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", currentScore);
        }
        int bestScore = PlayerPrefs.GetInt("BestScore");
        currentText.GetComponent<Text>().text = "Current Score:"+currentScore;
        bestText.GetComponent<Text>().text = "Best Score:"+bestScore;
        
	}
    public void DeleteAllKey()
    {
        PlayerPrefs.DeleteAll();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
