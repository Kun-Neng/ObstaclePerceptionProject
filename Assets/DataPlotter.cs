using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPlotter : MonoBehaviour {
	public string inputfile = "Assets/iris-2lg34dn.csv"; // "D:\\iris-2lg34dn.csv";
	public GameObject PointPrefab;

	// private List<Dictionary<string, object>> pointList;

	// Use this for initialization
	void Start () {
		// pointList = CSVReader.Read(inputfile);
		// Debug.Log(pointList);
		List<float[]> filedata = HandleTextFile.ReadString(inputfile);

		// Debug.Log(filedata);
		filedata.ForEach (delegate(float[] obj) {
			Instantiate (PointPrefab, new Vector3 (obj [0], obj [1], obj [2]), Quaternion.identity);
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
