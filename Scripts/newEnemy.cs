using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newEnemy : MonoBehaviour
{
    [Header("Status")]
    public float health;
    public float speed;
    public Rigidbody2D target;

    bool isLive = true; // 몬스터 생존여부
    
    [Header("Drop Item")]
    public GameObject GoldCoin;
    public GameObject SilverCoin;
    public GameObject BronzeCoin;
    public GameObject Health;

    Rigidbody2D rigid; // 물리적으로 이동할거니까
    SpriteRenderer spriter; // 스프라이트 방향에 따른 좌우반전
    Collider2D coll;
    Animator anim;

    private List<GameObject> spawnedBullets = new List<GameObject>(); // 생성된 총알들을 저장할 리스트

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (!isLive)
            return;

        Vector2 dirVec = target.position - rigid.position; // 위치 차이 = 타겟 위치 - 나의 위치
        Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec); // (현재 위치 + 가야할 다음 위치의 양)로 물리적으로 포지션 이동
        rigid.velocity = Vector2.zero; // 물리적인 속도를 0으로. 두둥실 밀려나는것을 방지
    }

    void LateUpdate()
    {
        if (!isLive)
            return;
        spriter.flipX = target.position.x < rigid.position.x;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Bullet"))
            return;

        health -= collision.GetComponent<Bullet>().damage;

        if (health > 0)
        {
            anim.SetTrigger("Hit");
        }
        else
        {
            anim.SetBool("Smoke", true);
            isLive = false;
            coll.enabled = false;
            rigid.simulated = false;
            spriter.sortingOrder = 1;
            DestroySpawnedBullets(); // 에너미가 사라질 때 생성된 총알들도 함께 제거
        }
    }

    void Dead()
    {
        Destroy(gameObject);
        DropItem();
    }

    void DropItem() // 랜덤 확률로 아이템 드랍
    {
        int ran = Random.Range(0, 10);
        if (ran < 3)
        { // 30%
            Debug.Log("No Item");
        }
        else if (ran < 6)
        { // 30%
            Instantiate(BronzeCoin, transform.position, BronzeCoin.transform.rotation);
        }
        else if (ran < 8)
        { // 20%
            Instantiate(SilverCoin, transform.position, SilverCoin.transform.rotation);
        }
        else if (ran < 9)
        { // 10%
            Instantiate(GoldCoin, transform.position, GoldCoin.transform.rotation);
        }
        else if (ran < 10)
        { // 10%
            Instantiate(Health, transform.position, Health.transform.rotation);
        }
    }

    private void DestroySpawnedBullets()
    {
        foreach (GameObject bullet in spawnedBullets)
        {
            Destroy(bullet);
        }
        spawnedBullets.Clear();
    }
}
