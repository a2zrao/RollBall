using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject obstacle;
    public Transform spwanPoint;
    public int score = 0 ;
    public TextMeshProUGUI scoreText;
    public string endscore;
    public GameObject playButton;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        // GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator SpawnObstacles()
    {
        while(true)
        {
            float waitTime = Random.Range(0.4f, 2.5f);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacle, spwanPoint.position, Quaternion.identity);

        }
    }



    void scoreUp()
    {
        
        score++;
        scoreText.text = score.ToString();
        endscore = score.ToString();
        

    }


    public void GameStart()
    {
        player.SetActive(true);
        playButton.SetActive(false);
        
        StartCoroutine("SpawnObstacles");
        InvokeRepeating("scoreUp", 2f, 0.8f);
    }
}
