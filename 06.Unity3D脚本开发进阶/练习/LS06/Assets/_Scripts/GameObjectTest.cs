using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameObjectTest : MonoBehaviour {
    public GameObject prefab;
    public GameObject cube;
	void Start () {
        //GameObject obj1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //obj1.transform.position = new Vector3(1, 1, 1);
        /*
        for (int i = 0; i < 5; i++)
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            obj.transform.position = new Vector3(i, i, i);
        }
        
        for (int i = -10; i < 10; i++)
        {
            GameObject obj2 = Instantiate(prefab);
            obj2.transform.position = new Vector3(i * 1.5f, 0, i * 1.5f);
            if (i % 2 == 0){
                Destroy(obj2);
            }
        }
        */
        //cube.SetActive(false);
        GameObject cube = GameObject.Find("Cube");
        //cube.SetActive(false);
        cube.transform.Translate(new Vector3(2, 0, 0));
        cube.GetComponent<MeshRenderer>().material.color = Color.red;

        Transform t = GetComponent<Transform>();
        gameObject.isStatic = false;





	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 55, 80, 40), "场景切换"))
        {
            SceneManager.LoadScene("Demo02");
        }
    }
}
