using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateMachine : StateMachine
{
    [SerializeField] private InputActionAsset inputActionAsset;
    public InputActionAsset InputActionAsset{ get { return inputActionAsset; } }
    private PlayerStatistics playerStats;
    public PlayerStatistics PlayerStats  { get { return playerStats; } }

    private Weapon weapon;
    public Weapon Weapon { get { return weapon; } }

    private void Awake()
    {
        playerStats = GetComponent<PlayerStatistics>();
        weapon = GetComponentInChildren<Weapon>();
        GameManager.Instance.player = this;
    }
}
