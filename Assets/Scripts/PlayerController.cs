using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Button restartButton;
    private float fireRatePistol = 3.0f;
    private float fireRateAR = 10.0f;
    private float fireRateMachingun = 20.0f;
    private float nextFire = 0f;
    public GameObject projectilePrefab;
    public GameObject projectilePrefab1;
    public GameObject projectilePrefab2;
    public GameObject pistol;
    public GameObject assaultRifle;
    public GameObject mashingan;
    private GameObject bullet;
    public Text ScoreText;
   
    public static int points = 0;
    private Vector3 ofsetForPistol = new Vector3(0.125f, 0.225f, 0.2f);
    private Vector3 ofsetForAR = new Vector3(0.125f, 0.225f, 0.5f);
    private Vector3 ofsetForMachinegun = new Vector3(0.1f, 0.23f, 0.55f);


    void Start()
    {
        
        //restartButton = GameObject.Find("Button Restart");



        if (UIMainMenu.activeWeapon == 1)
        {
            pistol.SetActive(true);
            bullet = projectilePrefab;
            Debug.Log("pistol");
        }

        else if (UIMainMenu.activeWeapon == 2)
        {
            assaultRifle.SetActive(true);
            bullet = projectilePrefab1;
            Debug.Log("assaultRifle");
        }

        else if (UIMainMenu.activeWeapon == 3)
        {
            mashingan.SetActive(true);
            bullet = projectilePrefab2;
            Debug.Log("mashingan");
        }

      
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
        Fire();
        AddScore();
    }

    public void Fire()
    {

        if (Time.time > nextFire)

        {
            if (UIMainMenu.activeWeapon == 1)
            {
                nextFire = Time.time + 1.0f / fireRatePistol;
                Instantiate(bullet, transform.position + ofsetForPistol, bullet.transform.rotation);
            }
            
            else if (UIMainMenu.activeWeapon == 2)
            {
                nextFire = Time.time + 1.0f / fireRateAR;
                Instantiate(bullet, transform.position + ofsetForAR, bullet.transform.rotation);
            }
            else if (UIMainMenu.activeWeapon == 3)
            {
                nextFire = Time.time + 1.0f / fireRateMachingun;
                Instantiate(bullet, transform.position + ofsetForMachinegun, bullet.transform.rotation);
            }

        }
    }


    public void ExitMainMenu()
    {
        points = 0;
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        DestroyOutBounds.gameOver = false;
        restartButton.gameObject.SetActive(false);
        points = 0;
        SceneManager.LoadScene(1);
        
    }

    public void GameOver()
    {
        if (DestroyOutBounds.gameOver == true)
        {
            restartButton.gameObject.SetActive(true);
        }
        
    }

    public void AddScore()
    {

        ScoreText.text = $"{points}";

    }


}

