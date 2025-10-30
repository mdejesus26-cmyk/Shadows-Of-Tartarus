using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [Header("Assign in Inspector")]
    public DeckSO playerDeck;

    void Start()
    {
        // Optional: Print the deck to make sure it works
        if(playerDeck != null)
        {
            playerDeck.PrintDeck();
        }
        else
        {
            Debug.LogWarning("No deck assigned to CardManager!");
        }
    }

    public void UseCard(int index, GameObject target)
    {
        if (index < 0 || index >= playerDeck.cards.Count)
        {
            Debug.LogWarning("Invalid card index!");
            return;
        }

        CardSO card = playerDeck.cards[index];

        switch (card.cardType)
        {
            case CardSO.CardType.Attack:
                Debug.Log($"{card.cardName} attacks {target.name} for {card.attackPower} damage!");
                break;
            case CardSO.CardType.Spell:
                Debug.Log($"{card.cardName} casts a spell on {target.name} for {card.spellPower} damage!");
                break;
            case CardSO.CardType.Item:
                Debug.Log($"{card.cardName} uses an item: {card.itemEffect}");
                break;
        }
    }
}
