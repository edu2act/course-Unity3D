using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ToggleTest : MonoBehaviour {
    public Toggle toggle;
	// Use this for initialization
	void Start () {
        if (!PlayerPrefs.HasKey("Music"))
        {
            PlayerPrefs.SetString("Music", "On");
        }
        if ("On" == PlayerPrefs.GetString("Music"))
        {
            toggle.GetComponent<Toggle>().isOn = true;//按钮状态应该为开
        }
        else
        {

            toggle.GetComponent<Toggle>().isOn = false;//按钮状态应该为关
        }
	}

    public void TogglePressed()
    {
        if (toggle.GetComponent<Toggle>().isOn)
        {
            PlayerPrefs.SetString("Music", "On");
        }
        else
        {
            PlayerPrefs.SetString("Music", "Off");
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
