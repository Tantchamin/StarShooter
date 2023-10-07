using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    public Card card;

    public TMP_Text nameText;
    public TMP_Text descriptionText;

    public Image cardImage;

    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.desciption;
        cardImage.sprite = card.image;
    }

    public void CardUpdate()
    {
        nameText.text = card.name;
        descriptionText.text = card.desciption;
        cardImage.sprite = card.image;
    }
}
