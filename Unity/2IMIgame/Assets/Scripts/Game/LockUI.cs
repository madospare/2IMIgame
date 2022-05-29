using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LockUI : MonoBehaviour
{

    public GameObject lock2;
    public GameObject lock3;

    // Start is called before the first frame update
    void Start()
    {

        lock2.SetActive(true);
        lock3.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

        // Level 2 will be unlocked if level 1 is cleared
        if (GameMaster.lvl1 == true)
        {
            lock2.SetActive(false);
        }

        //if (lockstate.lv2Cleared == true)
        //{
            //lock3.SetActive(false);
        //}

    }

    // Play level 2
    public void StartLv2()
    {
        if (GameMaster.lvl1 == true)
        {
            SceneManager.LoadScene("Lvl2");
            FindObjectOfType<AudioManager>().Stop("OtherMenusTheme");
        }
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");
    }

    // Play level 3
    public void StartLv3()
    {
        if (GameMaster.lvl1 == true)
        {
            SceneManager.LoadScene("Lvl3");
            FindObjectOfType<AudioManager>().Stop("OtherMenusTheme");
        }
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");
    }
}
