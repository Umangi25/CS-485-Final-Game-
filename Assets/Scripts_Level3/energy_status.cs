﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energy_status : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (gameObject.name == "energytxt")
        {
            GetComponent<TextMesh>().text = "Energy Total : " + GameMaster.energyTotall;
        }
		if (gameObject.name == "status")
        {
            GetComponent<TextMesh>().text = GameMaster.lvlCompStatus;
        }
    }
        
    
}
