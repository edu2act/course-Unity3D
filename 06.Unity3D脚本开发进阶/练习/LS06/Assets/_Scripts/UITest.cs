using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UITest : MonoBehaviour {
    public float hSliderValue;
    public int count;
	// Use this for initialization
	void Start () {
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {
        count++;
	}

    void OnGUI()
    {
        GUIStyle style = new GUIStyle();  
        style.normal.textColor = Color.red;// new Color(1, 0, 0);//设置字体颜色的  
        style.fontSize = 20; //字体大小
        style.alignment = TextAnchor.MiddleCenter;

        
        //Label标签
        GUI.Label(new Rect((Screen.width - 90), 55, 80, 40),count.ToString(),style);

        //按钮
        if (GUI.Button(new Rect(10, 10, 80, 40), "场景切换"))
        {
            Debug.Log("左侧按钮111");
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            //obj.transform.position = new Vector3(Random.value, 0, 0);
            obj.transform.position = Random.insideUnitSphere;

            SceneManager.LoadScene("Demo01");

        }
        if (GUI.RepeatButton(new Rect(10, 55, 80, 40), "重复按钮"))
        {
            Debug.Log("重复按钮");
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            //obj.transform.position = new Vector3(Random.value, 0, 0);
            //obj.transform.position = Random.insideUnitSphere*10;
            obj.transform.position = Random.onUnitSphere * 10;

            //Vector2 circle = Random.insideUnitCircle*10;
            //obj.transform.position = new Vector3(circle.x, circle.y, 0);
            
        }
        if (GUI.RepeatButton(new Rect(Screen.width - 90, 10, 80, 40), "右侧按钮"))
        {
            Debug.Log("右侧按钮222");
            //获得组件，并更改属性
        }
        //滑动条
        hSliderValue = GUI.HorizontalSlider(new Rect(10, 100, 80, 40), hSliderValue, 0.0F, 10.0F);
        
        
        /*
        // Automatic Layout 自动布局
        if (GUILayout.Button("I am an Automatic Layout Button")) { Debug.Log("btn1 Pressed"); }
        if (GUILayout.Button("I am ton")) { Debug.Log("btn2 Pressed"); }
        if (GUILayout.Button("I am an Button")) { Debug.Log("btn3 Pressed"); }
        if (GUILayout.Button("I am")) { Debug.Log("btn4 Pressed"); }

        hSliderValue = GUILayout.HorizontalSlider(hSliderValue, 0.0F, 1.0F);
        GUILayout.Label("This text makes just space xxxxxxxxxxxxx", style);
        GUILayout.Label(hSliderValue.ToString(), style);
         */
    }
}
