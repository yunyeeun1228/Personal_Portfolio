using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

	SoundManager soundManager;

    private void Awake() {
        soundManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<SoundManager>();
    }

  	private void OnTriggerEnter2D(Collider2D collision)
  	{
    	if (collision.CompareTag("Player"))
		{
			soundManager.PlaySFX(soundManager.Eat);
			if(this.CompareTag("GoldCoin"))
			{
				GameManager.instance.playerCoin += 3;
				Debug.Log("3코인 획득");
			}
			if(this.CompareTag("SliverCoin"))
			{
				GameManager.instance.playerCoin += 2;
				Debug.Log("2코인 획득");
			}
			if(this.CompareTag("BronzeCoin"))
			{
				GameManager.instance.playerCoin += 1;
				Debug.Log("1코인 획득");
			}
			Destroy(gameObject);
		}
  }
}