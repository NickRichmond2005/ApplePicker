using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int score = 0;

    
    private TextMeshProUGUI uiText;

    void Start()
    {
        uiText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = score.ToString("#,0");
    }
}

