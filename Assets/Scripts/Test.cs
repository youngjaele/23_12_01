using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    //private Transform transform;
    //private Camera camera;
    //private AudioListener audio;
    //private GameObject go;
    //private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //int num = 0;

        //int i = 3;
        //while (i <= 28)
        //{
        //    num += i;
        //    i++;
        //}
        //Debug.Log(num);

        //int num1 = 0;
        //for (int j = 3; j <= 28; j++)
        //{
        //    num1 += j;
        //}
        //Debug.Log(num1);

        //int sum = 0;
        //int[] arr = { 3, 5, 6, -2, 7, 10 };
        //foreach(var ele in arr)
        //{
        //    Debug.Log(ele);

        //    sum += ele;
        //    Debug.Log(sum);
        //}

        //for (int k = 0; k < arr.Length; k++)
        //{
        //    sum += arr[k];
        //    Debug.Log(sum);
        //}

        // CountDown
        for (int forCount = 10; forCount >= 0; forCount--)
        {
            Debug.Log(forCount);
        }

        int countDown = 10;
        while (countDown >= 0)
        {
            Debug.Log(countDown);
            countDown--;
        }

        //transform = GetComponent<Transform>();
        //audioSource = GetComponentInChildren<AudioSource>();

        //Debug.Log(transform.position.z);
        ////audioSource.volume = 0.5f;

        //DownVolume();
        //DownVolume();
        //audioSource.mute = true;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    //private void DownVolume()
    //{
    //    audioSource.volume -= 0.2f;
    //}
}
