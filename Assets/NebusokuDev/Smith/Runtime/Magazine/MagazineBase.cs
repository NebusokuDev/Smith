﻿using System.Collections;
using NebusokuDev.Smith.Runtime.AmmoHolder;

namespace NebusokuDev.Smith.Runtime.Magazine
{
    public abstract class MagazineBase : IMagazine
    {
        public abstract IAmmoHolder AmmoHolder { get; set; }
        public abstract uint Capacity { get; }
        public abstract uint Reaming { get; }
        public abstract bool UseAmmo(uint useAmount);
        public abstract bool IsReloading { get; }
        public abstract IEnumerator ReloadCoroutine();
    }
}