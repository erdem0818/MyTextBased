using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
   public static event UnityAction<Enemy> _enemy;

   public Elements[] _element;
   SpriteRenderer spriteRenderer;

   internal List<string> _harrassCommands;
   string _elementName;
   Sprite ElementSprite;
   float health;

   public float _Health{get {return health;}}

   void Awake()
   {
      SetInfo();   
      
   }
   void Update()
   {     
      health = Mathf.Clamp(health,0,10);

      if(_enemy !=null)
         _enemy(this); 
   }
   void SetInfo()
   {
       int random = Random.Range(0,_element.Length);

       _harrassCommands = _element[random].harrassmentCommands;
       _elementName = _element[random]._elementName;
        spriteRenderer = GetComponent<SpriteRenderer>();
       spriteRenderer.sprite = _element[random]._sprite;
       health = _element[random].health;
   }

   public void TakeDamage()
   {    
      health -= Random.Range(1,4);
   }
}
