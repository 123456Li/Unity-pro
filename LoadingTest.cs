using UnityEngine;
using System.Collections;

//注释2
//*****
//@@@@@
public class LoadingTest : MonoBehaviour {
	public UIProgressBar pr;


	// Use this for initialization
	void Start () {
		StartCoroutine (StartLoding_4());
	}

	private IEnumerator StartLoading_1(){
		AsyncOperation op = Application.LoadLevelAsync ("sence1");
		while (!op.isDone) {
			SetLoadingPercentage (op.progress * 100);
			yield return new WaitForEndOfFrame ();
		}
	}
	private IEnumerator StartLoading_2(){
		AsyncOperation op = Application.LoadLevelAsync ("sence1");
		op.allowSceneActivation = false;
		while (!op.isDone) {
			SetLoadingPercentage (op.progress * 100);
			yield return new WaitForEndOfFrame ();
		}
		op.allowSceneActivation = true;
	 }
	void SetLoadingPercentage(float value){
		pr.value = value / 100;
	}

	private IEnumerator StartLoading_3(){
		AsyncOperation op = Application.LoadLevelAsync ("sence1");
		op.allowSceneActivation = false;
		while (op.progress<0.9) {
			SetLoadingPercentage (op.progress * 100);
			yield return new WaitForEndOfFrame ();
		}
		SetLoadingPercentage (100);
		yield return  new WaitForEndOfFrame ();
		op.allowSceneActivation = true;
	}

	private IEnumerator StartLoding_4(){

		int displayProgerss = 0;
		int toProgerss = 0;
		AsyncOperation op = Application.LoadLevelAsync ("sence1");
		op.allowSceneActivation = false;
		//进度条显示百分号加载到90%
		while (op.progress <0.9) {
			toProgerss = (int)op.progress * 100;
			while (displayProgerss <toProgerss) {
				++displayProgerss;
				SetLoadingPercentage (displayProgerss);
				yield return new WaitForEndOfFrame ();//等待每帧渲染完成
			}
		}
		toProgerss = 100;//给toProgerss赋值100，直接从90%加载到100%
		while (displayProgerss <toProgerss) {
			++displayProgerss;
			SetLoadingPercentage (displayProgerss);
			yield return new WaitForEndOfFrame ();
		}
		op.allowSceneActivation = true;

	}
}
