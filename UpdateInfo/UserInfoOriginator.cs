namespace UpdateInfo
{
    class UserInfoOriginator
    {
        public UserInfo State { get; set; } // state

        public void Undo(UserInfoMemento memento)
        {
            State = memento.State;
        }

        public UserInfoMemento Save()
        {
            return new UserInfoMemento(State);
        }
    }
}
