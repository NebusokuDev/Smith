using NebusokuDev.Smith.Runtime.Input.Legacy.Button;
using NebusokuDev.Smith.Runtime.Sequence.Timer;
using UnityEngine;
using UnityEngine.Events;

public class EventSource : MonoBehaviour
{
    [SerializeReference] private IRpmTimer _timer = new FixedRpmTimer();
    [SerializeReference] private IInputButton _button = new InputButtons(KeyCode.Mouse0);

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