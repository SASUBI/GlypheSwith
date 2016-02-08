using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	public static int Score;

	// The player's score.
	
	
	Text text;                      // Reference to the Text component.
	
	
	void Start ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();		
		//reset score
		Score = 0;
	}

	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Score: " + Score;
	}
}