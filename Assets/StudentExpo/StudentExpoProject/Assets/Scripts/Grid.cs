using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Grid : MonoBehaviour {
    public enum PieceType
    {
        NORMAL,
        COUNT,
    }
    [System.Serializable]

    public struct PiecePrefab
    {
        public PieceType type;
        public GameObject prefab;
    }

    public int xDim;
    public int yDim;

    public PiecePrefab[] piecePrefabs;

    private Dictionary< PieceType, GameObject> piecePrefabDict;


    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
