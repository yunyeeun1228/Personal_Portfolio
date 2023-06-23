using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public GameObject minimap;

    [Header("References")]
    public RectTransform minimapPoint_1;
    public RectTransform minimapPoint_2;
    public Transform worldPoint_1;
    public Transform worldPoint_2;

    [Header("Player")]
    public RectTransform playerMinimap;
    public Transform playerWorld;

    private float minimapRatio;

    void Start()
    {
        minimap.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    private void Awake()
    {
        CalculateMapRatio();
    }

    // Update is called once per frame
    private void Update()
    {
        playerMinimap.anchoredPosition = minimapPoint_1.anchoredPosition + new Vector2((playerWorld.position.x - worldPoint_1.position.x) * minimapRatio, 
                                        (playerWorld.position.y - worldPoint_1.position.y) * minimapRatio);
    }

    public void CalculateMapRatio()
    {
        Vector2 distanceWorldVector = worldPoint_1.position - worldPoint_2.position;
        //distanceWorldVector.y = 0f;
        float distanceWorld = distanceWorldVector.magnitude;

        float distanceMinimap = Mathf.Sqrt(
            Mathf.Pow((minimapPoint_1.anchoredPosition.x - minimapPoint_2.anchoredPosition.x), 2) +
            Mathf.Pow((minimapPoint_1.anchoredPosition.y - minimapPoint_2.anchoredPosition.y), 2));
        
        minimapRatio = distanceMinimap / distanceWorld;
    }
}
