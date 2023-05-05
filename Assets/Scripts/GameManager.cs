using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;

    public Text computerScoreText;
    private int _playerScore;
    private int _computerScore;

    public Ball ball;

    public void PlayerScore(){
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();

        Allnew();
    }

    public void ComputerScore(){
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();

        Allnew();
    }

    public void Allnew(){
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
