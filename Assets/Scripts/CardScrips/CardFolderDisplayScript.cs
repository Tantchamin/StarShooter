using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFolderDisplayScript : MonoBehaviour
{
    [SerializeField] private GameObject cardFolder;
    [SerializeField] private CharacterStatusScript characterStatusScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(characterStatusScript.GetCardValue() >= 10)
        {
            cardFolder.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            cardFolder.SetActive(false);
            Time.timeScale = 1;
        }
        
    }
}
