using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statemachine : MonoBehaviour
{
    public gameManager gm;
    public enum gamestate {
        START,
        PLAYERTURN,
        AI,
        TILESELECT,
        ANSWERING,
        RESULT,
        END
    };
    public gamestate gstate; 
<<<<<<< HEAD
    // Start is called before the first frame update
    void Start()
    {
        
    }
=======
>>>>>>> parent of b190cad... Added Panels

    // Update is called once per frame
    void Update()
    {
        switch (gstate) {
            case gamestate.START:
<<<<<<< HEAD
                //decide who goes first
                //set up default values
                break;
            case gamestate.PLAYERTURN:
                //enable control functionallity to player 
              
                break;
            case gamestate.TILESELECT:
                // turn off drawing panel
                //turn on tile panel
               
                break;
            case gamestate.ANSWERING:
                // check for player hand writting input 
                // analize image file via google vision 
                // update ui feedback from google vision 
                // allow for backspace on input (in case hand writting was bad) 
                // check for "submit" button input

=======
                // wait for player to 
                // set up default values
                // go to waiting for answer

                break;
            case gamestate.WAITINGFORANSWER:
                // Enable control functionallity to player 
                // Let user select a tile, pop up answer drawing panel
                //(let user see question, check for player hand writting input 
                // analize image file via google vision update ui feedback from google vision
                // allow for backspace on input (in case hand writting was bad) 
                // check for "submit" button input before time runs out 
>>>>>>> parent of b190cad... Added Panels
                break;
            case gamestate.RESULT:
                // check if correct or incorrect 
                // update accordingly 
                break;
            case gamestate.END:
                //decide on what player is next
                break;
            case gamestate.AI:
                //decide on what player is next
                break;
        }
        
    }
}
