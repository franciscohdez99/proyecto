using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Line.CONTROLADOR
{
    class CDialog_Eliminar
    {
        VISTA.VDialog_Eliminar vdialog_eliminar;

        public CDialog_Eliminar(VISTA.VDialog_Eliminar vdialog_eliminar)
        {
            this.vdialog_eliminar = vdialog_eliminar;
        }
        public void FormLoad()
        {
            this.vdialog_eliminar.btnEliminar.Click += btnEliminar_Click;
            this.vdialog_eliminar.btnCancelar.Click += btnCancelar_Click;
            this.vdialog_eliminar.btnCloseWindow.Click += btnCloseWindow_Click;
            this.vdialog_eliminar.txtID.IsReadOnly = true;
            this.vdialog_eliminar.txtNombre.IsReadOnly = true;
            this.vdialog_eliminar.ShowDialog();
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.vdialog_eliminar.Close();
        }
        private void btnCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.vdialog_eliminar.Close();
        }
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            this.vdialog_eliminar.DialogResult = true;
        }
    }
}
