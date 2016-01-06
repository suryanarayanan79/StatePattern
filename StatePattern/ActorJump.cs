namespace StatePattern
{
    class ActorJump : IState
    {
       public ActorJump()
        {
            System.Console.WriteLine("Actor Jump Constructed");
        }
        public void OnEnter( Actor test)
        {
            test.name = "Jumping";
            System.Console.WriteLine("Actor Jump Entered");
        }

        public void OnExit( Actor test)
        {
            test.name = "Jumping OnExit";
            System.Console.WriteLine("Actor Jump Exited");
        }

        public void OnTick( Actor test)
        {
            test.name = "Jumping " + "Tick";
            System.Console.WriteLine("Actor Jump Tick");
        }
    }
}
