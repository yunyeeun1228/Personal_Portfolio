using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMap : MonoBehaviour
{
    public GameObject miniMap /**= transform.GetChild(0).gameObject**/;
    private bool IsEnabled;

    public void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        if (IsEnabled = false) {
            miniMap.SetActive(IsEnabled);
        }
    }

    private void TurnOnAndOff() {
        IsEnabled ^= true;
        miniMap.SetActive(IsEnabled);
    }
}
