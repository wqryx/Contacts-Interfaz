namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private TextBox txtPhone;
        private Button btnAddContact;
        private Button btnSearchContact;
        private Button btnUpdateContact;
        private Button btnDeleteContact;
        private ListBox lstContacts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtPhone = new TextBox();
            this.btnAddContact = new Button();
            this.btnSearchContact = new Button();
            this.btnUpdateContact = new Button();
            this.btnDeleteContact = new Button();
            this.lstContacts = new ListBox();
            this.SuspendLayout();

            // txtName
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(12, 38);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);

            // btnAddContact
            this.btnAddContact.Location = new System.Drawing.Point(12, 64);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(200, 30);
            this.btnAddContact.Text = "Agregar Contacto";
            this.btnAddContact.Click += new EventHandler(this.btnAddContact_Click);

            // btnSearchContact
            this.btnSearchContact.Location = new System.Drawing.Point(12, 100);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(200, 30);
            this.btnSearchContact.Text = "Buscar Contacto";
            this.btnSearchContact.Click += new EventHandler(this.btnSearchContact_Click);

            // btnUpdateContact
            this.btnUpdateContact.Location = new System.Drawing.Point(12, 136);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Size = new System.Drawing.Size(200, 30);
            this.btnUpdateContact.Text = "Actualizar Contacto";
            this.btnUpdateContact.Click += new EventHandler(this.btnUpdateContact_Click);

            // btnDeleteContact
            this.btnDeleteContact.Location = new System.Drawing.Point(12, 172);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(200, 30);
            this.btnDeleteContact.Text = "Eliminar Contacto";
            this.btnDeleteContact.Click += new EventHandler(this.btnDeleteContact_Click);

            // lstContacts
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(12, 208);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(200, 160);

            // Form1
            this.ClientSize = new System.Drawing.Size(224, 381);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnUpdateContact);
            this.Controls.Add(this.btnSearchContact);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}