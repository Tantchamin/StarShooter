using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndCloseUI : MonoBehaviour
{
    public void OpenObject(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public void CloseObject(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

}
