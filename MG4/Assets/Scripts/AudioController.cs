using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
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
        if (points > 0)
        {
            _audio.clip = AssetDatabase.LoadAssetAtPath("Assets/Audio/score.wav", typeof(AudioClip)) as AudioClip;
        } else
        {
            _audio.clip = AssetDatabase.LoadAssetAtPath("Assets/Audio/hit.wav", typeof(AudioClip)) as AudioClip;
        }
        _audio.Play();
    }
}
