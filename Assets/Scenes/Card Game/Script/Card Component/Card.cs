using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private string m_cardName;
    public string CardName {get {return m_cardName;} set {m_cardName = value;}}

    #region Sprite
    [SerializeField] private Sprite m_frontSprite;
    public Sprite FrontSprite {get {return m_frontSprite;} set {m_frontSprite = value;}}

    [SerializeField] private Sprite m_backSprite;
    public Sprite BackSprite {get {return m_backSprite;} set {m_backSprite = value;}}
    
    #endregion
}