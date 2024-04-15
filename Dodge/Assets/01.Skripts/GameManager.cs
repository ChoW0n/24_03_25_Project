using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameover_test;
    public Text time_text;
    public Text record_text;

    private float survive_time;
    bool is_gameover;
    // Start is called before the first frame update
    void Start()
    {
        survive_time = 0;
        is_gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!is_gameover)
        {
            survive_time += Time.deltaTime;
            time_text.text = "Time: " + (int) survive_time;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Dodge_scene");
            }
        }
    }
    public void EndGame()
    {
        is_gameover = true;

        gameover_test.SetActive(true);

        float best_time = PlayerPrefs.GetFloat("Best_time");

        if(survive_time > best_time)
        {
            best_time = survive_time;

            PlayerPrefs.SetFloat("Best_time", best_time);
        }
        record_text.text = "Best Time: " + (int) best_time;
    }
}
