using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockControl : MonoBehaviour
{
    private int[] result, correctCombination;
    public GameObject obj0;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject topch;
    public GameObject keyprefab;

    private void Start()
    {
        result = new int[] { 5, 5, 5 };
        correctCombination = new int[] { 5, 2, 9 };
        Rotate.Rotated += CheckResults;        
    }

    private void CheckResults (string wheelName, int number)
    {
        switch (wheelName)
        {
            case "wheel1":
                result[0] = number;
                //Debug.Log("wheel1" + result[0]);
                break;

            case "wheel2":
                result[1] = number;
                //Debug.Log("wheel2" + result[1]);
                break;

            case "wheel3":
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
        Destroy(obj0);
        Destroy(obj1);
        Destroy(obj2);
        topch.GetComponent<Animator>().enabled = true;
        keyprefab.SetActive(true);
        //Instantiate(keyprefab, new Vector3(15, 6, 4), Quaternion.identity);
    }

    private void OnDestroy()
    {
        Rotate.Rotated -= CheckResults;
    }

}
