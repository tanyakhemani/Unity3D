using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour {

		void Start()
		{
			// height of structure or count of cube in the structure
			int height = 40;

			// scale
			float minScale = 6;
			float maxScale = 16;
			float deltaScale = (maxScale - minScale) / (height / 2f);
			//----------------------------------------------------------------

			// rotate
			float minRotate = 30;
			float maxRotate = 90;
			float deltaRotate = (maxRotate - minRotate) / height;
			//----------------------------------------------------------------

			// create grid of figure
			for (int i = 0; i < 10; i++) // row
			{
				for (int j = 0; j < 10; j++) // column
				{
					Figure(i * maxScale, j * maxScale, height, minScale, deltaScale, minRotate, deltaRotate);
				}
			}
			//----------------------------------------------------------------
		}

		void Figure(float posX, float posZ,int height, float minScale, float deltaScale, float minRotate, float deltaRotate)
		{
		int p = 0;
		for (int q = 0; q <= height; q++)
			{
				// create new cube
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

				//change position of cube
				cube.transform.position = new Vector3(posX, q, posZ);

				// scale the cube
				float scale = minScale + deltaScale * p;
				cube.transform.localScale = new Vector3(scale, 1, scale);
				//----------------------------------------------------------------

				// rotate the cube
				float rotate = minRotate + deltaRotate * q;
				cube.transform.Rotate(new Vector3(0, rotate, 0));
				//----------------------------------------------------------------

				if (q >= height / 2f) // scaling the second half of the cubes
					p++;
			}
		}
	}
