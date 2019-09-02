namespace UpdateInfo
{
    class UserInfoMemento
    {
        public UserInfoMemento(UserInfo state)
        {
            State = state;
        }

        public UserInfo State { get; set; }
    }
}
