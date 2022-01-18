using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzelScript : MonoBehaviour
{
    public List<GameObject> Pieces = new List<GameObject>();
    public List<Vector3> StartPos = new List<Vector3>();

    void Start()
    {
 
        AddPieces();
        AddStartPos();
    }

    public void AddPieces()
    {
        Transform[] Children = GetComponentsInChildren<Transform>();
        foreach (Transform child in Children)
        {
            
            Pieces.Add(child.gameObject);
        }
    }
    public void AddStartPos()
    {
        Transform[] Children = GetComponentsInChildren<Transform>();
        foreach (Transform child in Children)
        {
            
            StartPos.Add(child.transform.position);
        }
    }
}
