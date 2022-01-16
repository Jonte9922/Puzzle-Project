using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Trigger : MonoBehaviour
{

    public Renderer rend;
    public GameObject puzzle_piece;
    public Transform meeple;

    /*public struct Pieces {

        public Pieces (string Puzzle)
            {

            Piece = Puzzle;
        }

        public string Piece;
    }*/




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
    }

    
    void OnTriggerEnter(Collider other)
    {
        meeple = this.gameObject.transform.GetChild(0);
        //GameObject zone_1;
        //zone_1.GetComponent<Renderer>().enabled = false;

        if (other.tag == meeple.tag)  //Checks if the correct piece is in the correct spot and deletes the zone
        {
            print(meeple.tag);
            other.transform.parent = null;
            Destroy(gameObject);
        }
        else
        {
            print("Wrong Piece");
        }

    }
}
