using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    [SerializeField] List<string> inputList = new List<string>();

    Enemy enemy;
    List<string> harrassment = new List<string>();//enemy içinde ki harras komutlarını içeren liste.

    public InputField _inputField;

    void Awake()
    {
        enemy = FindObjectOfType<Enemy>();
        _inputField.onEndEdit.AddListener(enteredText);

        harrassment = enemy._harrassCommands;

        for(int i = 0; i< harrassment.Count; i++)
        {
            Debug.Log(harrassment[i]);
        }
    }
    //listeye ekle
    void enteredText(string userInput)
    {
        userInput = userInput.ToLower();
        //inputList.Add(userInput);

        if(CheckInput(userInput))
        {
            enemy.TakeDamage();
            Debug.Log("hasar aldı");
        }
        else{
            Debug.Log("hasar almadı");
        }
        InputCompleted();
    }

    void InputCompleted()
    {
        _inputField.ActivateInputField();
        _inputField.text =null;
    }

    private bool CheckInput(string enter)
    {
        if(harrassment.Contains(enter))
        {
            return true;
        }
        else{
            return false;
        }
    }  
}
