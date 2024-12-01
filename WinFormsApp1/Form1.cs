using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Lista para almacenar los contactos
        private List<Contact> contacts;

        public Form1()
        {
            InitializeComponent();
            contacts = new List<Contact>();
        }

        // Método para validar que el teléfono tiene 11 dígitos y solo números
        private bool CheckPhone(string phone)
        {
            if (phone.Length != 11 || !long.TryParse(phone, out _))
            {
                MessageBox.Show("El número de teléfono debe tener 11 dígitos y ser solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Método para leer los datos de un contacto desde los TextBox
        private Contact ReadContact()
        {
            Contact contact = new Contact();
            contact.Name = txtName.Text;
            contact.Phone = txtPhone.Text;

            if (string.IsNullOrEmpty(contact.Name) || !CheckPhone(contact.Phone))
            {
                return null;
            }
            return contact;
        }

        // Método para mostrar los contactos en el ListBox
        private void DisplayContacts()
        {
            lstContacts.Items.Clear();
            foreach (var contact in contacts)
            {
                lstContacts.Items.Add($"{contact.Name} - {contact.Phone}");
            }
        }

        // Agregar un nuevo contacto
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Contact contact = ReadContact();
            if (contact != null)
            {
                contacts.Add(contact);
                DisplayContacts();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Por favor, introduce datos válidos para el contacto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Buscar un contacto por teléfono
        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            if (CheckPhone(phone))
            {
                Contact contact = contacts.Find(c => c.Phone == phone);
                if (contact != null)
                {
                    MessageBox.Show($"Contacto encontrado:\nNombre: {contact.Name}\nTeléfono: {contact.Phone}", "Contacto encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró un contacto con ese número de teléfono.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Actualizar un contacto
        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            Contact contact = ReadContact();
            if (contact != null)
            {
                int index = contacts.FindIndex(c => c.Phone == contact.Phone);
                if (index >= 0)
                {
                    contacts[index] = contact;
                    DisplayContacts();
                    ClearFields();
                    MessageBox.Show("Contacto actualizado correctamente.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el contacto para actualizar.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Eliminar un contacto
        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            if (CheckPhone(phone))
            {
                Contact contact = contacts.Find(c => c.Phone == phone);
                if (contact != null)
                {
                    contacts.Remove(contact);
                    DisplayContacts();
                    ClearFields();
                    MessageBox.Show("Contacto eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el contacto para eliminar.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Limpiar los campos del formulario
        private void ClearFields()
        {
            txtName.Clear();
            txtPhone.Clear();
        }
    }
}