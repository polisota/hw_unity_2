using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstChestLock : MonoBehaviour
{
    /*
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject lock_obj;
    public GameObject window;
    public CameraLook scr;
    public RaycastScript scr1;

    void Update()
    {
        if (OnMouseDown1())
        {
            if (OnMouseDown2())
            {
                if (OnMouseDown3())
                { 
                    Destroy(lock_obj);
                    StartCoroutine(OffWindow());
                    scr.enabled = true;
                    scr1.enabled = true;
                }
                else
                {
                    obj1.SetActive(true);
                    obj2.SetActive(true);
                }
            }
            else
            {
                obj1.SetActive(true);
            } 
        } 
    }

    void OnMouseDown1() //функция клика мышью
    {
        obj1 = GameObject.Find("/Lock_1/Image/btn1");
        obj1.SetActive(false);
        Debug.Log("obj1");
        return true;
    }

    void OnMouseDown2() //функция клика мышью
    {
        obj2 = GameObject.Find("/Lock_1/Image/btn2");
        obj2.SetActive(false);
        Debug.Log("obj2");
        return true;
    }

    void OnMouseDown3() //функция клика мышью
    {
        obj3 = GameObject.Find("/Lock_1/Image/btn3");
        obj3.SetActive(false);
        Debug.Log("obj3");
        return true;
    }       

    private IEnumerator OffWindow()
    {        
        yield return new WaitForSeconds(2);
        window.SetActive(false);
    }

    
      if (OnMouseDown1())
        {            
            obj1.SetActive(false);
            Debug.Log("obj1");

            if (obj3 = GameObject.Find("/Lock_1/Image/btn3"))
            {                    
                obj3.SetActive(false);
                Debug.Log("obj3");

                if (obj2 = GameObject.Find("/Lock_1/Image/btn2"))
                {                    
                    obj2.SetActive(false);
                    Debug.Log("obj2");
                    Destroy(lock_obj);
                    StartCoroutine(OffWindow());
                    scr.enabled = true;
                    scr1.enabled = true;
                }
                else
                {
                    obj1.SetActive(true);
                    obj2.SetActive(true);
                }
            }
            else
            {
                obj1.SetActive(true);
            }           

        }
     
     */


    /*
     void OnMouseDown() //функция клика мышью
    {
        if(obj1 = GameObject.Find("/Lock_1/Image/btn1"))
        {
            obj1.SetActive(false);

            if (obj3 = GameObject.Find("/Lock_1/Image/btn3"))
            {
                obj3.SetActive(false);

                if (obj2 = GameObject.Find("/Lock_1/Image/btn2"))
                {
                    obj2.SetActive(false);
                    Destroy(lock_obj);
                    StartCoroutine(OffWindow());
                    scr.enabled = true;
                    scr1.enabled = true;
                }
                else
                {
                    obj1.SetActive(true);
                    obj2.SetActive(true);
                }
            }
            else
            {
                //obj1.SetActive(true);
            }
        }         
    }
     
     
     
     */



    /*
   //public Transform Position;
   public GameObject btn1;
   public GameObject btn2;
   public GameObject btn3;
   public GameObject btn4;
   public GameObject btn5;


   void Start()
   {
       if (btn1)
       {
           btn1.SetActive(false);
           //Destroy(btn1.GetComponent<Image>());

           if (btn3cl())
           {
               Destroy(btn3.GetComponent<Image>());

               if (btn2cl())
               {
                   Destroy(btn2.GetComponent<Image>());

                   if (btn5cl())
                   {
                       Destroy(btn5.GetComponent<Image>());

                       if (btn4cl())
                       {
                           Destroy(btn4.GetComponent<Image>());
                       }
                       else
                       {
                           Instantiate(btn1.GetComponent<Image>());
                           Instantiate(btn3.GetComponent<Image>());
                           Instantiate(btn2.GetComponent<Image>());
                           Instantiate(btn5.GetComponent<Image>());
                           Instantiate(btn4.GetComponent<Image>());
                       }
                   }
                   else
                   {
                       Instantiate(btn1.GetComponent<Image>());
                       Instantiate(btn3.GetComponent<Image>());
                       Instantiate(btn2.GetComponent<Image>());
                       Instantiate(btn5.GetComponent<Image>());
                   }
               }
               else
               {
                   Instantiate(btn1.GetComponent<Image>());
                   Instantiate(btn3.GetComponent<Image>());
                   Instantiate(btn2.GetComponent<Image>());
               }

           }
           else
           {
               Instantiate(btn1.GetComponent<Image>());
               Instantiate(btn3.GetComponent<Image>());
           }
       }
       else
       {
           Instantiate(btn1.GetComponent<Image>());
       }

   }

   void ButtonClicked(GameObject btn1)
   {
       btn1.SetActive(false);
       Debug.Log("Button clicked");
   }

   public bool btn1cl ()
   {
       return true;
   }

   public bool btn2cl()
   {
       return true;
   }

   public bool btn3cl()
   {
       return true;
   }

   public bool btn4cl()
   {
       return true;
   }

   public bool btn5cl()
   {
       return true;
   }




    * void Start()
   {
       if (btn1cl())
       {
           Destroy(btn1.GetComponent<Image>());

           if (btn3cl())
           {
               Destroy(this.btn3);

               if (btn2cl())
               {
                   Destroy(this.btn2);

                   if (btn5cl())
                   {
                       Destroy(this.btn5);

                       if (btn4cl())
                       {
                           Destroy(this.btn4);
                       }
                       else
                       {
                           Instantiate(btn1); //, Position.position, Quaternion.identity);
                           Instantiate(btn3); //, Position.position, Quaternion.identity);
                           Instantiate(btn2); //, Position.position, Quaternion.identity);
                           Instantiate(btn5); //, Position.position, Quaternion.identity);
                           Instantiate(btn4); //, Position.position, Quaternion.identity);
                       }
                   }
                   else
                   {
                       Instantiate(btn1); //, Position.position, Quaternion.identity);
                       Instantiate(btn3); //, Position.position, Quaternion.identity);
                       Instantiate(btn2); //, Position.position, Quaternion.identity);
                       Instantiate(btn5); //, Position.position, Quaternion.identity);
                   }
               }
               else
               {
                   Instantiate(btn1); //, Position.position, Quaternion.identity);
                   Instantiate(btn3); //, Position.position, Quaternion.identity);
                   Instantiate(btn2); //, Position.position, Quaternion.identity);
               }

           }
           else
           {
               Instantiate(btn1); //, Position.position, Quaternion.identity);
               Instantiate(btn3); //, Position.position, Quaternion.identity);
           }
       }
       else
       {
           Instantiate(btn1); //, Position.position, Quaternion.identity);
       }

   }


   public bool btn1cl ()
   {
       return true;
   }

   public bool btn2cl()
   {
       return true;
   }

   public bool btn3cl()
   {
       return true;
   }

   public bool btn4cl()
   {
       return true;
   }

   public bool btn5cl()
   {
       return true;
   }
    void Update()
   {

   }
    */

}
