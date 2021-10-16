using Events;

namespace UI.Abstract
{
    public abstract class Component
    {
        protected readonly EventSystem EventSystem;

        public Component(EventSystem eventSystem)
        {
            EventSystem = eventSystem;
        }
    }
}