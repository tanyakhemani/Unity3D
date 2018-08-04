using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRectangularDoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		
	
	
	GameObject prefab = Resources.Load ("rectangle") as GameObject;



	//level 1
	for (int i = 0; i < 3; i++)                            //i= rectangles in x direction
	{
		for (int height = 0; height < 6; height++)        //height= rectangles in y direction
		{

			if (i != 1)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);

			}
			else if (i == 1 && height == 5)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}

		}

	}
	for (int i = 3; i < 6; i++)
	{
		for (int height = 0; height < 6; height++)
		{

			if (i != 4)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}
			else if (i == 4 && height == 5)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}

		}

	}
	for (int i = 6; i < 9; i++)
	{
		for (int height = 0; height < 6; height++)
		{

			if (i != 7)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}
			else if (i == 7 && height == 5)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}

		}

	}
	for (int i = 9; i < 12; i++)
	{
		for (int height = 0; height < 6; height++)
		{

			if (i != 10)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}
			else if (i == 10 && height == 5)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}

		}

	}
	//level 2///////////////////////////////////////////////
	for (int i = 0; i < 3; i++)
	{
		for (int height = 6; height < 11; height++)
		{

			if (i != 1)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}
			else if (i == 1 && height == 10)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}

		}

	}
	for (int i = 3; i < 6; i++)
	{
		for (int height = 6; height < 11; height++)
		{

			if (i != 4)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}
			else if (i == 4 && height == 10)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}

		}

	}
	for (int i = 6; i < 9; i++)
	{
		for (int height = 6; height < 11; height++)
		{

			if (i != 7)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}
			else if (i == 7 && height == 10)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}

		}

	}
	for (int i = 9; i < 12; i++)
	{
		for (int height = 6; height < 11; height++)
		{

			if (i != 10)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}
			else if (i == 10 && height == 10)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}

		}

	}
	//level 3///////////////////////////////////////////////
	for (int i = 0; i < 3; i++)
	{
		for (int height = 11; height < 16; height++)
		{

			if (i != 1)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}
			else if (i == 1 && height == 15)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}

		}

	}
	for (int i = 3; i < 6; i++)
	{
		for (int height = 11; height < 16; height++)
		{

			if (i != 4)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}
			else if (i == 4 && height == 15)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}

		}

	}
	for (int i = 6; i < 9; i++)
	{
		for (int height = 11; height < 16; height++)
		{

			if (i != 7)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}
			else if (i == 7 && height == 15)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}

		}

	}
	for (int i = 9; i < 12; i++)
	{
		for (int height = 11; height < 16; height++)
		{

			if (i != 10)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}
			else if (i == 10 && height == 15)
			{
					GameObject rectangle = Instantiate(prefab) as GameObject;
					rectangle.transform.position = new Vector3(transform.position.x + i * 5, transform.position.y + height * 2, transform.position.z);
			}

		}

	}
}
}



