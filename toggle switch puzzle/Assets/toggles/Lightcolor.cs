using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightcolor : MonoBehaviour
{
    public List<GameObject> lights;
    private bool on;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLight()
    {
        foreach (var item in lights)
        {
            on = item.GetComponent<toggle_1>().ison;


            if(!on)
            {
                item.GetComponent<SpriteRenderer>().color = Color.green;
                item.GetComponent<toggle_1>().ison = true;
            }else{
                item.GetComponent<SpriteRenderer>().color = Color.red;
                item.GetComponent<toggle_1>().ison = false;
            }
        }
    }
}
