using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPlotter : MonoBehaviour {
	// public string inputfile = "D:\\iris-2lg34dn.csv";
	public string inputfile = "iris-2lg34dn.csv";
	public GameObject PointPrefab;
	private float plotScale = 5;

	// private List<Dictionary<string, object>> pointList;

	// Use this for initialization
	void Start () {
		// pointList = CSVReader.Read(inputfile);
		// Debug.Log(pointList);
		List<float[]> filedata = HandleTextFile.ReadString(inputfile);

		// Debug.Log(filedata);
		filedata.ForEach (delegate(float[] obj) {
			GameObject dataPoint = Instantiate (PointPrefab, new Vector3 (obj [0], obj [1], obj [2]) * plotScale, Quaternion.identity);
			dataPoint.GetComponent<Renderer>().material.color = new Color(obj [0], obj [1], obj [2], 1.0f);
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
