using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    [SerializeField] private GameObject glow;
    public GameObject Glow { get { return glow; } }
    [SerializeField] private Image itemIcon;
    public Image ItemIcon { get {  return itemIcon; } }
    [SerializeField] private WeaponSO weapon;
    private void Awake()
    {
        if(weapon != null)
        {
            AssignWeaponToSlot(weapon);
            itemIcon.gameObject.SetActive(true);
        }
    }
    public void ActivateSlot()
    {
        glow.SetActive(true);        
    }
    public void DeactivateSlot()
    {
        glow.SetActive(false);
    }
    public void AssignWeaponToSlot(WeaponSO weapon)
    {
        this.weapon = weapon;
        itemIcon.sprite = weapon.WeaponIconSprite;
    }
}
