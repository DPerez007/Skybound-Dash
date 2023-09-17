using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

 
  public Player player;
  public GameObject playButton;
  public GameObject gameOver;
  public Text scoreText;
  [SerializeField] private AudioSource BackGroundSound;
  [SerializeField] private AudioSource ScoreSound;
  private int score;

  private void Awake()
  {
    Application.targetFrameRate = 60;

    Pause();
    gameOver.SetActive(false);
    BackGroundSound.Stop();
   
  }



 

   public void Play()
    {
    score = 0;
    scoreText.text = score.ToString();
    BackGroundSound.Play();
    playButton.SetActive(false);
    gameOver.SetActive(false);
    Time.timeScale = 1f;
    player.enabled = true;
    



   Pipes[] pipes = FindObjectsOfType<Pipes>();

   for(int i = 0; i  < pipes.Length; i++)
   {
    Destroy(pipes[i].gameObject);
   }

   }

 public void Pause()
  {
      Time.timeScale = 0f;
      player.enabled = false;
  }


  public void GameOver()
  {
      gameOver.SetActive(true);
      playButton.SetActive(true);
      BackGroundSound.Stop();
      Pause();

  }
  
  public void IncreasedScore()
  {
    ScoreSound.Play();
    score++;
    scoreText.text = score.ToString();

  }


}
