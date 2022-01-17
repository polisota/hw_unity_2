using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    [Header("slots")]
    public List<GameObject> slotList = new List<GameObject>();

    [Header("puzzle items ")]
    public List<GameObject> itemList = new List<GameObject>();
    public GameObject gameCanvas;
    public GameObject completeCanvas;
    public GameObject trytquitCanvas;
    public GameObject obj0;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject topch;
    public AppleThrower scr;

    //public GameObject  menuCanvas;



    //public int level;
    Game gameObj = new Game();

    void Start()
    {
        gameObj.mixItems(itemList);
    }

    void Update()
    {
        gameObj.checkSlot(slotList);
        if (gameObj.complate)
        {            
            //gameCanvas.SetActive(false);
            StartCoroutine(OffWindow());


        }
    }

    public void nextLevel()
    {
        scr.enabled = true;
        SceneManager.LoadScene("Level2");
    }

    public void toggleMenu()
    {
        gameCanvas.SetActive(false);
        obj0.SetActive(true);
        obj1.SetActive(true);
        obj2.SetActive(true);
        //topch.GetComponent<Animator>().enabled = false;
        //gameCanvas.SetActive(!gameCanvas.activeInHierarchy);

        //menuCanvas.SetActive(!menuCanvas.activeInHierarchy);

    }

    private IEnumerator OffWindow()
    {
        yield return new WaitForSeconds(7);
        gameCanvas.SetActive(false);
        completeCanvas.SetActive(true);
        obj0.SetActive(true);
        obj1.SetActive(true);
        obj2.SetActive(true);
        topch.GetComponent<Animator>().enabled = false;
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void tryToQuit()
    {
        //StartCoroutine(TrtoQuit());
        trytquitCanvas.SetActive(true);
        completeCanvas.SetActive(false);
        //trytquitCanvas.SetActive(true);
    }

    public void cancelToQuit()
    {
        completeCanvas.SetActive(true);
        trytquitCanvas.SetActive(false);
    }

    private IEnumerator TrtoQuit()
    {
        yield return new WaitForSeconds(1);
        completeCanvas.SetActive(false);
        trytquitCanvas.SetActive(true);
    }
}
