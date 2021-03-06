﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health_Controller : MonoBehaviour
{
   public Enter_Again enter_Again;

   public int health;
   public int numOfHearts;

   public Image[] hearts;
   public Sprite fullHeart;
   public Sprite emptyHeart;

   public void Enemy_Collision()
   {
       health=health-1;
       //SceneManager.LoadScene("End_Of_Level");
       }
  

   private void Update()
   {  
       if(health==0)
       {
          //SceneManager.LoadScene("End_Of_Level");
           gameObject.SetActive(false);
          enter_Again.PlayerDied();
       }
       if(health > numOfHearts)
       {
           health = numOfHearts;
       }

       for( int i=0 ;i < hearts.Length ; i++)
       {
          if(i < health)
           {
               hearts[i].sprite = fullHeart;
           }
           else
           {
               hearts[i].sprite = emptyHeart;
           }
           

           if(i < numOfHearts)
           {
               hearts[i].enabled = true;
           }
           else
           {
               hearts[i].enabled=false;
           }
       }
   }
}
