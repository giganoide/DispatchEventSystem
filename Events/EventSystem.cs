using System;

namespace Events
{
    public abstract class EventSystem
    {
        public abstract void On(string eventName, Action<object> function);
        public abstract void Off(string eventName, Action<object> function);
        public abstract void Dispatch(string eventName, object eventData);
    }
}