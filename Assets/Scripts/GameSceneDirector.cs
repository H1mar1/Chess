using UnityEngine;

public class GameSceneDirector : MonoBehaviour
{
    //ゲーム設定
    public const int TITLE_X = 8;
    public const int TITLE_Y = 8;
    const int PLAYER_MAX = 2;

    // タイルのプレハブ
    [SerializeField]
    private GameObject[] prefabTile;
    // カーソルプレハブ
    [SerializeField]
    private GameObject prefabCursor;

    //内部データ
    private GameObject[,] titles;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
