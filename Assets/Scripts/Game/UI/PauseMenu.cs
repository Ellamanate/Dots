﻿using System;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public event Action OnRestart;

    [SerializeField] private Text _title;
    [SerializeField] private Text _score;
    [SerializeField] private Text _bestScore;
    [SerializeField] private Button _restart;

    public void UpdateTitle(string title)
    {
        _title.text = title;
    }

    public void UpdateScore(string score, string bestScore)
    {
        _score.text = score;
        _bestScore.text = bestScore;
    }

    private void Awake()
    {
        _restart.onClick.AddListener(() => OnRestart.Invoke());
    }
}