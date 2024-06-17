using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameover_text;
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
    //현재 게임을 게임오버 상태로 변경하는 메서드
    public void EndGame()
    {   
        //현재 상태를 게임오버 상태로 전환
        is_gameover = true;
        //게임 오버 텍스트 게임 오브젝트를 활성화
        gameover_text.SetActive(true);

        //BestTime 키로 저장된 이전까지의 최고 기록 가져오기
        float best_time = PlayerPrefs.GetFloat("Best_time");

        //이전까지의 최고 기록보다 현재 생존 시간이 더 크다면
        if(survive_time > best_time)
        {
            //최고 리곡 값을 현재 생존 시간 값으로 변경
            best_time = survive_time;
            //변경된 최고 기록을 BestTime 키로 저장
            PlayerPrefs.SetFloat("Best_time", best_time);
        }
        record_text.text = "Best Time: " + (int) best_time;
    }
}
