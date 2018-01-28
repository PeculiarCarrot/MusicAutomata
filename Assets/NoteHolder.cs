using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHolder : MonoBehaviour {

	public List<Note> playingNotes = new List<Note>();

	public GameObject cosc;

	float timer;
	int index;

	float secondsPer = 1f;

	// Use this for initialization
	void Start () {
		NoteFactory.noteHolder = this;
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(Input.anyKeyDown)
		{
			index++;
			cosc.transform.localScale = new Vector3(2, 2, 2);
			AddNote(NoteFactory.PlayNote(Random.Range(0, 20), secondsPer));
		}
		playingNotes.RemoveAll(x => x.IsDead());
		foreach (Note note in playingNotes)
			note.Update();
	}

	public void AddNote(Note note)
	{
		playingNotes.Add(note);
		note.Awake();
		note.Start();
	}

	public void OnAudioFilterRead(float[] data, int channels){
		for(int i = 0; i < playingNotes.Count; i++)
			if(!playingNotes[i].IsDead())
				playingNotes[i].OnAudioFilterRead(data, channels);
	}
}
