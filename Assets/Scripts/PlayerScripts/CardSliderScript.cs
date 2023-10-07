using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSliderScript : MonoBehaviour
{
    [SerializeField] private Slider cardSlider;
    [SerializeField] private CharacterStatusScript characterStatusScript;

    // Start is called before the first frame update
    void Start()
    {
        cardSlider.value = characterStatusScript.GetCardValue();
    }

    // Update is called once per frame
    void Update()
    {
        cardSlider.value = characterStatusScript.GetCardValue();
    }
}
