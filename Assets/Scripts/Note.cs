using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : ProceduralAudioController {

	private const double baseFrequency = 110;

	public int index;
	public float length;

	float timePlayed;

	private bool dead;

	public void Start()
	{
		mainFrequency = baseFrequency * System.Math.Pow((System.Math.Pow(2, 1.0 / 12)), index);
	}

	public void Update()
	{
		timePlayed += Time.deltaTime;
		if (timePlayed > length - .1f)
		{
			volume = 0;
		}
		if (timePlayed > length)
		{
			volume = 0;
			dead = true;
		}
		base.Update();
	}

	public bool IsDead()
	{
		return dead;
	}
}
