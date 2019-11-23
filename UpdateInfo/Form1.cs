using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private UserInfoCaretaker _caretaker = new UserInfoCaretaker();
        private UserInfoOriginator _originator = new UserInfoOriginator();

        private void btnSave_Click(object sender, EventArgs e)
        {
            _originator.State = new UserInfo(txtName.Text, (int)nudAge.Value, cbbGender.Text, cbbJob.Text, txtAddress.Text);
            _caretaker.Save(_originator);
            MessageBox.Show("Đã lưu!", "Lưu");
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            _caretaker.Undo(_originator);
            UserInfo userInfo = _originator.State;
            txtName.Text = userInfo.Name;
            nudAge.Value = userInfo.Age;
            cbbGender.SelectedItem = userInfo.Gender;
            cbbJob.SelectedItem = userInfo.Job;
            txtAddress.Text = userInfo.Address;
        }
    }
}
