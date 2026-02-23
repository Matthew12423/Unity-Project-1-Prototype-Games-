using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public UIHandler uiHandler;
    public float time = 300;
    public bool gameOver = false;
    public float lifePoint = 1;
    public PlayerHealth Player;
    public BossHealth Boss;

    // Start is called before the first frame update
    void Start()
    {
        playerLosesPanel.gameObject.SetActive(false);
        playerWinsPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time = Mathf.Clamp(time - Time.deltaTime, 0, float.MaxValue);
        uiHandler.SetTimer(time);

        if (!gameOver && time <=0) GameOver();
        if (!gameOver && Player.health <=0) GameOver();
        if (!gameOver && Boss.health <=0) PlayerWins();
    }

    public void playerHealth(float percent)
    {
        uiHandler.SetplayerHealth(percent);
    
    }

    public void bossHealth(float percent)
    {
        uiHandler.SetbossHealth(percent);
    }

    public void EnemyDeath()
    {
        
    }
    public Transform playerLosesPanel;
    public Transform playerWinsPanel;
    public void GameOver ()
    {
        playerLosesPanel.gameObject.SetActive(true);
        gameOver = true;
        //turn off player control when player loses
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }
    public void PlayerWins()
    {
        playerWinsPanel.gameObject.SetActive(true);
        gameOver = true;
        //turn off player control when player win
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        }
        public void LoadMainMenu()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
}