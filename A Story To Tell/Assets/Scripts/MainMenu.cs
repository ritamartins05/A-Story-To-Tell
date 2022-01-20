using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject scenes;
    public GameObject firstScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickStart()
    {
        Debug.Log("ClickedStart");
        mainMenu.SetActive(false);
        scenes.SetActive(true);
        firstScene.SetActive(true);


    }
}
