using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _mixPanel;
    [SerializeField] private GameObject _recepieBookOpened;

    public void PauseOpen()
    {
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseClose()
    {
        Time.timeScale = 1;
        _pausePanel.SetActive(false);
    }

    public void OpenMixPanel()
    {
        _mixPanel.SetActive(true);
    }
    public void CloseMixPanel()
    {
        _mixPanel.SetActive(false);
    }

    public void OpenRecepBook()
    {
        _recepieBookOpened.SetActive(true);
    }

    public void CloseRecepBook()
    {
        _recepieBookOpened.SetActive(false);
    }
    
}
