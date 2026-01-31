using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Collider2D _collider;
    [SerializeField] private AudioSource _audio;

    public delegate void IntDelegate(int x);
    public event IntDelegate PointsChanged;

    private int _points;
    // Start is called before the first frame update
    void Start()
    {
        _points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = new Vector2(0, _jump);
            _audio.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point Zone")
        {
            _points++;
        } else if (collision.gameObject.tag == "Pipe")
        {
            _points = 0;
        }
        PointsChanged?.Invoke(_points);
    }
}
