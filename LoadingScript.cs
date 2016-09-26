using UnityEngine;
using System.Collections;

//注释
//~~~~
public class LoadingScript : MonoBehaviour {
	//异步加载
	private AsyncOperation asy;
	public UIProgressBar progressB;
	// Use this for initialization
	void Start () {
		if (progressB) {
			progressB.value = 0;
		}
		StartCoroutine ("loadSence");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (asy.progress);
		//进度条加载到90%，跳转场景
		if (asy.progress < 0.9) {
			progressB.value = asy.progress;
		} else {
			progressB.value = 1;
		}
	}
	IEnumerator loadSence(){
		asy = Application.LoadLevelAsync ("sence1");
		Debug.Log (asy.progress);
		yield return 0;
	}
}
