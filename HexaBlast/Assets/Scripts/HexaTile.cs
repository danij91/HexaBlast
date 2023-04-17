using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Shapes;

public abstract class HexaTile : MonoBehaviour
{
    public TILE_STATE State { get; set; }
    public TILE_TYPE Type { get; set; }
    
    [SerializeField]
    private Button _btn;
    [SerializeField]
    private ShapeRenderer _polygon_bg;

    private void Awake()
    {
        Init();
    }

    protected virtual void Init()
    {
        _btn.onClick.AddListener(OnClickBtn);
    }

    private void OnClickBtn()
    {
        RevealTile();
    }

    private void RevealTile()
    {
        if (State == TILE_STATE.REVEALED)
        {
            return;
        }

        State = TILE_STATE.HIDDEN;
        ChangeTileShape();
        ShowInfo();
    }
    
    private void ChangeTileShape()
    {
        _polygon_bg.Color = Color.gray;
    }

    protected virtual void ShowInfo()
    {
        
    }
}
