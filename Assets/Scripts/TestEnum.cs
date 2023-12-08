using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnum : MonoBehaviour
{
    enum StageLevel
    {
        Easy,
        Medium,
        Hard
    }

    void OnClickLevel(StageLevel stage)
    {
        switch (stage)
        {
            case StageLevel.Easy:
                break;
            case StageLevel.Medium:
                break;
            case StageLevel.Hard:
                break;
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
