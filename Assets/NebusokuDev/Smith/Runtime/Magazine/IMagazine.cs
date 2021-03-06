using NebusokuDev.Smith.Runtime.AmmoHolder;

namespace NebusokuDev.Smith.Runtime.Magazine
{
    public interface IMagazine
    {
        public IAmmoHolder AmmoHolder { get; set; }
        public uint Capacity { get; }
        public uint Reaming { get; }
        public bool UseAmmo(uint useAmount);
        public bool IsReloading { get; }


        public void Reload();
        public void ReloadCancel();
    }
}