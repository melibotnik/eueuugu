using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Collecting : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
      IItem item = collision.GetComponent<IItem>();
      if (item != null)
      {
         item.Collect();
      }
   }
}


