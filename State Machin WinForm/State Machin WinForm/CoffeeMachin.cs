using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Machin_WinForm
{
    public class CoffeeMachin : StateMachin
    {
        public CoffeeMachin()
        {
            currentState = 0;
            transitionTable = new Dictionary<int, Dictionary<int, int>>();

            transitionTable.Add(0, new Dictionary<int, int>()
                {
                    { 5, 5},
                    { 10, 10}
                });

            transitionTable.Add(5, new Dictionary<int, int>()
                {
                    { 5, 10},
                    { 10, 15}
                });

            transitionTable.Add(10, new Dictionary<int, int>()
                {
                    { 5, 15},
                    { 10, 20}
                });

            transitionTable.Add(15, new Dictionary<int, int>()
                {
                    { 5, 20},
                    { 10, 25}
                });

            transitionTable.Add(20, new Dictionary<int, int>()
                {
                    { 5, 25},
                    { 10, 30}
                });

            transitionTable.Add(25, new Dictionary<int, int>()
                {
                    { 5, 30},
                    { 10, 35}
                });

            transitionTable.Add(30, new Dictionary<int, int>()
                {
                    { 5, 30},
                    { 10, 40}
                });
        }

        public override void PerformAction(int action)
        {
            switch (action)
            {
                case 5:
                    Transition(action);
                    break;

                case 10:
                    Transition(action);
                    break;
            }
        }
    }
}
