using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    [Inject] private IWeaponService _weapon;

    public void Start()
    {
        _weapon.Setup();

        Debug.Log($"Player weapon: {_weapon.GetHashCode()}");
    }
}
