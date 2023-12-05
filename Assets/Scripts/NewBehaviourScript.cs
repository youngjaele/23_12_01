using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        
    }
    //int i; // << i는 int타입 이라고 선언

    ////  * 함수 밖에서는 할당을 할 수 없다 * 

    ////private void Start() << 함수 안
    ////{
    ////    i = 5; << int타입 i는 5라고 값을 할당
    ////}

    //public int x = 5;  // 선언하고 >> 할당 했다
    //private int y = 5;
    //protected int z = 5;

    //int a = 1;

    //int d = 123445;
    //float f = 2f;

    //// 문장
    //string s = "안녕!";

    //// 문자 하나만
    //char c = 'a';

    //bool b = true;

    //// 초기화 - 1
    //private void Awake()
    //{
    //    Debug.Log("초기화 1");
    //}

    //// 초기화 - 2
    //void Start()
    //{
    //    //Debug.Log("초기화 2");
    //    // Test();   << i = 500 
    //    i = 100;  // << i = 100 함수가 먼저 실행되고 i = 100값을 할당 
    //              // i = 100이 된다
    //    Test(); // i = 100; 할당 후 함수를 호출 i의 값은 500
    //    Debug.Log(i);
    //    Debug.Log(z);
    //}

    //void Test()
    //{
    //    i = 500;
    //}

    //// 매 프레임 마다
    //void Update()
    //{
    //    // transform.position
    //}

    //// 물리연산 끝나고 
    //// 물리연산이 있다면 Update보다 Fixed가 먼저
    //private void FixedUpdate()
    //{
    //    // Rigidbody2D
    //}

    //// 위에 다 끝나고 
    //private void LateUpdate()
    //{
    //    // Camera
    //}

    //private void OnEnable()
    //{
    //    Debug.Log("켜졌다");
    //    // Script를 붙여놓은 GameObject가 켜질때
    //    // Start 보다 먼저 호출 됨
    //}

    //private void OnDisable()
    //{
    //    Debug.Log("꺼졌다");
    //}


}
