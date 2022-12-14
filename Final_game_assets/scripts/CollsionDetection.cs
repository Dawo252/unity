using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollsionDetection : MonoBehaviour
{
   public GameObject player;
   private int PlayerLevel = 2;
   public GameObject skeleton;
   public GameObject blood;
   public GameObject reset;


   void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.CompareTag("enemy") && (int)Variables.Object(other.gameObject).Get("threat") > PlayerLevel)
      {
         skeleton.SetActive(true);
         blood.SetActive(true);
         player.transform.DetachChildren();
         Destroy(player);
         Camera.main.orthographicSize = 5.0f;
         reset.SetActive(true);
      }
      else if (other.gameObject.CompareTag("enemy") && (int)Variables.Object(other.gameObject).Get("threat") - PlayerLevel > -15 )
      {
         Destroy(other.gameObject);
         PlayerLevel += 1;
         if ((int)Variables.Object(other.gameObject).Get("threat") == 15)
         {
            player.transform.localScale *= 1.08f;
         }
         else if ((int)Variables.Object(other.gameObject).Get("threat") == 6)
         {
            player.transform.localScale *= 1.04f;
         }
         else if ((int)Variables.Object(other.gameObject).Get("threat") == 12)
         {
            player.transform.localScale *= 1.06f;
         }
         else if ((int)Variables.Object(other.gameObject).Get("threat") == 20)
         {
            player.transform.localScale *= 1.1f;
         }
         else
         {
            player.transform.localScale *= 1.02f;
         }
      }
      else
      {
         player.transform.localScale *= 1.005f;
         Destroy(other.gameObject);
      }
   }
}
