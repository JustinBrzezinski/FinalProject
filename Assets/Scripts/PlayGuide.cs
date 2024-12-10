using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayGuide : MonoBehaviour
{
    public GameObject ControlsButton;
    public TextMeshProUGUI p1Controls;
    public TextMeshProUGUI p2Controls;
    public TextMeshProUGUI Powers;
    void Start()
    {
        p1Controls.gameObject.SetActive(false);
        p2Controls.gameObject.SetActive(false);
        Powers.gameObject.SetActive(false);
    }
    public void ControlsMenu()
    {
        p1Controls.gameObject.SetActive(true);
        p2Controls.gameObject.SetActive(true);
        Powers.gameObject.SetActive(true);
    }
}
