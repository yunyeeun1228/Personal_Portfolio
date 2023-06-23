using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : HpCharacter //플레이어 피격 스크립트
{
  Rigidbody2D rigid;
  Animator anim;
  Collider2D coll;
  public int BossDmg = 5;

  public GameManager gameManager;
  public int ColliderDmg = 3;
  public int SnakeDmg = 2;
  private bool isDead;

  SoundManager soundManager;

    private void Awake() {
        soundManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<SoundManager>();
    }

  protected override void Start()
  {
    rigid = GetComponent<Rigidbody2D>();
    rigid.gravityScale = 0;
    anim = GetComponent<Animator>();

    base.Start();
  }

  void Update() {
    if(GameManager.instance.nowHealth <= 0 && !isDead) {
      isDead = true;
      gameManager.gameOver();
      Debug.Log("Dead");
    }
  }

  private void OnTriggerEnter2D(Collider2D col)
  {
    if (col.CompareTag("Bone"))
    {
      Damage(1);
      soundManager.PlaySFX(soundManager.Hit);

      // 플레이어 피격 애니메이션 
      if (GameManager.instance.nowHealth > 0)
      {
        anim.SetTrigger("Hurt");
      }
      else
      {
        col.enabled = false;
        rigid.simulated = false;
        anim.SetTrigger("Dead");
      }
    }

      if (col.CompareTag("Bone1"))
    {
      Damage(2);
      soundManager.PlaySFX(soundManager.Hit);

      // 플레이어 피격 애니메이션 
      if (GameManager.instance.nowHealth > 0)
      {
        anim.SetTrigger("Hurt");
      }
      else
      {
        col.enabled = false;
        rigid.simulated = false;
        anim.SetTrigger("Dead");
      }
    }

      if (col.CompareTag("Bone2"))
    {
      Damage(1);
      soundManager.PlaySFX(soundManager.Hit);

      // 플레이어 피격 애니메이션 
      if (GameManager.instance.nowHealth > 0)
      {
        anim.SetTrigger("Hurt");
      }
      else
      {
        col.enabled = false;
        rigid.simulated = false;
        anim.SetTrigger("Dead");
      }
    }

      if (col.CompareTag("Bone3"))
    {
      Damage(3);
      soundManager.PlaySFX(soundManager.Hit);

      // 플레이어 피격 애니메이션 
      if (GameManager.instance.nowHealth > 0)
      {
        anim.SetTrigger("Hurt");
      }
      else
      {
        col.enabled = false;
        rigid.simulated = false;
        anim.SetTrigger("Dead");
      }
    }

      if (col.CompareTag("Bone4"))
    {
      Damage(5);
      soundManager.PlaySFX(soundManager.Hit);

      // 플레이어 피격 애니메이션 
      if (GameManager.instance.nowHealth > 0)
      {
        anim.SetTrigger("Hurt");
      }
      else
      {
        col.enabled = false;
        rigid.simulated = false;
        anim.SetTrigger("Dead");
      }
    }
    
    else if (col.CompareTag("Boss"))
    {
      Damage(5);
      soundManager.PlaySFX(soundManager.Hit);

      // 플레이어 피격 애니메이션 
      if (GameManager.instance.nowHealth > 0)
      {
        anim.SetTrigger("Hurt");
      }
      else
      {
        col.enabled = false;
        rigid.simulated = false;
        anim.SetTrigger("Dead");
      }
    }
    
    else if (col.CompareTag("0101"))
    {    
      Damage(5);
      soundManager.PlaySFX(soundManager.Hit);

      // 플레이어 피격 애니메이션 
      if (GameManager.instance.nowHealth > 0)
      {
        anim.SetTrigger("Hurt");
      }
      else
      {
        col.enabled = false;
        rigid.simulated = false;
        anim.SetTrigger("Dead");
      }
    }

    else if (col.CompareTag("Heart"))
    {
      // 체력 아이템을 먹을 때 체력 회복
      Heal(2);
      soundManager.PlaySFX(soundManager.Eat);

      if (GameManager.instance.nowHealth >= GameManager.instance.maxHealth) 
      {
        GameManager.instance.nowHealth = GameManager.instance.maxHealth;
        Destroy(col.gameObject);
      }
      else
      {
        Destroy(col.gameObject);
      }
    }
  }
  void Dead()
  {
    soundManager.PlaySFX(soundManager.Death);
    gameObject.SetActive(false);
  }
}
