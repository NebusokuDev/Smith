using NebusokuDev.Smith.Runtime.Sequence.Timer;
using UnityEngine;
using UnityEngine.Events;
using IInputButton = NebusokuDev.Smith.Samples.StarterKit.Runtime.Input.Button.IInputButton;
using InputKeyButton = NebusokuDev.Smith.Samples.StarterKit.Runtime.Input.Button.InputKeyButton;

namespace NebusokuDev.Smith.Experimental
{
    public class EventSource : MonoBehaviour
    {
        [SerializeReference, SubclassSelector] private IRpmTimer _timer = new FixedRpmTimer();
        [SerializeReference, SubclassSelector] private IInputButton _button = new InputKeyButton(KeyCode.Mouse0);

        public UnityEvent overTime;

        // Update is called once per frame
        void Update()
        {
            _timer.Update();

            if ((_timer.IsOverTime && _button.IsPressed) == false) return;
            _timer.Lap();
            overTime.Invoke();
        }
    }
}