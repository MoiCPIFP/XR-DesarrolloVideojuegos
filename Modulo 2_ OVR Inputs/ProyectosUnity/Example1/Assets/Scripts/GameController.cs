using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    private List<GameObject> _cans; // Lista de elementos de objetivos
    private int _score = 0;
    public TextMeshProUGUI scoreText;

    //public static GameController Instance { get; private set; }

    //void Awake()
    //{
    //    Instance = this;

    //}

    void Start()
    {
        _cans = new List<GameObject>(GameObject.FindGameObjectsWithTag("Cans"));

    }

    public void TargetHit(GameObject go)
    {
        Debug.Log("Score: " + _score);
        if (_cans.Contains(go))
        {
            _score += 10;
            _cans.Remove(go);
            Debug.Log("Score " + _score);
            scoreText.text = "Score: " + _score;
            Destroy(go, 5);
        }
    }

}
