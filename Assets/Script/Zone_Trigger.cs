using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Trigger : MonoBehaviour
{
    public Renderer rend;
    public GameObject puzzle_piece;
    public GameObject pie;
    PuzzelScript puzzelScript;



    // Start is called before the first frame update
    void Start()
    {
        /*rend = GetComponent<Renderer>();
        rend.enabled = false;   //Turns the visibility of the object off



        puzzle_piece = GameObject.Find("Puzzle_0");  //Returns the gameobject in the scene
        */
    }

    // Update is called once per frame
    void Update()
    {
        puzzelScript = pie.GetComponent<PuzzelScript>();
    }

    
    void OnTriggerEnter(Collider other)
    {
        string PieceName;
        if (other.tag == gameObject.tag)  //Checks if the correct piece is in the correct spot and deletes the zone
        {
            print(gameObject.tag + ", Right piece");
            Destroy(gameObject);
        }
        else
        {
            
            print("Wrong Piece");
            puzzelScript.ChangePos(other.gameObject);
        }

    }
}
