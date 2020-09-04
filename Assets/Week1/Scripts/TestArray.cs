using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestArray : MonoBehaviour
{

    public static List<string> fruits = new List<string>();
    public GameObject displayText;
    public RawImage fruit;
    public List<Texture2D> fruitsTex = new List<Texture2D>();

    void Start()
    {
        fruits.Add("Carrot");
        fruits.Add("Orange");
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Strawberry");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (fruits.Count > 0)
            {

                fruit.texture = fruitsTex[0];
                fruitsTex.RemoveAt(0);
                fruits.RemoveAt(0);
                displayText.GetComponent<Text>().text = "";

            } else {

                fruit.enabled = false;
                displayText.GetComponent<Text>().text = "Item is Empty";

            }
        }

        string fruitsText = "";

        foreach (string str in fruits)
        {
            fruitsText += str + "\n";
        }

        if (fruits.Count > 0)
        {
            displayText.GetComponent<Text>().text = fruitsText;
        }
    }
}
