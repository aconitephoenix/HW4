using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }
    public Player player { get; private set; }

    [SerializeField] private GameObject _pipePrefab;

    private float _timer = 4.0f;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        GameObject playerObj = GameObject.FindWithTag("Player");
        player = playerObj.GetComponent<Player>();
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer <= 0)
        {
            SpawnPipe();
        }
    }

    private void SpawnPipe()
    {
        GameObject pipe = Instantiate(_pipePrefab);
        pipe.transform.position += new Vector3(1, Random.Range(1.0f, 3.0f));
        _timer = 4.0f;
    }
}
