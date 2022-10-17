using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private bool _gameRunning = true;
    [SerializeField] private GameObject _panel = default;
    [SerializeField] private GameObject _pauseText = default;
    [SerializeField] private GameObject _continueButton = default;
    [SerializeField] private GameObject _returnButton = default;
    [SerializeField] private GameObject _playAgainButton = default;
    [SerializeField] private GameObject _gameOverLoseText = default;
    [SerializeField] private GameObject _gameOverWinText = default;
    [SerializeField] private GameObject _pauseButton = default;
    [SerializeField] private GameObject _powerupText = default;
    private bool toggle=false;
    

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Time.timeScale = 1f;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeRunningState();
        }
    }
    public void PowerUpOn()
    {
        _powerupText.SetActive(true);
    }

    public void PowerUpOff()
    {
        _powerupText.SetActive(false);
    }
    public void ChangeRunningState()
    {
        _gameRunning = !_gameRunning;

        if (_gameRunning)
        {
            Time.timeScale = 1f;
            _panel.SetActive(false);
            _pauseText.SetActive(false);
            _continueButton.SetActive(false);
            _returnButton.SetActive(false);
        }
        else
        {
            Time.timeScale = 0f;
            _panel.SetActive(true);
            _pauseText.SetActive(true);
            _continueButton.SetActive(true);
            _returnButton.SetActive(true);
        }
    }

    public void LoseGameOver()
    {
        Time.timeScale = 0f;
        _gameOverLoseText.SetActive(true);
        _playAgainButton.SetActive(true);
        _panel.SetActive(true);
        _returnButton.SetActive(true);
        _pauseButton.SetActive((false));
    }

    public void WinGameOver()
    {
        Time.timeScale = 0f;
        _gameOverWinText.SetActive(true);
        _playAgainButton.SetActive(true);
        _panel.SetActive(true);
        _returnButton.SetActive(true);
        _pauseButton.SetActive((false));
    }

    public bool IsGameRunning()
    {
        return _gameRunning;
    }
}
