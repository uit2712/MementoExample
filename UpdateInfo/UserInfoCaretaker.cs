namespace UpdateInfo
{
    class UserInfoCaretaker
    {
        private UserInfoMemento _memeto;

        public void Save(UserInfoOriginator originator)
        {
            _memeto = originator.Save();
        }

        public void Undo(UserInfoOriginator originator)
        {
            originator.Undo(_memeto);
        }
    }
}
