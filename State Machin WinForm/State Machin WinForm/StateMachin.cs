using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Machin_WinForm
{
    public abstract class StateMachin
    {
        protected int currentState;
        protected Dictionary<int, Dictionary<int, int>> transitionTable;

        public abstract void PerformAction(int input);

        public int CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }

        public void GetProduct(int price)
        {
            if (currentState >= price)
            {
                currentState -= price;
            }
        }

        public void Transition(int input)
        {
            Dictionary<int, int> transition;

            if (transitionTable.TryGetValue(currentState, out transition))
            {
                int newState;
                if (transition.TryGetValue(input, out newState))
                {
                    currentState = newState;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            else
            {

                Console.WriteLine("Invalid");
            }
        }
    }
}
