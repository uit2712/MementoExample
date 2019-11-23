namespace UpdateInfo
{
    class UserInfoOriginator
    {
        public UserInfo State { get; set; } // state

        public void SetMemento(UserInfoMemento memento)
        {
            State = memento.State;
        }

        public UserInfoMemento CreateMemento()
        {
            return new UserInfoMemento(State);
        }
    }
}
