using System;
using UnityEngine;
using static UnityEngine.Mathf;


namespace NebusokuDev.Smith.Runtime.Camera
{
    [Serializable]
    public class FieldOfView
    {
        [SerializeField] private float vertical;

        public float Vertical
        {
            get => vertical;
            set => vertical = Abs(value);
        }

        public float Horizontal
        {
            get => CalcHorizontalFOV(Vertical, Aspect);
            set => Vertical = CalcVerticalFOV(Clamp(value, 1f, 180f), Aspect);
        }

        private float CalcHorizontalFOV(float verticalFOV, float aspect)
        {
            return Atan(Tan(verticalFOV / 2f * Deg2Rad) * aspect) * 2f * Rad2Deg;
        }

        private float CalcVerticalFOV(float horizontalFOV, float aspect)
        {
            return Atan(Tan(horizontalFOV / 2f * Deg2Rad) / aspect) * 2f * Rad2Deg;
        }

        private float Aspect => (float) Screen.width / Screen.height;
    }
}