using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class gameManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    bool keyCode = false;
    public List<GameObject> lights;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keyCode)
        {
            text.enabled = true;
        }
        else 
        {
            text.enabled = false;
        }
    }
    public void checkWin()
    {
        int lightsOn = 0;
         foreach (var items in lights)
        {
            
            if (items.GetComponent<toggle_1>().ison)
            {
                lightsOn ++; 
            }
        }
        if (lightsOn == 6)
        {
            keyCode = true;
        }
    }
    public void Reset()
    {
        foreach (var items in lights)
        {
            items.GetComponent<toggle_1>().ison = false;
            items.GetComponent<SpriteRenderer>().color = Color.red;
            keyCode = false;
        }
    }
}
