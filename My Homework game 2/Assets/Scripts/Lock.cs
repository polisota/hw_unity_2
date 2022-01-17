using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    private int[] result, correctCombination;
    public GameObject obj0;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject topch;
    public GameObject canvas;

    private void Start()
    {
        result = new int[] { 5, 5, 5 };
        correctCombination = new int[] { 6, 9, 4 };
        Rotate.Rotated += CheckResults;
    }

    private void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {
            case "wheel4":
                result[0] = number;
                //Debug.Log("wheel1" + result[0]);
                break;

            case "wheel5":
                result[1] = number;
                //Debug.Log("wheel2" + result[1]);
                break;

            case "wheel6":
                result[2] = number;
                //Debug.Log("wheel3" + result[2]);
                break;
        }
        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2])
        {
            Debug.Log("Opened");
            StartCoroutine(OffWindow());
        }
    }

    private IEnumerator OffWindow()
    {
        yield return new WaitForSeconds(2);
        //Destroy(obj0);
        //Destroy(obj1);
        //Destroy(obj2);
        obj0.SetActive(false);
        obj1.SetActive(false);
        obj2.SetActive(false);
        topch.GetComponent<Animator>().enabled = true;
        canvas.SetActive(true);

    }

    private void OnDestroy()
    {
        Rotate.Rotated -= CheckResults;
    }
}
