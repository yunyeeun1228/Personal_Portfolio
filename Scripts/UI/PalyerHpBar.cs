using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PalyerHpBar : MonoBehaviour
{
	public Image nowHpbar;

	void Start()
	{
		nowHpbar = GetComponent<Image>();
	}
	void Update()
  { 
    nowHpbar.fillAmount = (float)GameManager.instance.nowHealth / (float)GameManager.instance.maxHealth;
  }
}