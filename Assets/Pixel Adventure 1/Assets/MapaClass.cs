using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapaClass : MonoBehaviour
{
    public GameObject flagOne, flagTwo, flagThree, FlagFour;
    int levelSelect, currentProgress;

    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        currentProgress = PlayerPrefs.GetInt("current_progress");
        switch (currentProgress)
        {
            case 0:
                flagOne.SetActive(false);
                flagTwo.SetActive(false);
                flagThree.SetActive(false);
                FlagFour.SetActive(false);

                levelSelect = 1;
                transform.position = new Vector2(-4.4f,1.6f);
            break;
            case 1:
                flagOne.SetActive(true);
                flagTwo.SetActive(false);
                flagThree.SetActive(false);
                FlagFour.SetActive(false);

                levelSelect = 2;
                transform.position = new Vector2(-1.4f,1.6f);
            break;
            case 2:
                flagOne.SetActive(true);
                flagTwo.SetActive(true);
                flagThree.SetActive(false);
                FlagFour.SetActive(false);

                levelSelect = 3;
                transform.position = new Vector2(1.4f,1.6f);
            break;
            case 3:
                flagOne.SetActive(true);
                flagTwo.SetActive(true);
                flagThree.SetActive(true);
                FlagFour.SetActive(false);

                levelSelect = 4;
                transform.position = new Vector2(4.4f,1.6f);
            break;
            case 4:
                flagOne.SetActive(true);
                flagTwo.SetActive(true);
                flagThree.SetActive(true);
                FlagFour.SetActive(true);

                levelSelect = 4;
                transform.position = new Vector2(4.4f,1.6f);
            break;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (levelSelect == 1)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
            }
            
            if (Input.GetKeyDown(KeyCode.RightArrow) && currentProgress > 0)
            {
                levelSelect = 2;
                transform.position = new Vector2(-1.4f,1.6f);
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                animator.SetTrigger("enter");
            }
        }else if (levelSelect == 2){
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                levelSelect = 1;
                transform.position = new Vector2(-4.4f,1.6f);
            }
            
            if (Input.GetKeyDown(KeyCode.RightArrow) && currentProgress > 1)
            {
                levelSelect = 3;
                transform.position = new Vector2(1.4f,1.6f);
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(2);
            }
        }else if (levelSelect == 3){
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                levelSelect = 2;
                transform.position = new Vector2(-1.4f,1.6f);
            }
            
            if (Input.GetKeyDown(KeyCode.RightArrow) && currentProgress > 2)
            {
                levelSelect = 4;
                transform.position = new Vector2(4.4f,1.6f);
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(2);
            }
        }else if (levelSelect == 4){
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                levelSelect = 3;
             transform.position = new Vector2(1.4f,1.6f);
            }
            
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
               // NO HACER NADA
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(2);
            }
        }
    }
    public void EnterLevel()
    {
        switch (levelSelect)
        {
            case 1:
                SceneManager.LoadScene(2);
            break;
            case 2:
                SceneManager.LoadScene(3);
            break;
            case 3:
                SceneManager.LoadScene(4);
            break;
            case 4:
                SceneManager.LoadScene(5);
            break;
        }
    }
}
