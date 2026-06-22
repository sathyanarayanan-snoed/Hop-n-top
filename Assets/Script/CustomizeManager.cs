using UnityEngine;

public class CustomizeManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject shopMenu;
    public GameObject Shape;
    public GameObject Trail;
    public GameObject BG;

    public void OpenShop()
    {
        mainMenu.SetActive(false);
        shopMenu.SetActive(true);
    }

    public void CloseShop()
    {
        mainMenu.SetActive(true);
        shopMenu.SetActive(false);
    }

    public void OpenShape()
    {
      Shape.SetActive(true);
      BG.SetActive(false);
      Trail.SetActive(false);
    }

    public void OpenBG()
    {
      BG.SetActive(true);
      Shape.SetActive(false);
      Trail.SetActive(false);
    }

    public void OpenTrails()
    {
      Trail.SetActive(true);
      Shape.SetActive(false);
      BG.SetActive(false);
    }
}
