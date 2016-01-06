namespace StatePattern
{
    interface IState
    {
        
        void OnEnter( Actor test);
        void OnExit( Actor test);
        void OnTick( Actor test);
    }
}
