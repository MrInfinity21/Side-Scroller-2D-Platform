using System;
using System.Collections;
using System.Collections.Generic;
using Code.Scripts.Utility;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class GameUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    [SerializeField] private TMP_Text _timeText;

    [SerializeField] private CollectableEventData _collectableEventData;
    // Start is called before the first frame update
    private float _elapsedTime;
    private int _scoreValue;
    void Start()
    {
        _collectableEventData.Collected += IncreaseScore;
    }

    private void UpdateGameTime()
    {
        var ts = TimeSpan.FromSeconds(Time.time);
        _timeText.text = string.Format("{0:00}, {1:00}", ts.Minutes, ts.Seconds);
    }
    // Update is called once per frame
    void Update()
    {
        UpdateGameTime();
    }

    public void IncreaseScore(int value)
    {
        _scoreValue += value;
        _scoreText.text = "" + _scoreValue;
    }
    
}
