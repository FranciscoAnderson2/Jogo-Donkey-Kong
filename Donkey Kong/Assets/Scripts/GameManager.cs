using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int lives;
    private int score;

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        lives = 3;
        score = 0;

        // carregando level
    }

    public void LevelComplete()
    {
        score += 1000;

        // carregando proximo level...
    }

    public void LevelFailed()
    {
        lives--;

        if(lives <= 0){
            NewGame();
        } else{
            //reload o level em que esta agora
        }
    }
}
