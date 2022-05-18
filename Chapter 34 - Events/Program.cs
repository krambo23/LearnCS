using System;

namespace SimpleEvent
{
    public class EventTest
    {
        private int value;
        public delegate void NumManipulationHandler();
        public event NumManipulationHandler ChangeNum;

        public EventTest(int n)
        {
            SetValue(n);
        }
        
        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                System.Console.WriteLine("Event Fired!");
            }
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            EventTest eventTest = new EventTest(5);
            eventTest.SetValue(7);
            eventTest.SetValue(11);
        }
    }
}
// pg 272, 273, 274