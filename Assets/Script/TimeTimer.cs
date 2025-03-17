using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeTimer : MonoBehaviour
{
    private TextMeshProUGUI timerText;
	private int minute;
	private float seconds;
	private float oldSeconds;
	//　最初の時間
	private float startTime;
	public GameManager game;
 
	void Start () {
		timerText = GetComponentInChildren <TextMeshProUGUI> ();
		oldSeconds = 0;
		startTime = Time.time;
	}
	void Update () {
		if(game.isGameNow)
		{
			//　Time.timeでの時間計測
			seconds = Time.time - startTime;
	
			minute = (int)seconds / 60;
	
			if((int)seconds != (int)oldSeconds) {
				timerText.text = minute.ToString("00") + ":" + ((int)(seconds % 60)).ToString("00");
			}
			oldSeconds = seconds;
		}
		
    }
}
