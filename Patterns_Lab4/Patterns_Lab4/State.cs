using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns_Lab4
{
    abstract class State
    {
        protected string stateName;
        abstract public void Working();
    }

    class WorkingState : State
    {
        public WorkingState()
        {
            stateName = "Working";
        }

        override public void Working()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Launching automat ...");
            Thread.Sleep(1000);
            Console.WriteLine("Automat is working now!");
            Console.WriteLine("----------------------");
        }
    }

    class IdlenessState : State
    {
        public IdlenessState()
        {
            stateName = "Idleness";
        }

        override public void Working()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Stopping automat ...");
            Thread.Sleep(1000);
            Console.WriteLine("Automat is idleness now!");
            Console.WriteLine("----------------------");
        }
    }

    class ContextAutomat
    {
        public enum AutomatStateSetting { Working, Idleness };

        WorkingState wkst = new WorkingState();
        IdlenessState idlnst = new IdlenessState();

        private State CurrentState;

        public ContextAutomat()
        {
            CurrentState = idlnst;
        }

        public void SetState(AutomatStateSetting newState)
        {
            if (newState == AutomatStateSetting.Idleness) CurrentState = idlnst;
            else CurrentState = wkst;
        }

        public void Working()
        {
            CurrentState.Working();
        }
    }
}
