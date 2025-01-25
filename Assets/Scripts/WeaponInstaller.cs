using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using Zenject;

public class WeaponInstaller : MonoInstaller
{
    [SerializeField] private WeaponType _type = WeaponType.Pistol;

    public override void InstallBindings()
    {
        var type = GetWeaponType();

        Container.Bind<IWeaponService>()
            .To(type)
            .AsTransient();
    }

    private Type GetWeaponType()
    {
        return Type.GetType(_type.ToString());
    }
}