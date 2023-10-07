using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCard : MonoBehaviour
{
    CardsListManager cardList;
    public List<DisplayCard> cards;
    [SerializeField] private GameObject cardsFolderDisplay;

    // Start is called before the first frame update
    void Start()
    {
        cardList = GameObject.Find("CardsList").GetComponent<CardsListManager>();
        RandomCards();

    }


    public void RandomCards()
    {
        for(byte i = 0; i < cards.Count; i++)
        {
            int rand = Random.Range(0, cardList.cardsList.Count);
            cards[i].card = cardList.cardsList[rand];
            cards[i].CardUpdate();
        }
        cardsFolderDisplay.SetActive(false);
    }
}
