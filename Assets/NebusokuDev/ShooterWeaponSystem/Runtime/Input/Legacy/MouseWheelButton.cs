﻿using System;
using UnityEngine;


namespace NebusokuDev.ShooterWeaponSystem.Runtime.Input.Legacy
{
    [Serializable]
    public class MouseWheelButton : IInputButton
    {
        public bool IsPressDown => Mathf.Abs(UnityEngine.Input.mouseScrollDelta.x) < 0.1f;
        public bool IsPressUp => Mathf.Abs(UnityEngine.Input.mouseScrollDelta.x) > 0f;
        public bool IsPressed => Mathf.Abs(UnityEngine.Input.mouseScrollDelta.x) > 0f;
    }
}