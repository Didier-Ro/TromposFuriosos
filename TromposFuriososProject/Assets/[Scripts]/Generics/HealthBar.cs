using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider = default;
    [SerializeField] private Health _health = default;

    private void Awake()
    {
        _healthSlider.maxValue = _health.CurrentHealth;
        _healthSlider.value = _health.CurrentHealth;
    }

    public void UpdateSliderValue(int newValue)
    {
        _healthSlider.value = newValue;
    }
}
