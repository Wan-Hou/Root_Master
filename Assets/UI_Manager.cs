using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager instance = null;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    public void QuitButtonPressed()
    {
        Application.Quit();
    }

    public GameObject levelPanel;

    public void StartButtonPressed()
    {
        levelPanel.SetActive(true);
    }
    public void MenuBackButtonPressed()
    {
        levelPanel.SetActive(false);
    }

    public GameObject badgePanel;

    public void BadgeButtonPressed()
    {
        badgePanel.SetActive(true);
    }
    public void BadgeBackButtonPressed()
    {
        badgePanel.SetActive(false);
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
