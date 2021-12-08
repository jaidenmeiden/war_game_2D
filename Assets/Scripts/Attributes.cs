using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    [Space] // Include a vertical space
    [Header("Numerical values")] // Put a title to variables group
    public int score;
    [SerializeField] // Allows to display private variables in the editor and modify them
    private int money;

    [Space] 
    [Header("Others values")] 
    [SerializeField]
    private string myName;
    [HideInInspector] // Allows to hide public variables in the editor
    public int range;
    
    [Space] 
    [Header("Tools")] 
    [Range(0,5)] // Assign slide to variable
    public int playerLifes;

    [Min(0)] // Assign minimum value
    public int height;
    
    [Space]
    [Header("Texts")]
    public string ocupation;
    [TextArea] // Assign textArea to variable
    public string description;
    
    [Header("Assignation")] 
    [Tooltip("This is the player size")] 
    [SerializeField]
    private string size;

    // Put a submenu option to call the function in the component menu assigned to this script
    [ContextMenu("Call MyFunction")] 
    public void MyFunction()
    {
        Debug.Log("MyFunction is working!");
    }

    public Player player;
}

[System.Serializable]
public class Player
{
    public string name;
    public string breed;
    public int age;
}
