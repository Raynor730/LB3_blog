
using System.ComponentModel;
using LB3_blog.Models;
using Microsoft.EntityFrameworkCore;

namespace LB3_blog
{
    public partial class FormMain : Form
    {
        // создаЄтс€ экземпл€р контекста данных, который будет использовать
        // дл€ загрузки и отслеживани€ изменений о пользовател€х 
        private BlogContext? db;
        public FormMain()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db = new BlogContext();

            this.db.Users.Load();
            this.dataGridViewUsers.DataSource = db.Users.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void DataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (this.db != null)
            {
                var user = (User)this.dataGridViewUsers.CurrentRow.DataBoundItem;

                if (user != null)
                {
                    this.db.Entry(user).Collection(e => e.Posts).Load();
                }
            }
        }
    }
}
