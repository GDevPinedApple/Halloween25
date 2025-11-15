using UnityEngine;
using UnityEngine.Events;

namespace EventChannels
{
    public abstract class EventChannel : ScriptableObject
    {
        [TextArea(3, 10)]
        [SerializeField] private string _summary;

        public string Summary => _summary;

        public event UnityAction OnEventRaised;

        public void Raise() => OnEventRaised?.Invoke();

        private void OnEnable() => OnEventRaised = null;
        private void OnDisable() => OnEventRaised = null;
    }

    public abstract class EventChannel<T> : ScriptableObject
    {
        [TextArea(3, 10)]
        [SerializeField] private string _summary;
        [TextArea(1, 10)]
        [SerializeField] private string _parameter;

        public string Summary => _summary;
        public string Parameter => _parameter;

        public event UnityAction<T> OnEventRaised;

        public void Raise(T value) => OnEventRaised?.Invoke(value);

        private void OnEnable() => OnEventRaised = null;
        private void OnDisable() => OnEventRaised = null;
    }
}
