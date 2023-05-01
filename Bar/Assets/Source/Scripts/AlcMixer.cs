using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlcMixer : MonoBehaviour
{
    private List<int> _pickedIngridients = new List<int>();
    [SerializeField] private List<Image> _spawnPoints = new List<Image>();
    [SerializeField] private List<Sprite> _alcPrefs = new List<Sprite>();
    [SerializeField] private List<Sprite> _cocktailsSprites = new List<Sprite>();
    [SerializeField] private List<Image> _coktailsSpwans = new List<Image>();
    [SerializeField] private Sprite _origImg;
    [SerializeField] private GameObject _warning;
    private int _counter = 0;
    private int _mixerCounter = 0;
    private bool _isRecepyRight = false;
    private float _timer= 0;
    
    void Start()
    {
       
    }

    
    void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer <= 0)
        {
            _warning.SetActive(false);
        }
    }

    public void AbsentPicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(0);
            _spawnPoints[_counter].sprite = _alcPrefs[0];
            _counter++;
            
        }
    }

    public void VodkaPIcked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(1);
            _spawnPoints[_counter].sprite = _alcPrefs[1];
            _counter++;


        }
    }

    public void BeerPicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(2);
            _spawnPoints[_counter].sprite = _alcPrefs[2];
            _counter++;
        }
    }

    public void JuciePicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(3);
            _spawnPoints[_counter].sprite = _alcPrefs[3];
            _counter++;
        }
    }

    public void UnicornBloodPicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(4);
            _spawnPoints[_counter].sprite = _alcPrefs[4];
            _counter++;
        }
    }

    public void VordtsBonePicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(5);
            _spawnPoints[_counter].sprite = _alcPrefs[5];
            _counter++;
        }
    }

    public void BadMushroomesPicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(6);
            _spawnPoints[_counter].sprite = _alcPrefs[6];
            _counter++;

        }
    }

    public void AngelTearsPicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(7);
            _spawnPoints[_counter].sprite = _alcPrefs[7];
            _counter++;
        }
    }
    public void Mix()
    {
        int coktailRecepie = 0;
        for (int i = 0; i < _pickedIngridients.Count; i++)
        {
             coktailRecepie += _pickedIngridients[i];
        }
        
        
            switch (coktailRecepie)
            {
                case 8:
                    _coktailsSpwans[_mixerCounter].sprite = _cocktailsSprites[0];
                    _mixerCounter++;
                    _isRecepyRight = true;
                break;

                case 7:
                    _coktailsSpwans[_mixerCounter].sprite = _cocktailsSprites[1];
                    _mixerCounter++;
                    _isRecepyRight = true;
                break;

                case 11:
                    _coktailsSpwans[_mixerCounter].sprite = _cocktailsSprites[2];
                    _mixerCounter++;
                    _isRecepyRight = true;
                break;

                case 9:
                    _coktailsSpwans[_mixerCounter].sprite = _cocktailsSprites[3];
                    _mixerCounter++;
                    _isRecepyRight = true;
                break;

                case 10:
                    _coktailsSpwans[_mixerCounter].sprite = _cocktailsSprites[3];
                    _mixerCounter++;
                    _isRecepyRight = true;
                break;
                
                

            }
        if (_isRecepyRight == false)
        {
            
            _warning.SetActive(true);
            _timer = 3;
        }

        _isRecepyRight = false;
        Erase();
    }
    
    public void Erase()
    {
        int kostl = _pickedIngridients.Count-1;
        Debug.Log("start of erase");
        switch (kostl)
        {
            case 0:
                _pickedIngridients.RemoveAt(0);
            break;

            case 1:
                _pickedIngridients.RemoveAt(1);
                _pickedIngridients.RemoveAt(0);
            break;

            case 2:
                _pickedIngridients.RemoveAt(2);
                _pickedIngridients.RemoveAt(1);
                _pickedIngridients.RemoveAt(0);
            break;
        }
        
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            _spawnPoints[i].sprite = _origImg;
        }
        
       
        _counter = 0;
        Debug.Log(_pickedIngridients.Count);
        Debug.Log("End of erase");
    }
}
