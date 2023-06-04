using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    [SerializeField] GameObject upperprefab, lowerprefab;
    GameObject playarea,upper,lower;
    private float currentTimelower;
    private float currentTimeupper;


    // Start is called before the first frame update
    void Start()
    {
        playarea = GameObject.FindGameObjectWithTag("playarea");
        //startSpawn();
        currentTimelower = Time.time+3f;
        currentTimeupper = Time.time;
    }


   
    // Update is called once per frame
    void Update()
    {

        if (Time.time >= currentTimelower)
        {
            lower = Instantiate(lowerprefab, GameObject.Find("playArea").transform/* playarea.transform*/);
            lower.transform.localScale = Vector2.one * Random.Range(1.8f, 2.2f);
            currentTimelower += 6f;
        }

        if (Time.time >= currentTimeupper)
        {
            upper = Instantiate(upperprefab,GameObject.Find("playArea").transform/* playarea.transform*/);
            upper.transform.localScale = Vector2.one * Random.Range(1.8f, 2.2f);
            currentTimeupper += 6f;
        }



    }





    public void startSpawn()
    {
        InvokeRepeating("spawnlower",.5f,1f);
        InvokeRepeating("spawnupper",1f,1f);

    }


    public void spawnlower()
    {
       
       lower = Instantiate(lowerprefab, playarea.transform);
       lower.transform.localScale = Vector2.one*Random.Range(2,3);
    }

    public void spawnupper()
    {
        upper = Instantiate(upperprefab, playarea.transform);
        upper.transform.localScale = Vector2.one * Random.Range(2, 3);

    }
}
