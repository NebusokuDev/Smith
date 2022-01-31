﻿using System;
using UnityEngine;

namespace NebusokuDev.Smith.Runtime.ProceduralAnimation.KickbackAnimation
{
    public class ProceduralKickbackAnimation : MonoBehaviour, IProceduralAnimation
    {
        [SerializeField] private KickbackBase config;

        [SerializeField, Range(Single.Epsilon, 6000f)]
        private float duration = 50f;

        private Transform _self;

        private Vector3 _kickbackOffsetPoint;
        private Vector3 _kickbackRotation;
        private Vector3 _defaultPosition;
        private Quaternion _defaultRotation;

        private void Start()
        {
            _self = transform;
            _defaultPosition = _self.localPosition;
            _defaultRotation = _self.localRotation;
        }

        private void LateUpdate()
        {
            _kickbackOffsetPoint =
                Vector3.Lerp(_kickbackOffsetPoint, Vector3.zero, Time.deltaTime / (duration / 1000f));
            _kickbackRotation = Vector3.Slerp(_kickbackRotation, Vector3.zero, Time.deltaTime / (duration / 1000f));

            _self.localPosition = _defaultPosition + _kickbackOffsetPoint;
            _self.localRotation = _defaultRotation * Quaternion.Euler(_kickbackRotation);
        }

        public void Play()
        {
            var kickBack = config[0];
            _kickbackOffsetPoint += transform.localRotation * kickBack.position;
            _kickbackRotation += kickBack.rotate;
        }
    }
}