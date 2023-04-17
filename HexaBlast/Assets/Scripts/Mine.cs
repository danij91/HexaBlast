using Shapes;
using UnityEngine;

public class Mine : HexaTile
{
    [SerializeField]
    private ShapeRenderer _img_mine;
    
    protected override void Init()
    {
        base.Init();
        Type = TILE_TYPE.MINE;
    }
    
    protected override void ShowInfo()
    {
        _img_mine.gameObject.SetActive(true);
    }
}