using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 김현태_2024137012 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //2-15 문자열 변수 생성
        string message = "안녕하세요";

        Debug.Log(message + "!");
        Debug.Log(message[0]);
        Debug.Log(message[1]);
        Debug.Log(message[2]);

        
        Debug.Log("안녕하세요"[0]);
        Debug.Log("안녕하세요"[1]);
        Debug.Log("안녕하세요"[2]);

        //sizeof 연산자와 string 자료형(불가능)
        //Debug.Log("string : " + sizeof(string));

        //2-16 불 변수 생성
        bool one = 10 < 0;
        bool other = 20 > 100;

        Debug.Log(one);
        Debug.Log(other);

        //2-17 숫자와 관련된 복합 대입 연산잔
        int output = 0;
        output += 52;
        output += 273;
        output += 103;

        Debug.Log(output);

        //2-18 문자와 관련된 복합 대입 연산자
        string output2 = "hello";
        output2 += "world";
        output2 += "!!";

        //2-19 증감 연산자
        int number = 10;
        number++;
        Debug.Log(number);
        number--;
        Debug.Log(number);

        //2-20 증감 연산자의 전위와 후위
        int number2 = 10;
        Debug.Log(number2);
        Debug.Log(number2++);
        Debug.Log(number2--);
        Debug.Log(number2);

        Debug.Log(number2);
        Debug.Log(++number2);
        Debug.Log(--number2);
        Debug.Log(number2);
        //2-24 강제 자료형 변화
        //강제 자료형 변환에 따른 데이터 손실 예
        long longNumber = 2147483647L + 2147483647L;
        int intNumber = (int) longNumber;
        Debug.Log(intNumber);

        //강제 자료형 변환에 따른 데이터 손실 발생하지 않는 예
        long longNumber2 = 52273;
        int intNumber2 = (int)longNumber2;
        Debug.Log(intNumber2);

        //2-25 숫자 손상
        //long 자료형을 int 자료형으로 변환합니다.
        long longNumber3 = 2147483647L + 2147483647L;
        int longToInt = (int)longNumber3;
        Debug.Log(longToInt);

        //double 자료형을 int 자료형으로 변환합니다.
        double doubleNumber = 52.27310332;
        int doubleToint = (int)doubleNumber;
        Debug.Log(doubleToint);

        //2-26 자동 자료형 변환
        //int 자료형의 숫자를 생성합니다.
        int IntNumber = 2147483647;

        //int 자료형을 long 자료형으로 자동 변환 합니다.
        long intToLong = IntNumber;
        Debug.Log(intToLong);

        //int 자료형을 double 자료형으로 자동 변환합니다.
        double intToDouble = IntNumber;
        Debug.Log(intToDouble);

        // string 자료형을 int 자료형으로 변환하니다.(불가능)
        //string numberString = "52273";
        //int intNumber1 = (int)numberString;
        //Debug.Log(intNumber1);

        //2-27 문자열을 숫자로 변환
        Debug.Log(int.Parse("52"));
        Debug.Log(long.Parse("273"));
        Debug.Log(float.Parse("52.273"));
        Debug.Log(double.Parse("103.32"));

        Debug.Log(int.Parse("52").GetType());
        Debug.Log(long.Parse("273").GetType());
        Debug.Log(float.Parse("52.273").GetType());
        Debug.Log(double.Parse("103.32").GetType());

        //FormatException 예외
        Debug.Log(int.Parse("52.273"));
        Debug.Log(int.Parse("abc"));

        


        //2-28 기본 자료형을 문자열로 변환
        Debug.Log((52).ToString());
        Debug.Log((52.273).ToString());
        Debug.Log(('a').ToString());
        Debug.Log((true).ToString());
        Debug.Log((false).ToString());

        Debug.Log((52).ToString().GetType());
        Debug.Log((52.273).ToString().GetType());
        Debug.Log(('a').ToString().GetType());
        Debug.Log((true).ToString().GetType());
        Debug.Log((false).ToString().GetType());

        //2-29 소숫점 제거
        double number3 = 52.273103;
        Debug.Log(number3.ToString("0.0"));
        Debug.Log(number3.ToString("0.00"));
        Debug.Log(number3.ToString("0.000"));
        Debug.Log(number3.ToString("0.0000"));

        //2-30 숫자와 문자열 덧셈
        Debug.Log(52 + 273);
        Debug.Log("52" + 273);
        Debug.Log(52 + "273");
        Debug.Log("52" + "273");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
