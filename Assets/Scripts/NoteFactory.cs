using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteFactory {

	public static NoteHolder noteHolder;

	public static Note PlayNote(int index, float length)
	{
		return PlayNote(index, length, 1, .5f, .5f);
	}

	public static Note PlayNote(int index, float length, float sine, float saw, float square)
	{
		Note note = ScriptableObject.CreateInstance<Note>();
		note.index = index;
		note.length = length;
		note.sinusAudioWaveIntensity = sine;
		note.sawAudioWaveIntensity = saw;
		note.squareAudioWaveIntensity = square;
		return note;
	}

}
