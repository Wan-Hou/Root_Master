using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant_Script : MonoBehaviour
{
    public Sprite stage_1, stage_2, stage_3, stage_4, stage_5;
    public int current_stage;

    public void increaseStage() 
    {
        if (current_stage < 5) 
        {
            current_stage++;
            setStage(current_stage);
        }
    }

    public void decreaseStage()
    {
        if (current_stage > 1)
        {
            current_stage--;
            setStage(current_stage);
        }
    }

    public void setStage(int stage)
    {
        switch (current_stage)
        {
            case 1:
                GetComponent<SpriteRenderer>().sprite = stage_1;
                break;
            case 2:
                GetComponent<SpriteRenderer>().sprite = stage_2;
                break;
            case 3:
                GetComponent<SpriteRenderer>().sprite = stage_3;
                break;
            case 4:
                GetComponent<SpriteRenderer>().sprite = stage_4;
                break;
            case 5:
                GetComponent<SpriteRenderer>().sprite = stage_5;
                break;
            default:
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
