using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public enum InfoType {
        Health
    }
    public InfoType type;

    Text myText;
    Slider mySlider;

    void Awake() {
        myText = GetComponent<Text>();
        mySlider = GetComponent<Slider>();
    } 

    void LateUpdate() {
        switch (type) {
            case InfoType.Health:

                break;
        }
    }


}
