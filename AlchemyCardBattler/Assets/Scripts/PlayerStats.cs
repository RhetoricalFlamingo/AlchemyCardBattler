using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int Health = 3;

    public int Distortion = 3;

    public int Fullness = 0;

    public int CardsDrawn = 1;

    public int Amp = 1;

    private bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Drink()
    {
        if (PotInventory.instance.oCol == 0)
        {
            //if (PotInventory)
        }
    }
}
