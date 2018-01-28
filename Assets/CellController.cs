using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellController : MonoBehaviour {

	public GameObject cellPrefab;
	[Range(10, 100)]
	public int size;

	private Cell[,] cells;

	// Use this for initialization
	void Start () {
		cells = new Cell[size,size];
		for(int x = -size / 2; x < size / 2; x++)
		{
			for (int z = 0; z < size; z++)
			{
				GameObject cell = Instantiate(cellPrefab, new Vector3(x, 0, z), cellPrefab.transform.rotation);
				cell.transform.parent = transform;
				cells[x + size / 2, z] = cell.GetComponent<Cell>();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
