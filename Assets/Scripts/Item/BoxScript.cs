using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour, IItem
{
    // Start is called before the first frame update
    public void Collect()
        {
           Destroy(gameObject);
        }
   
    
}
