using System;

namespace StatePattern
{
    class ActorWalk : IState
    {
       public ActorWalk()
        {
            Console.WriteLine("Actor Walk Entered");
        }

        public void OnEnter( Actor test)
        {
            Console.WriteLine("Actor Walk Entered");
        }

        public void OnExit( Actor test)
        {
            Console.WriteLine("Actor Walk Exited");
        }

        public void OnTick( Actor test)
        {
            Console.WriteLine("Actor Walk Tick");
        }
    }
}
