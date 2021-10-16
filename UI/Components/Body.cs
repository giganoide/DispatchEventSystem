using System;
using Events;
using UI.Abstract;

namespace UI.Components
{
    public class Body : Component
    {
        public Body(EventSystem eventSystem) : base(eventSystem)
        {
            EventSystem.On("Navbar-Header-Change", (o) => ShowText((string)o));
        }

        public void ShowText(string text)
        {
            Console.WriteLine("Body -> Navbar header was changed to {0}", text);
        }
    }
}