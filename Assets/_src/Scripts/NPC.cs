using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class NPC : MonoBehaviour
{

    [ReadOnly]
    public int id;
    [HideInInspector]
    public bool activeInGame;
    public string npcName;
    public bool alive;
    public float currentRelationship = 0f;
    
    public Sprite[][] npcSprites;

}
