using Events;
using UI.Components;

namespace UI
{
    public class Window
    {
        public readonly Navbar Navbar;
        public readonly Body Body;
        private readonly EventSystem _eventSystem;

        public Window()
        {
            _eventSystem = new DispatchEventSystem();
            Navbar = new Navbar(_eventSystem);
            Body = new Body(_eventSystem);
        }
    }
}