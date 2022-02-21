using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIMainMenu : MonoBehaviour
{
    public GameObject mashinganObject;
    public GameObject pistolObject;
    public GameObject arObject;
   
    public static int activeWeapon;

    // Start is called before the first frame update
    void Start()
    {
        activeWeapon = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (activeWeapon == 2)
        {
            SetActiveWeaponAR();
        }

        if (activeWeapon == 3)
        {
            SetActiveWeaponMashingan();
        }

    }

    public void SetActiveWeaponMashingan()
    {
        mashinganObject.SetActive(true);
        pistolObject.SetActive(false);
        arObject.SetActive(false);
        activeWeapon = 3;
        Debug.Log("SetActiveWeaponMashingan");
    }

    public void SetActiveWeaponPistol()
    {
        activeWeapon = 1;
        pistolObject.SetActive(true);
        mashinganObject.SetActive(false);
        arObject.SetActive(false);
        Debug.Log("SetActiveWeaponPistol");
    }
   /* public void SetActiveWeaponAR()
     {
         arObject.SetActive(true);
         mashinganObject.SetActive(false);
         pistolObject.SetActive(false);
         activeWeapon = 2;
         Debug.Log("SetActiveWeaponAR");
     }

     */

    public void SetActiveWeaponAR()
    {
        
            arObject.SetActive(true);
            mashinganObject.SetActive(false);
            pistolObject.SetActive(false);
            Debug.Log("SetActiveWeaponAR");
        
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
       Application.Quit();
#endif
    }

}