using UnityEngine;

public class GameSceneDirector : MonoBehaviour
{
    //�Q�[���ݒ�
    public const int TITLE_X = 8;
    public const int TITLE_Y = 8;
    const int PLAYER_MAX = 2;

    // �^�C���̃v���n�u
    [SerializeField]
    private GameObject[] prefabTile;
    // �J�[�\���v���n�u
    [SerializeField]
    private GameObject prefabCursor;

    //�����f�[�^
    private GameObject[,] titles;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
