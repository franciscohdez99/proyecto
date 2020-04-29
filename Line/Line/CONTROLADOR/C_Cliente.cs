using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Windows.Controls.Primitives;
//using Line.VISTA;
//using Line.MODELO;

namespace Line.CONTROLADOR
{
    class C_Cliente
    {
        VISTA.V_Cliente vcliente;
        MODELO.VO_Cliente vocliente;
        MODELO.DAO_Cliente daocliente;

        public C_Cliente(VISTA.V_Cliente vcliente)
        {
            this.vcliente = vcliente;
            vocliente = new MODELO.VO_Cliente();
            daocliente = new MODELO.DAO_Cliente();
            daocliente.abrirConexion();
            Reload();

        }
        public void FormLoad()
        {
            vcliente.Topmost = false;
            this.vcliente.Visibility = Visibility.Visible;
            this.vcliente.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.vcliente.txtBuscar.TextChanged += Buscar_Click;
            this.vcliente.btnNuevo.Click += Nuevo_Click;
            this.vcliente.btnEditar.Click += Editar_Click;
            this.vcliente.btnEliminar.Click += Eliminar_Click;
            this.vcliente.btnCloseWindow.Click += CloseWindow_Click;
            //this.vcliente.DgvPlantilla.MouseDoubleClick += DgvPlantilla_Click;
            //this.vcliente.DgvPlantilla.MouseUp += DgvPlantilla_MouseUp;

        }
        private void Buscar_Click(object sender, TextChangedEventArgs e)
        {
            this.vcliente.DgvPlantilla.DataContext = daocliente.ConsultaLike(vcliente.txtBuscar);
        }
        private void Nuevo_Click(object sender, RoutedEventArgs e)
        {
            VISTA.VDialog_Cliente vdialog = new VISTA.VDialog_Cliente();
            C_DialogCliente cdialog = new C_DialogCliente(vdialog);
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, false);
                if (daocliente.Insertar().Equals(1))
                {
                    MessageBox.Show(":)");
                    Reload();
                }
                else
                {
                    MessageBox.Show(":(");
                }
            }
        }
        private void getDatos(VISTA.VDialog_Cliente vdialog, bool edit)
        {
            if (edit == false)
            {
                this.vocliente.IDCLIENTE = 0;
            }
            else
                this.vocliente.IDCLIENTE = int.Parse(vdialog.txtIDCliente.Text);
            this.vocliente.NOMBRECLIENTE = vdialog.txtNombreCliente.Text;
            this.vocliente.APATERNO = vdialog.txtApaterno.Text;
            this.vocliente.AMATERNO = vdialog.txtAmaterno.Text;
            this.vocliente.NUMEROTELEFONO =long.Parse(vdialog.txtNoTelefono.Text);
            this.vocliente.EMAIL = vdialog.txtEmail.Text;
            this.daocliente = new MODELO.DAO_Cliente(vocliente);
        }
        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vcliente.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Cliente vdialog = new VISTA.VDialog_Cliente();
            C_DialogCliente cdialog = new C_DialogCliente(vdialog);
            vdialog.txtIDCliente.Text = Rows.Row[0].ToString();
            vdialog.txtNombreCliente.Text = Rows.Row[1].ToString();
            vdialog.txtApaterno.Text = Rows.Row[2].ToString();
            vdialog.txtAmaterno.Text = Rows.Row[3].ToString();
            vdialog.txtNoTelefono.Text = Rows.Row[4].ToString();
            vdialog.txtEmail.Text = Rows.Row[5].ToString();
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, true);
                if (daocliente.Editar().Equals(1))
                {
                    MessageBox.Show(":)");
                    Reload();
                }
                else
                    MessageBox.Show(":(");
            }
        }
        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vcliente.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Eliminar vdialog = new VISTA.VDialog_Eliminar();
            CDialog_Eliminar cdialog = new CDialog_Eliminar(vdialog);
            vdialog.txtID.Text = Rows.Row[0].ToString();
            vdialog.txtNombre.Text = Rows.Row[1].ToString();
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDataCopy(vdialog, true);
                if (daocliente.Eliminar().Equals(1))
                {
                    MessageBox.Show("¿Deseas eliminar el registro?");
                    Reload();
                }
            }
        }
        public void getDataCopy(VISTA.VDialog_Eliminar vdialog, bool edit)
        {
            if (edit == false)
            {
                this.vocliente.IDCLIENTE = 0;
            }
            else
                this.vocliente.IDCLIENTE = int.Parse(vdialog.txtID.Text);
            this.daocliente = new MODELO.DAO_Cliente(vocliente);
        }
        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.vcliente.Close();
        }
        

        public void Reload()
        {
            this.vcliente.DgvPlantilla.DataContext = daocliente.consulta();
            //this.vcliente.btnEditar.IsEnabled = false;
            //this.vcliente.btnEliminar.IsEnabled = false;
        }
    }
}
