using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzelScript : MonoBehaviour
{
    public List<GameObject> Pieces = new List<GameObject>();
    public List<Vector3> StartPos = new List<Vector3>();
    public List<Quaternion> rot = new List<Quaternion>();

    void Start()
    {
 
        AddPieceInformation();
    }

    void Update()
    {
    }

    public void AddPieceInformation()
    {
        Transform[] Children = GetComponentsInChildren<Transform>();
        foreach (Transform child in Children)
        {
            
            Pieces.Add(child.gameObject);
            StartPos.Add(child.transform.position);
            rot.Add(child.transform.rotation);
        }
    }

    public void ChangePos(GameObject PieceName)
    {
        int Nr = Pieces.IndexOf(PieceName);

        Pieces[Nr].transform.position = StartPos[Nr];
        Pieces[Nr].transform.rotation = rot[Nr];
    }
}
