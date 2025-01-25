using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Enemy : MonoBehaviour
{
    [Inject] private IWeaponService _weapon;

    public void Start()
    {
        _weapon.Setup();

        Debug.Log($"Enemy weapon: {_weapon.GetHashCode()}");
    }
}
