using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player"))
    {
      GameManager.instance.nowHealth += 5;
      if (GameManager.instance.nowHealth > GameManager.instance.maxHealth) 
        GameManager.instance.nowHealth = GameManager.instance.maxHealth;
        Destroy(gameObject);
    }
  }
}