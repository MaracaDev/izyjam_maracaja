using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float coins;

    public TMP_Text coins_txt;

    public GameObject vfx1, vfx2, vfx3;
    void Start()
    {
        instance = this;
        vfx1.SetActive(false);
        vfx2.SetActive(false);
        vfx3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        coins_txt.text = coins.ToString();
    }



    public void Activate_fx()
    {
        vfx1.SetActive(true);
        vfx2.SetActive(true);
        vfx3.SetActive(true);
    }
}
