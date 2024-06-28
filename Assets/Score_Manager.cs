using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{
    public static Score_Manager instance = null;
    public int level_one_score;
    public int level_two_score;
    public TextMeshProUGUI level_one_score_text;
    public TextMeshProUGUI level_two_score_text;
    public GameObject level_one_badge_one_cover, level_one_badge_two_cover, level_one_badge_three_cover, level_one_badge_four_cover, level_one_badge_five_cover;
    public GameObject level_two_badge_one_cover, level_two_badge_two_cover, level_two_badge_three_cover, level_two_badge_four_cover, level_two_badge_five_cover;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    private void updateHighScores()
    {
        level_one_score_text.text = "Score: " + level_one_score.ToString();
        level_two_score_text.text = "Score: " + level_two_score.ToString();
    }
    private void levelOneCover() 
    {
        if (level_one_score >= 10000)
        {
            level_one_badge_five_cover.SetActive(false);
        }
        if (level_one_score >= 8000)
        {
            level_one_badge_four_cover.SetActive(false);
        }
        if (level_one_score >= 6000)
        {
            level_one_badge_three_cover.SetActive(false);
        }
        if (level_one_score >= 4000)
        {
            level_one_badge_two_cover.SetActive(false);
        }
        if (level_one_score >= 2000)
        {
            level_one_badge_one_cover.SetActive(false);
        }
    }

    private void levelTwoCover()
    {
        if (level_two_score >= 10000)
        {
            level_two_badge_five_cover.SetActive(false);
        }
        if (level_two_score >= 8000)
        {
            level_two_badge_four_cover.SetActive(false);
        }
        if (level_two_score >= 6000)
        {
            level_two_badge_three_cover.SetActive(false);
        }
        if (level_two_score >= 4000)
        {
            level_two_badge_two_cover.SetActive(false);
        }
        if (level_two_score >= 2000)
        {
            level_two_badge_one_cover.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("Level_One_Score", 12000);
        //PlayerPrefs.SetInt("Level_Two_Score", 5000);
        level_one_score = PlayerPrefs.GetInt("Level_One_Score", 0);
        level_two_score = PlayerPrefs.GetInt("Level_Two_Score", 0);
        updateHighScores();
        levelOneCover();
        levelTwoCover();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
