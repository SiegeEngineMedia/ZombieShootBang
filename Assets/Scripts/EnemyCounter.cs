using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI enemyText;

    GameObject[] enemies;

    void Start()
    {
        
    }

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemyText.text = enemies.Length.ToString();
        if (enemies.Length == 0)
        {
            GetComponent<SuccessHandler>().HandleSuccess();
        }
    }


}
