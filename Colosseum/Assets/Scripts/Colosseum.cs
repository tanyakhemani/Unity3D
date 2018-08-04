using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colosseum : MonoBehaviour
{
	void Start()
	{
		for (int j = 0; j < 5; j++)
		{
			int segments = 80;
			float angle = 0;
			float angleStep = 360f / segments;

			float radius = (100f * segments) / 80f;

			for (int i = 0; i < segments; i++)
			{
				var arcdoor = CreateArcDoor();

				float angleRadX = Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
				float angleRadZ = Mathf.Sin(angle * Mathf.Deg2Rad) * radius;

				arcdoor.transform.position = new Vector3(angleRadX, j * 10, angleRadZ);
				arcdoor.transform.LookAt(new Vector3(0, j * 10, 0));
				angle += angleStep;
			}
		}
	}

	GameObject CreateArcDoor()
	{
		var ArcDoor = new GameObject("ArcDoor");

		int radius = 3;
		float height = 10;

		// calculate width arc door
		float width = radius * 2 + 2;


		// creating arc
		var arc = GenerateArc(radius, height);
		// change position of arc object
		arc.transform.position = new Vector3(0, arc.transform.position.y, 0);

		// creating walls
		var wallLeft = GameObject.CreatePrimitive(PrimitiveType.Cube);
		var wallRight = GameObject.CreatePrimitive(PrimitiveType.Cube);

		// scale cube
		wallLeft.transform.localScale = new Vector3(1, height, 1);
		wallRight.transform.localScale = new Vector3(1, height, 1);

		// change position of cube
		wallLeft.transform.position = new Vector3(-radius - 0.5f, height * 0.5f, 0.5f);
		wallRight.transform.position = new Vector3(radius + 0.5f, height * 0.5f, 0.5f);

		// 
		arc.transform.parent = ArcDoor.transform;
		wallLeft.transform.parent = ArcDoor.transform;
		wallRight.transform.parent = ArcDoor.transform;

		return ArcDoor;
	}

	GameObject GenerateArc(float radius, float height)
	{
		GameObject obj = new GameObject();
		MeshFilter meshFilter = obj.AddComponent(typeof(MeshFilter)) as MeshFilter;

		// for normal view with shadows and color
		MeshRenderer meshRenderer = obj.AddComponent(typeof(MeshRenderer)) as MeshRenderer;
		meshRenderer.material = new Material(Shader.Find("Standard"));
		//------------------------------------------

		Mesh mesh = new Mesh();
		List<Vector3> vertices = new List<Vector3>();
		List<int> quad = new List<int>();

		float angle = -90;

		// count of planes in arc
		// more segments, arc will be more smooth
		int segments = (int)radius * 2;

		float startX = 0;

		for (int i = 0; i < segments; i++)
		{
			float x = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
			float y = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;
			angle += (180f / segments);

			float x1 = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
			float y1 = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;

			// generate arc plane
			vertices.Add(new Vector3(x, y, 0));
			vertices.Add(new Vector3(x1, y1, 0));
			vertices.Add(new Vector3(x1, y1, 1));
			vertices.Add(new Vector3(x, y, 1));

			// generate front plane
			vertices.Add(new Vector3(x, y, 0));
			vertices.Add(new Vector3(x, radius + 1, 0));
			vertices.Add(new Vector3(x1, radius + 1, 0));
			vertices.Add(new Vector3(x1, y1, 0));

			// generate back plane
			vertices.Add(new Vector3(x1, y1, 1));
			vertices.Add(new Vector3(x1, radius + 1, 1));
			vertices.Add(new Vector3(x, radius + 1, 1));
			vertices.Add(new Vector3(x, y, 1));

			// remember first x
			if (i == 0)
			{
				startX = x;
			}

			// if last
			if (i == segments - 1)
			{
				// generate top plane
				vertices.Add(new Vector3(startX, radius + 1, 0));
				vertices.Add(new Vector3(startX, radius + 1, 1));
				vertices.Add(new Vector3(x1, radius + 1, 1));
				vertices.Add(new Vector3(x1, radius + 1, 0));
			}
		}


		for (int i = 0; i < vertices.Count; i++)
		{
			quad.Add(i);
		}

		mesh.vertices = vertices.ToArray();


		mesh.SetIndices(quad.ToArray(), MeshTopology.Quads, 0);


		mesh.RecalculateBounds(); // unity need it
		// normals are for lighting
		mesh.RecalculateNormals(); // unity need it

		// set generated mesh
		meshFilter.mesh = mesh;

		// configure position of arc
		obj.transform.position = new Vector3(0.5f + radius, height - (radius + 1), 0);

		return obj;
	}
}
