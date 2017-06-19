using UnityEngine;
using System.Collections;

public class CoroutineTest2 : MonoBehaviour {
	void Start () {
		StartCoroutine ("Sweep");//或StartCoroutine (Sweep());
		StartCoroutine (Mop());
	}
	IEnumerator Sweep(){
		Debug.Log ("开始扫--地");
		int sweepCount = 1;
		while(sweepCount<=5){
			Debug.Log ("扫--了第"+sweepCount+"次");
			sweepCount ++;
			yield return new WaitForSeconds (2);//yield return null;
		}
		Debug.Log ("扫--地完成");
	}
	IEnumerator Mop(){
		Debug.Log ("开始拖++地");
		int sweepCount = 1;
		while(sweepCount<=5){
			Debug.Log ("拖++了第"+sweepCount+"次");
			sweepCount ++;
			yield return new WaitForSeconds (2);//yield return null;
		}
		Debug.Log ("拖++地完成");
	}
}
