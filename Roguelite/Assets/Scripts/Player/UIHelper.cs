using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHelper : MonoBehaviour
{
    [SerializeField] private Slider healthSlider;
    public Slider HealthSlider { get {  return healthSlider; } }
    [SerializeField] private Slider armorSlider;
    public Slider ArmorSlider { get { return armorSlider; } }
    [SerializeField] private GameObject gameOverMenu;
    public GameObject GameOverMenu { get {  return gameOverMenu; } }


}
