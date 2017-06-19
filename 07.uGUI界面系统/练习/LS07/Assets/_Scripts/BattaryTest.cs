using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BattaryTest : MonoBehaviour {
    public Text BatteryText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Image>().fillAmount -= 0.05f * Time.deltaTime;
        if (gameObject.GetComponent<Image>().fillAmount < 0.01)
        {
            gameObject.GetComponent<Image>().fillAmount = 1f;
        }

        float d = gameObject.GetComponent<Image>().fillAmount * 100;
        BatteryText.GetComponent<Text>().text = d.ToString("f0") + "%";
	}
}
