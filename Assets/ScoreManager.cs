using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    private GameObject scoreText;
    private int score=0;
	// Use this for initialization
	void Start () {
        this.scoreText = GameObject.Find("ScoreText");
        SetScore();
    }
	// Update is called once per frame
	void OnCollisionEnter (Collision collision)
    {
        string yourTag = collision.gameObject.tag;
        if (yourTag == "SmallStarTag")
        {
            score += 1;
        }
        else if (yourTag == "LargeStarTag")
        {
            score += 3;
        }
        else if (yourTag == "SmallCloudTag")
        {
            score += 5;
        }
        else if (yourTag == "LargeCloudTag")
        {
            score += 10;
        }
        SetScore();
    }
    void SetScore()
    {
        this.scoreText.GetComponent<Text>().text = score.ToString();
    }
}