using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Number : HexaTile
{
    private int _nearMineSum;
    
    [SerializeField]
    private TMP_Text _txt;

    protected override void Init()
    {
        base.Init();
        Type = TILE_TYPE.NUMBER;
        CalculateNearMine();
    }

    private void CalculateNearMine()
    {
        _nearMineSum = Random.Range(0, 10);
    }

    protected override void ShowInfo()
    {
        _txt.text = _nearMineSum.ToString();
    }
}