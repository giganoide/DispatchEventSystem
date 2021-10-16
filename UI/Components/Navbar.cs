using System;
using Events;
using UI.Abstract;

namespace UI.Components
{
    public class Navbar : Component
    {

        private string _header;
        public string Header
        {
            get
            {
                return _header;
            }
            set
            {
                _header = value;
                Console.WriteLine("Navbar -> Header is changed to {0}", _header);
                EventSystem.Dispatch("Navbar-Header-Change", _header);
            }
        }

        public Navbar(EventSystem eventSystem) : base(eventSystem)
        {
        }
    }
}