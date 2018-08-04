using System.Collections;
using UnityEngine;

public class Pyramid : MonoBehaviour 
{

	// Use this for initialization
	void Start ()
	{
		int maxHeight = 10;

		for (int height = 0; height < maxHeight; height++) {
			int length = maxHeight - height;
			for (int x = -length; x <= length; x++) {
				for (int z = -length; z <= length; z++) {
					if (Mathf.Abs (x) == length || Mathf.Abs (z) == length) {
						//Color color = new Color (Random.Range (0.8f, 1f), Random.Range (0.4f, 0.6f), 0);
						//float size = Random.Range (1f, 1.3f);
						Tools.MakeCube (x, height, z);
					}

				}
			}
		}
	}
	
}