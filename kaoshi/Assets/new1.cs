using UnityEngine;
using System.Collections;

public class new1 : MonoBehaviour {
	public new2 bInstance;
	public GameObject play1;
	// Use this for initialization
	void Start () {
		//Debug.Log( bInstance.gameObject.name);
		//bInstance.gameObject.GetComponent<Transform> ();
		//bInstance.gameObject.GetComponent<XScript> ();
		//bInstance.gameObject.transform.FindChild("XX");
		//Debug.Log(bInstance.gameObject.transform.parent.name);
		//bInstance.gameObject.transform.localPosition = new Vector3 (3,3,3);
		//bInstance.gameObject.SetActive (false);
		//GameObject obj=new GameObject("ZObject");
		//Destroy (bInstance.gameObject.GetComponent<new2>(),2);
		this.transform.Translate(Vector3.forward*3);
		Destroy (this.gameObject, 5);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
