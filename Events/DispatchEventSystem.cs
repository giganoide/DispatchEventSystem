using System;
using System.Collections.Generic;

namespace Events
{
    public class DispatchEventSystem : EventSystem
    {
        private Dictionary<string, List<Action<object>>> events { get; set; } = new();

        public override void On(string eventName, Action<object> function)
        {
            if (!events.TryGetValue(eventName, out var eventList))
            {
                eventList = events[eventName] = new List<Action<object>>();
            }

            eventList.Add(function);
        }

        public override void Off(string eventName, Action<object> function)
        {
            if (events.TryGetValue(eventName, out var eventList))
            {
                var index = eventList.IndexOf(function);
                if (index > -1)
                {
                    eventList.RemoveAt(index);
                }
            }
        }

        public override void Dispatch(string eventName,object eventData)
        {
            if (events.TryGetValue(eventName, out var eventList))
            {
                foreach (var action in eventList)
                {
                    action(eventData);
                }
            }
        }
    }
}