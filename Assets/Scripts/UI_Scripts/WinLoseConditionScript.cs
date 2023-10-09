using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseConditionScript : MonoBehaviour
{
    [SerializeField] private GameObject winUI;
    [SerializeField] private GameObject loseUI;
    [SerializeField] private CharacterStatusScript _characterStatusScript;
    [SerializeField] private CharacterControlScript _characterControlScript;
    [SerializeField] private EnemyStatusScript _enemyStatusScript;
    [SerializeField] private EnemyHealthStateScript _enemyHealthStateScript;
    [SerializeField] private EnemyMoveScript _enemyMoveScript;

    // Start is called before the first frame update
    void Start()
    {
        winUI.SetActive(false);
        loseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(_characterStatusScript.GetHealthPoint() <= 0)
        {
            loseUI.SetActive(true);
            _characterControlScript.enabled = false;
            //_enemyHealthStateScript.enabled = false;
            //_enemyMoveScript.enabled = false;
            Time.timeScale = 0;
        }
        else if(_enemyStatusScript.GetHealthPoint() <= 0)
        {
            winUI.SetActive(true);
            _characterControlScript.enabled = false;
            Time.timeScale = 0;
        }

    }
}
