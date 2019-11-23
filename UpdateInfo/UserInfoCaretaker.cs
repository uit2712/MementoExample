namespace UpdateInfo
{
    class UserInfoCaretaker
    {
        private UserInfoMemento _memeto;

        public void Save(UserInfoOriginator originator)
        {
            _memeto = originator.CreateMemento();
        }

        public void Undo(UserInfoOriginator originator)
        {
            originator.SetMemento(_memeto);
        }
    }
}
