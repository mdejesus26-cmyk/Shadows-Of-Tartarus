using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewDeck", menuName = "Card System/Deck")]
public class DeckSO : ScriptableObject
{
    public List<CardSO> cards = new List<CardSO>();

    public void AddCard(CardSO card)
    {
        if (!cards.Contains(card))
            cards.Add(card);
    }

    public void RemoveCard(CardSO card)
    {
        if (cards.Contains(card))
            cards.Remove(card);
    }

    public void PrintDeck()
    {
        Debug.Log("Deck contains:");
        foreach (CardSO c in cards)
        {
            Debug.Log($"{c.cardName} ({c.cardType})");
        }
    }
}
