using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Element", menuName ="Element")]
public class Elements : ScriptableObject
{
    public Sprite _sprite;
    public string _elementName;
    public float health;
    

    public List<string> harrassmentCommands;
}
