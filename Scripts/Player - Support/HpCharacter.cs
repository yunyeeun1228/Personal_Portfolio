using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HpCharacter : MonoBehaviour

{
    [SerializeField]
    private SpriteRenderer hpSprite;

    private Transform hpBar;

    //Animation
    private Color lowColor = Color.red;
    private Color fullColor = Color.green;
    private float animationSpeed = 0.3f;
    private Coroutine hpRoutine;

    protected virtual void Start()
    {
        hpBar = hpSprite.GetComponent<Transform>();
        Reset();

    }

    public void Update()
    { 
        // hpBar.fillAmount = (float)GameManager.instance.nowHealth / (float)GameManager.instance.maxHealth;
    }

    public void Reset() {
        GameManager.instance.nowHealth = GameManager.instance.maxHealth;
        SetBarAmount(1);
    }

    public void Damage(int amount) {
        SetHp(GameManager.instance.nowHealth - amount);
    }

    public void Heal(int amount) {
        SetHp(GameManager.instance.nowHealth + amount);
    }

    public void SetHp(int targetHp) {
        targetHp = Mathf.Clamp(targetHp, 0, GameManager.instance.maxHealth);

        if(GameManager.instance.nowHealth != targetHp) {
            if(hpRoutine != null) 
                StopCoroutine(hpRoutine);

            GameManager.instance.nowHealth = targetHp;
            float ratio = (float)GameManager.instance.nowHealth / (float)GameManager.instance.maxHealth;
            hpRoutine = StartCoroutine(HpAnimateRoutine(ratio));
        }
    }

    private IEnumerator HpAnimateRoutine(float targetRatio) {
        float currentRatio = hpBar.localScale.x;
        bool isReduce = currentRatio > targetRatio;
        float diff = Mathf.Abs(currentRatio - targetRatio);

        float time = 0;

        while(time < animationSpeed) {
            float percentage = time/animationSpeed;
            time += Time.deltaTime;
            float amount = isReduce
                ? currentRatio - (diff * percentage)
                : currentRatio + (diff * percentage);
            SetBarAmount(amount);
            yield return null;
        }
    }

    private void SetBarAmount(float amount) {
        amount = Mathf.Clamp(amount, 0, 1);
        hpBar.localScale = new Vector2 (amount, hpBar.localScale.y);
        hpSprite.color = Color.Lerp(lowColor, fullColor, amount);
    }
}
