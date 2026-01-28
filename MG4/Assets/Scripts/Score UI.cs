using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
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

    }
}
