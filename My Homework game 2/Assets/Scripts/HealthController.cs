using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{

    private bool flag = (true);
    [HideInInspector]
    public int levelHealth = 100;
    [Header("Health controller (text)")]
    public Text myText;


    /*
    //[SerializeField] private float MaxHealthPoints;
    //[Range(0, 1f)] private float Range;

    //[HideInInspector]
    //public float CurrentHealth;

    
     void Start()
    {
        CurrentHealth = MaxHealthPoints;
        /*if (gameObject.TryGetComponent<MoveController>(out var c))
        {
            //c.
        }

    void Update()
    {
        if (CurrentHealth <= 0)
        {
            Debug.Log("Player is dead");
            Time.timeScale = 0;
            return;
        }
    }*/

    void Update()
    {
        if (flag)
        {
            myText.GetComponent<Text>().text = "" + levelHealth + "";
            if (levelHealth >= 100)
            {
                levelHealth = 100;
            }
            if (levelHealth <= -10000)
            {
                //myText.GetComponent<Text>().text = "Твой путь окончен";
                Debug.Log("Game over");
                flag = false;
            }
        }
    }
}