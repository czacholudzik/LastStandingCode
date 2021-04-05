using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject PanelGraj;
    public GameObject PanelUstawienia;
    public GameObject PanelWyjdz;
    public AudioClip Guzik;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Btn_Graj()
    {
        if (PanelGraj != null)
        {
            PanelGraj.SetActive(true);
        }
    }

    public void Btn_TrybTutorial()
    {
        SceneManager.LoadScene(1);
    }

    public void Btn_Ustawienia()
    {
        if(PanelUstawienia != null)
        {
            PanelUstawienia.SetActive(true);
        }
    }

    public void BtnPowrot()
    {
        if(PanelUstawienia != null)
        {
            PanelUstawienia.SetActive(false);
        }
    }

    public void Btn_Wyjdz()
    {
        if(PanelWyjdz != null)
        {
            PanelWyjdz.SetActive(true);
        }
    }

    public void Btn_WWyjdz()
    {
        Application.Quit();
    }

    public void Btn_AAnuluj()
    {
        if(PanelWyjdz != null)
        {
            PanelWyjdz.SetActive(false);
            Guzik.LoadAudioData();
        }
    }
}
