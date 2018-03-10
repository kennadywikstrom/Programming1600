using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberGuesser : MonoBehaviour {

	public Text textBox;

	private int max = 100;
	private int min = 1;
	private int guess;

	public int counter;
	private int counterSave;


	// Use this for initialization
	void Start () 
	{
		counterSave = counter;
		guess = Random.Range (min, max);


		textBox.text = "Welcome to Number Guesser "
					+ "\nPick a number in your head"
					+ "\n\nThe highest number you can pick is " + max
					+ "\nThe lowest number you can pick is " + min
					+ "\n\nIs the number higher or lower than " + guess
					+ "\n Up arrow for higher, Down for lower, Enter for equal";



		print ("Welcome to Number Guesser");
		print ("Pick a number in your head");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess);
		print ("Up arrow for higher, Down for lower, Enter for equal");
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			max = 100;
			min = 1;
			counter = counterSave;
			Start();
		}


		if (counter == -1) {

			if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) {
				//counter--;
				print ("You win!");
				textBox.text = "<color=#00ff00ff>You win!</color>" +
								"\nPress R to Reset";
			}

		}
		else if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			guess = (max + min) / 2;
			counter--;
			print ("Is the number higher or lower than " + guess);
			textBox.text = "Is the number higher or lower than " + guess
				+ "\n" + counter + " guesses remaining";
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			max = guess;
			guess = (max + min) / 2;
			counter--;
			print ("Is the number higher or lower than " + guess);
			textBox.text = "Is the number higher or lower than " + guess
				+ "\n" + counter + " guesses remaining";
		}
		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			print ("Computer wins");
			textBox.text = "<color=red>Computer wins!</color>"
				+ "\n with " + (counter < 0 ? "0" : counter.ToString()) + " guesses remaining"
				+ "\nPress R to Reset";
		}

		if (counter == 0) 
		{
			counter--;
		}
	}
}