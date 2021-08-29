using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneController : MonoBehaviour
{
    [SerializeField] private TMP_Text tapToStart;
    [SerializeField] private TMP_Text score;
    [SerializeField] private TouchSlider touchSlider;
 
    private bool isGameStarted;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isGameStarted)
        {
            tapToStart.gameObject.SetActive(false);
            touchSlider.gameObject.SetActive(true);
            score.gameObject.SetActive(true);
            isGameStarted = true;
        }
    }
    private void Start()
    {
        tapToStart.gameObject.SetActive(true);
        touchSlider.gameObject.SetActive(false);
        score.gameObject.SetActive(false);
        isGameStarted = false;
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene("Game");
    }

}
