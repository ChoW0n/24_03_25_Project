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
    //���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    public void EndGame()
    {   
        //���� ���¸� ���ӿ��� ���·� ��ȯ
        is_gameover = true;
        //���� ���� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
        gameover_text.SetActive(true);

        //BestTime Ű�� ����� ���������� �ְ� ��� ��������
        float best_time = PlayerPrefs.GetFloat("Best_time");

        //���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if(survive_time > best_time)
        {
            //�ְ� ���� ���� ���� ���� �ð� ������ ����
            best_time = survive_time;
            //����� �ְ� ����� BestTime Ű�� ����
            PlayerPrefs.SetFloat("Best_time", best_time);
        }
        record_text.text = "Best Time: " + (int) best_time;
    }
}
