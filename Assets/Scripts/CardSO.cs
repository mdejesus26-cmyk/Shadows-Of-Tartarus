using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card System/Card")]

public class CardSO : ScriptableObject
{
    public enum CardType
    {
        Attack,
        Spell,
        Item
    }



        public string cardName;
        public CardType cardType;
        public int cost;          // e.g., AP cost or mana
        public int attackPower;   // Only for Attack cards
        public int spellPower;    // Only for Spell cards
        public string itemEffect; // Only for Item cards
        public Sprite cardImage;  // Optional card artwork
  
}
