using System;
using System.Windows.Forms;
using System.ComponentModel;
using Project_Klp_9.Models;
using Project_Klp_9.Presenter;
using Project_Klp_9.Views;

namespace Project_Klp_9
{
    public partial class LoginForm : Form, IView
    {
        private LoginPresenters presenter;

        public LoginForm()
        {
            InitializeComponent();

            UserRepository repo = new UserRepository();
            presenter = new LoginPresenters(this, repo);

            button1.Click += delegate {
                LoginEvent?.Invoke(this, EventArgs.Empty);
                ShowResult();
            };
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string users
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Password
        {
            get => txt_Password.Text;
            set => txt_Password.Text = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string role
        {
            get => comboBox1.Text;
            set => comboBox1.Text = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Message { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool isLoginSuccesful { get; set; }

        public event EventHandler LoginEvent;

        public void ShowResult()
        {
            if (isLoginSuccesful)
            {
                MessageBox.Show(Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dashboard mainForm = new dashboard();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}