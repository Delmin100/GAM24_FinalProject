using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Text playerPoints;
    [SerializeField]
    private GameObject machineGun;
    [SerializeField]
    private GameObject rpgGun;
    [SerializeField]
    private GameObject sniperGun;
    [SerializeField]
    private GameObject pausePanel;
    [SerializeField]
    private GameObject shootingRangeDetection;
    public bool IsInRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void OnPauseMenu()
    {
        pausePanel.SetActive(true);
    }

    void OnLevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");

    }

    void OnLevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }
    void OnLevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }


    

}
