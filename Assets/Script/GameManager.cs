using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public BlockControl[] block;
    public GameObject gameoverUI;    
    public GameObject gamecelarUI;
    public GameObject gamestartUI;
    public BallControl ballControl;
    public GameObject ball;
    // public TimeTimer time;
    public GameObject timeUI;
    private bool isGameClear = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballControl = ball.GetComponent<BallControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameClear != true)
        {
            if(DestroyAllBlocks()) 
            {
                // GameClear
                Debug.Log("ゲームくりあ！！");
                gamecelarUI.SetActive(true);
                isGameClear = true;
            }
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

    public void GameStart()
    {
        Debug.Log("ゲームスタート");
        gamestartUI.SetActive(false);
        ballControl.Gamestart();
        timeUI.SetActive(true);
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
