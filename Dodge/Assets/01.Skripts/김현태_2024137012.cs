using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 김현태_2024137012 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //4-1 배열생성하고 요소에 접근하기
        //배열을 생성합니다.
        int[] intArray = { 52, 273, 32, 65, 103 };

        //배열의 요소를 변경합니다.
        intArray[0] = 0;

        //요소를 출력합니다.
        Debug.Log(intArray[0]);
        Debug.Log(intArray[1]);
        Debug.Log(intArray[2]);
        Debug.Log(intArray[3]);

        //Length 속성
        //배열의 길이를 출력합니다.
        Debug.Log(intArray.Length);

        //4-2 원하는 크기의 배열 생성
        int[] intArray2 = new int[100];

        //요소를 출력합니다
        Debug.Log(intArray2[0]);
        Debug.Log(intArray2[99]);

        //4-3 반복문 이용하기
        //변수를 선언합니다.
        int j = 0;
        int[] intArray3 = { 52, 273, 32, 65, 103 };

        while (j < intArray3.Length)
        {
            //출력합니다.
            Debug.Log(j + "번째 출력:" + intArray3[j]);

            //탈출을 위해 변수를 더합니다.
            j++;
        }

        //4-4 do while 반복문 활용하기
        int k = 0;
        do
        {
            Debug.Log(k + ") 한번은 반드시 출력됨");
            ++k;
        }
        while (k < 4);

        //4-5 for 반복문으로 덧셈하기
        int output = 0;

        //반복문 수행
        for (int L = 0; L <=100; L++)
        {
            output += L;
        }
        Debug.Log(output);

        //4-7 한글 전부 출력하기
        for (int m = '가'; m <= '힣'; m++)
        {
            Debug.Log((char)m);
        }
        //변형 예제
        int sum = 1;
        for (int i = 1; i <= 10; i++)
        {
            
            sum *= 2;
            Debug.Log(sum);
        }

        //변형예제 별 피라미드
        string stars;
        for (int n = 0; n < 10; n++)
        {
            stars = "";
            for (int m = 0; m < n + 1; m++)
            {
                stars += "*";
            }
            Debug.Log(stars);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
