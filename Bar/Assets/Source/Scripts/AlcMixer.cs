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
    [SerializeField] private List<Image> _realAlcPrefs = new List<Image>();
    [SerializeField] private List<Transform> _realSpawnPoints = new List<Transform>();
    [SerializeField] private List<Transform> _spawnsInServePanel = new List<Transform>();
    [SerializeField] private Sprite _origImg;
    [SerializeField] private GameObject _warning;
    [SerializeField] private Color _noAlphaColor;
    [SerializeField] private Color _alphaColor;
    [SerializeField] private GameObject _mxerScreen;
    [SerializeField] private GameObject _servingScreen;
    [SerializeField] private GameObject _coctailsAmountWarning;
    private int _counter = 0;
    private int _mixerCounter = 0;
    private bool _isRecepyRight = false;
    private float _timer= 0;
    private float _timerForSecondWarning = 0;
    
        
    
    void Update()
    {
        _timer -= Time.deltaTime;
        _timerForSecondWarning -= Time.deltaTime;
        if (_timer <= 0)
        {
            _warning.SetActive(false);
        }
        if (_timerForSecondWarning <= 0)
        {
            _coctailsAmountWarning.SetActive(false);
        }
    }

    public void AbsentPicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(0);
            _spawnPoints[_counter].color = _alphaColor;
            _spawnPoints[_counter].sprite = _alcPrefs[0];
            _counter++;
            Debug.Log("Мы в абсенте");
        }
    }

    public void VodkaPIcked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(1);
            _spawnPoints[_counter].color = _alphaColor;
            _spawnPoints[_counter].sprite = _alcPrefs[1];
            _counter++;
            Debug.Log("Мы в водке");

        }
    }

    public void BeerPicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(2);
            _spawnPoints[_counter].color = _alphaColor;
            _spawnPoints[_counter].sprite = _alcPrefs[2];
            _counter++;
            Debug.Log("Мы в пиве");
        }
    }

    public void JuciePicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(3);
            _spawnPoints[_counter].color = _alphaColor;
            _spawnPoints[_counter].sprite = _alcPrefs[3];
            _counter++;
            Debug.Log("Мы в соке");
        }
    }

    public void UnicornBloodPicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(4);
            _spawnPoints[_counter].color = _alphaColor;
            _spawnPoints[_counter].sprite = _alcPrefs[4];
            _counter++;
            Debug.Log("Мы в крови единарога");
        }
    }

    public void VordtsBonePicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(5);
            _spawnPoints[_counter].color = _alphaColor;
            _spawnPoints[_counter].sprite = _alcPrefs[5];
            _counter++;
            Debug.Log("Мы в кости вордта");
        }
    }

    public void BadMushroomesPicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(6);
            _spawnPoints[_counter].color = _alphaColor;
            _spawnPoints[_counter].sprite = _alcPrefs[6];
            _counter++;
            Debug.Log("Мы в гнилых грибах");
        }
    }

    public void AngelTearsPicked()
    {
        if (_pickedIngridients.Count < 3)
        {
            _pickedIngridients.Add(7);
            _spawnPoints[_counter].color = _alphaColor;
            _spawnPoints[_counter].sprite = _alcPrefs[7];
            _counter++;
            Debug.Log("мы в слезах ангела ");
        }
    }
    public void Mix()
    {
        int coktailRecepie = 0;
        for (int i = 0; i < _pickedIngridients.Count; i++)
        {
             coktailRecepie += _pickedIngridients[i];
        }
        Debug.Log(coktailRecepie);
        
            switch (coktailRecepie)
            {
                case 8:
                // _coktailsSpwans[_mixerCounter].sprite = _cocktailsSprites[0];
                //_coktailsSpwans[_mixerCounter].color = _alphaColor;
                    if (_mixerCounter < 5)
                    {
                        Instantiate(_realAlcPrefs[0], _realSpawnPoints[_mixerCounter]);
                        Instantiate(_realAlcPrefs[0], _spawnsInServePanel[_mixerCounter]);
                    
                    } else
                    {
                        _coctailsAmountWarning.SetActive(true);
                        _timerForSecondWarning = 3;
                    }
                   
                    _mixerCounter++;
                    _isRecepyRight = true;
                break;

                case 7:
                //_coktailsSpwans[_mixerCounter].sprite = _cocktailsSprites[1];
                //_coktailsSpwans[_mixerCounter].color = _alphaColor;
                    if (_mixerCounter < 5)
                    {
                        Instantiate(_realAlcPrefs[1], _realSpawnPoints[_mixerCounter]);
                        Instantiate(_realAlcPrefs[1], _spawnsInServePanel[_mixerCounter]);
                    }
                    else
                    {
                        _coctailsAmountWarning.SetActive(true);
                        _timerForSecondWarning = 3;
                    }
                    _mixerCounter++;
                    _isRecepyRight = true;
                break;

                case 11:
                //_coktailsSpwans[_mixerCounter].sprite = _cocktailsSprites[2];
                //_coktailsSpwans[_mixerCounter].color = _alphaColor;
                    if (_mixerCounter < 5)
                    {
                        Instantiate(_realAlcPrefs[2], _realSpawnPoints[_mixerCounter]);
                        Instantiate(_realAlcPrefs[2], _spawnsInServePanel[_mixerCounter]);
                    }
                    else
                    {
                        _coctailsAmountWarning.SetActive(true);
                        _timerForSecondWarning = 3;
                    }
                    _mixerCounter++;
                    _isRecepyRight = true;
                break;

                case 9:
                //_coktailsSpwans[_mixerCounter].sprite = _cocktailsSprites[3];
                //_coktailsSpwans[_mixerCounter].color = _alphaColor;
                    if (_mixerCounter < 5)
                    {
                        Instantiate(_realAlcPrefs[3], _realSpawnPoints[_mixerCounter]);
                        Instantiate(_realAlcPrefs[3], _spawnsInServePanel[_mixerCounter]);
                    }
                    else
                    {
                        _coctailsAmountWarning.SetActive(true);
                        _timerForSecondWarning = 3;
                    }
                    _mixerCounter++;
                    _isRecepyRight = true;
                break;

                case 10:
                //_coktailsSpwans[_mixerCounter].sprite = _cocktailsSprites[4];
                //_coktailsSpwans[_mixerCounter].color = _alphaColor;
                    if (_mixerCounter < 5)
                    {
                        Instantiate(_realAlcPrefs[4], _realSpawnPoints[_mixerCounter]);
                        Instantiate(_realAlcPrefs[4], _spawnsInServePanel[_mixerCounter]);
                    }
                    else
                    {
                        _coctailsAmountWarning.SetActive(true);
                        _timerForSecondWarning = 3;
                    }
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
            _spawnPoints[i].color = _noAlphaColor;
        }
        
       
        _counter = 0;
        //Debug.Log(_pickedIngridients.Count);
        Debug.Log("End of erase");
    }
    public void Serve()
    {
        _mxerScreen.SetActive(false);
        _servingScreen.SetActive(true);
    }
}
