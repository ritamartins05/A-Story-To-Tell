using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenes : MonoBehaviour
{
    public GameObject[] allScenes;

    public bool itClicked;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        ChangingScenes();
    }

    public void ChangingScenes()
    {
        if (itClicked)
        {
            for (int i = 0; i<allScenes.Length;i++)
            {
                Debug.Log(i);
                if (allScenes[i].activeSelf && i != allScenes.Length - 1)
                { 
                    Debug.Log("Entrou");
                    allScenes[i].SetActive(false);
                    allScenes[i + 1].SetActive(true);
                    itClicked = false;
                    break;
          
                }
            }
        }
    }

    public void onClickNext()
    {
        Debug.Log("Button was clicked");
        itClicked = true;
    }
}
