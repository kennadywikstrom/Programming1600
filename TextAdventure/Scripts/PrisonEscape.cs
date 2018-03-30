using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PrisonEscape : MonoBehaviour
{

    public Text textObject;
    public Text titleObject;

    private enum States
    {
        cell, dishes, toilet, hallway, airvent, hallway_1, linencloset, keycard, backcell, celldoor, gate, parkinglot
    };
    private States myState;

    // Use this for initialization
    void Start()
    { myState = States.cell; }

    // Update is called once per frame
    void Update()
    {
        print(myState);
        if (myState == States.cell) { cell(); }
        else if (myState == States.toilet) { toilet(); }
        else if (myState == States.hallway) { hallway_0(); }
        else if (myState == States.dishes) { dishes(); }
        else if (myState == States.airvent) { airvent(); }
        else if (myState == States.hallway_1) { hallway_1(); }
        else if (myState == States.linencloset) { linencloset(); }
        else if (myState == States.keycard) { keycard(); }
        else if (myState == States.celldoor) { celldoor(); }
        else if (myState == States.gate) { gate(); }
        else if (myState == States.parkinglot) { parkinglot(); }
        else if (myState == States.backcell) { backcell(); }


    }

    void cell()
    {
        titleObject.text = ("Cell");
        textObject.text = "You are in a cell. \n" +
                    "The food here is terrible. \n" +
                    "I got to get out of here. \n\n" +
                    "Press B to go to Toilet. \n\n" +
                    "Press L to go to Dishes. \n\n";
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.toilet; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.dishes; }

    }

    void toilet()
    {
        titleObject.text = ("Toilet");
        textObject.text = "Why is there a hole under this toilet? \n" +
        "I'll move the toilet, go down the hole and see where it leads to. \n" +
        "Jump into the hole and it will take you down to the second level of the prison. \n\n" +
        "Press H to go down the Toilet. \n\n" +
        "Press C to go back to Cell. \n\n";
        if (Input.GetKeyDown(KeyCode.C)) { myState = States.cell; }
        else if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway; }
    }

    void dishes()
    {
        titleObject.text = ("Dishes");
        textObject.text = "Here is some old lunch. \n" +
                      "I'll use the utensils to pick the lock. \n\n" +
                      "Press D to pick up the Utensils. \n\n" +
                      "Press C to go to Cell. \n\n";
        if (Input.GetKeyDown(KeyCode.D)) { myState = States.celldoor; }
        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.cell; }
    }

    void hallway_0()
    {
        titleObject.text = ("Hallway");
        textObject.text = "I'm now on the second floor in the prison." +
                     "\nOh no! There are guards.\n" +
                     "There's an airvent. \n\n" +
                     "Press A to go into the Airvent. \n\n" +
                     "Press C to go back to Cell. \n\n";
        if (Input.GetKeyDown(KeyCode.C)) { myState = States.cell; }
        else if (Input.GetKeyDown(KeyCode.A)) { myState = States.airvent; }
    }


    void celldoor()
    {
        titleObject.text = ("Cell Door");
        textObject.text = "I need to pick the lock to the Cell Door. \n\n" +
                    "Press H to pick the lock and go through the Cell Door. \n\n" +
                    "Press C to go back to Cell. \n\n";
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.hallway; }
        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.cell; }
    }

    void airvent()
    {
        titleObject.text = ("Airvent");
        textObject.text = "Which way should I go? \n\n" +
                    "Press R to go to the Right. \n\n"+
                    "Press X to the Left. \n\n";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.hallway_1; }
        else if (Input.GetKeyDown(KeyCode.X)) { myState = States.backcell; }
    }

    void backcell()
    {
        titleObject.text = ("Back in Cell");
        textObject.text = "You took the wrong turn. \n" +
                    "You are back in the cell. \n" +
                    "I got to get out of here. \n\n" +
                    "Press B to go to Toilet. \n\n" +
                    "Press L to go to Dishes. \n\n";
        if (Input.GetKeyDown(KeyCode.B)) { myState = States.toilet; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.dishes; }

    }

    void hallway_1()
    {
        titleObject.text = ("2nd Hallway");
        textObject.text = "There is a Linen Closet I should check it out.\n\n" +
                    "Press S to go to Linen Closet. \n\n";
        if (Input.GetKeyDown(KeyCode.S)) { myState = States.linencloset; }
    }

    void linencloset()
    {
        titleObject.text = ("Linen Closet");
        textObject.text = "There are some extra guard uniforms. \n" +
            "Perfect! Now I can disguise as one. Put on one of the extra guard's uniforms. \n\n" +
            "Press K to go into the Linen Closet and put on the guards clothes. \n\n" +
            "Press R to go back to Hallway. \n\n";
        if (Input.GetKeyDown(KeyCode.K)) { myState = States.keycard; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.hallway_1; }
    }

    void keycard()
    {
        titleObject.text = ("Key Card");
        textObject.text = "Great! This is exactly what I need to unlock the security door. \n" +
            "Once you find the Key Card, use it to unlock the security door. \n\n" +
            "Press G to go to the Gate. \n\n" +
            "Press S to go back to Linen Closet. \n\n";
        if (Input.GetKeyDown(KeyCode.G)) { myState = States.gate; }
        else if (Input.GetKeyDown(KeyCode.S)) { myState = States.linencloset; }

    }

    void gate()
    {
        titleObject.text = ("Gate");
        textObject.text = "Finally! I'm almost out. \n" +
            "Use the key card to unlock the security door and go to the Parking Lot. \n\n" +
            "Press P to go through the Gate. \n\n" +
            "Press S to go back to Linen Closet. \n\n";
        if (Input.GetKeyDown(KeyCode.P)) { myState = States.parkinglot; }
        if (Input.GetKeyDown(KeyCode.S)) { myState = States.linencloset; }

    }
    void parkinglot()
    {
        titleObject.text = ("Parking Lot");
        textObject.text = "Yes! I'm out and I ain't never going back. \n" +
            "Congratulations now that you have stolen the car and now you have escaped. \n\n" +
            "Press P to Play again. \n\n" +
            "Press E to exit the game. \n\n";
        if (Input.GetKeyDown(KeyCode.P)) { myState = States.cell; }
        else if (Input.GetKeyDown(KeyCode.E)) { Application.Quit(); }
    }
}
