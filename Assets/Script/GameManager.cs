using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public BlockControl[] block;
    public GameObject gameoverUI;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DestroyAllBlocks()) 
        {
            // GameClear
            Debug.Log("ゲームくりあ！！");
        }
    }

    // blockが全て消失したら
    private bool DestroyAllBlocks()
    {
        foreach(BlockControl b in block) 
        {
            if( b != null) 
            {
                return false;
            }
        }
        return true;
    }


    // ゲームオーバー
    public void GameOver() 
    {
        Debug.Log("ゲームオーバー");
        gameoverUI.SetActive(true);
    }

    public void GameRetry()
    {
        SceneManager.LoadScene("Game");
    }
}
