using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager manager;
    [SerializeField] GameObject _introPanel;
    [SerializeField] GameObject _nextLevelPanel;
    [SerializeField] TextMeshProUGUI _scoreText;
    private void Awake() 
    {
        manager = this;    
    }

    public void ScoreUpdate(int score)
    {
        _scoreText.text = "" + score;
    }
    public void HideIntro()
    {
        _introPanel.SetActive(false);
    }
    public void ShowNextLevelPanel()
    {
        _nextLevelPanel.SetActive(true);
    }
}
