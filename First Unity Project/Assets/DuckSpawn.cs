﻿using UnityEngine;
using System.Collections;

public class DuckSpawn : MonoBehaviour
{
	public GameObject duck;

	//void Start (){}
	
	//void Update (){}

	public void SpawnDuck()
	{
		Instantiate(duck, transform.position, Quaternion.identity);
	}
}