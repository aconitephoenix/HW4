using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    // Start is called before the first frame update
    void Start()
    {
        GameController.Instance.player.PointsChanged += HandlePointsChanged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandlePointsChanged(int points)
    {
        _scoreText.text = points.ToString();
    }
}
