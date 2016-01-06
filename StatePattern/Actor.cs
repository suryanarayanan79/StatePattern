using System;

namespace StatePattern
{
    class Actor
    {
         /// <summary>
         /// Actor Class current State.
         /// </summary>
         IState currentState;
        public string name { get; set; }
        public Actor()
        {
            currentState = new ActorJump();
            currentState.OnEnter( this);
        }

      public  void ChangeState(IState toState)
        {
            if(currentState != toState)
            {
                currentState.OnExit(this);
                currentState = toState;
                currentState.OnEnter(this);
            }
        }
       public IState GetCurrentState()
        {
            return currentState;
        }

        public void Update()
        {
            currentState.OnTick(this);
            while (Console.ReadKey(true).Key == ConsoleKey.Spacebar) 
            {
                while (!Console.KeyAvailable)
                {
                    ChangeState(new ActorWalk());
                }
            } 
        }

        public override string ToString()
        {
            return "Actor Class instance" + GetHashCode();
        }
    }
}
