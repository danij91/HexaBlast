using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private Tilemap _tilemap;
    [SerializeField] private RuleTile _mineTile;
    [SerializeField] private HexaTile _numTile;

    void Start()
    {
        GenerateMap();
    }

    private void GenerateMap()
    {
        int maxHalfWidth = GetWidthByDisplay();
        int maxHalfHeight = GetHeightByDisplay();
        for (var i = -maxHalfWidth; i < maxHalfWidth; i++)
        {
            for (var j = -maxHalfHeight; j < maxHalfHeight; j++)
            {
                _tilemap.SetTile(new Vector3Int(i, j, 0), _mineTile);
            }
        }

        _tilemap.RefreshAllTiles();
        Debug.Log("---");
    }

    private int GetWidthByDisplay()
    {
        return 10;
    }

    private int GetHeightByDisplay()
    {
        return 5;
    }
}