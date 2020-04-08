using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class HandleTextFile {
	public static List<float[]> ReadString(string file) {
		// Debug.Log (Application.dataPath);
		file = Application.dataPath + '/' + file;
		// Debug.Log (file);

		// Read the text from directly from the test.txt file
		StreamReader filereader = new StreamReader(file);
		string filedata = filereader.ReadToEnd();

		List<float[]> pointList = new List<float[]>();
		char seperator = ',';
		using (StringReader reader = new StringReader(filedata)) {
			string line;
			while ((line = reader.ReadLine()) != null) {
				// Debug.Log(line);
				string[] pointtoken = line.Split(seperator);
				float x = Convert.ToSingle(pointtoken [0]);
				float y = Convert.ToSingle(pointtoken [1]);
				float z = Convert.ToSingle(pointtoken [2]);
				float[] point = new float[]{x, y, z};
				pointList.Add(point);
				// Debug.Log(pointtoken[0], pointtoken[1], pointtoken[2]);
			}

			reader.Close();
		}

		return pointList;
	}
}
