using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score=0;
    public float enemySpeed = 100f;
    public float playerSpeed = 300f;
    public TMP_Text Score;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = score.ToString();

        if(score==10)
        {
            enemySpeed = 200f;
        }
    }
}
