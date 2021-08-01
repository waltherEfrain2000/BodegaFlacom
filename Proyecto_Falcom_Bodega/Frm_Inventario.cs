﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Falcom_Bodega
{
    public partial class Frm_Inventario : Form
    {

        Conexion conexion = new Conexion();

        public Frm_Inventario()
        {
            InitializeComponent();
        }

        private void Frm_Inventario_Load(object sender, EventArgs e)
        {
            conexion.Busquedas1("Select * from Producto", dataGridView1);
            conexion.Busquedas1(@"Select p.codigoInventario as 'Codigo Inventario',p.codigoProducto as 'Codigo Producto', v.nombreproducto ,p.[cantidad],
p.[fechaIngreso],p.[fechaCaducidad],p.[duracionPromedio] from [Inventario] as p
inner join Producto as v on v.codigoProducto= p.codigoProducto", dataGridView2);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy'-'MM'-'dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy'-'MM'-'dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy'-'MM'-'dd";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodProducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtnomProducto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Al parecer a ocurrido un error vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtcantidad.Text == "" || txtcodProducto.Text == " " )
            {

                MessageBox.Show("Algunos campos estan vacios, Favor revisar si selecciono el producto y que las casillas esten llenas", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            else
            {

                try
                {
                    decimal cantidad;
                    int codpro;
                    string fechaingreso, fechapodrido, duracion;

                    cantidad = Convert.ToDecimal(txtcantidad.Text);
                    codpro = Convert.ToInt32(txtcodProducto.Text);
                    fechaingreso = dateTimePicker1.Text.ToString();
                    fechapodrido = dateTimePicker2.Text.ToString();
                    duracion = dateTimePicker3.Text.ToString();


                    conexion.Modificaciones("Insert into Inventario values('" + codpro + "','" + cantidad + "','" + fechaingreso + "','" + fechapodrido + "','" + duracion + "' ) ");
                    //conexion.Modificaciones("Insert into Inventario values('" + txtcantidad.Text + "','" + txtcodProducto.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "' ) ");

                }
                catch (Exception)
                {

                    MessageBox.Show("Ha ocurrido un error , revise los campos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Se ha Insertado el producto correctamente", "Se ingreso el valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Busquedas1("Select * from Producto", dataGridView1);
                    conexion.Busquedas1(@"Select p.codigoInventario as 'Codigo Inventario',p.codigoProducto as 'Codigo Producto', v.nombreproducto ,p.[cantidad],
p.[fechaIngreso],p.[fechaCaducidad],p.[duracionPromedio] from [Inventario] as p
inner join Producto as v on v.codigoProducto= p.codigoProducto", dataGridView2);
                    LimpiarCasillas();
                }
            }



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        public void LimpiarCasillas()
        {
            txtcodProducto.Text = "";
            txtcodinventario.Text = "";
            txtnomProducto.Text = "";
            txtcantidad.Text = "";
            btnInsertar.Enabled = true;
            btneliminar.Enabled = true;
            btnmodificar.Enabled = true;
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            dateTimePicker3.Text = "";


        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodinventario.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtcodProducto.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtnomProducto.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtcantidad.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker2.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                dateTimePicker3.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                btnInsertar.Enabled = false;
                txtcodinventario.Enabled = false;
                txtnomProducto.Enabled = false;
                txtcodProducto.Enabled = false;

            }
            catch (Exception)
            {

                MessageBox.Show("Al parecer a ocurrido un error vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcodinventario.Text == "")
            {
                MessageBox.Show("Asegurese de seleccionar un producto de el listado de abajo para poder modificar un producto", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    decimal cantidad;
                    int codpro, codinventario;
                    string fechaingreso, fechapodrido, duracion;
                    codinventario = Convert.ToInt32(txtcodinventario.Text);
                    cantidad = Convert.ToDecimal(txtcantidad.Text);
                    codpro = Convert.ToInt32(txtcodProducto.Text);
                    fechaingreso = dateTimePicker1.Text.ToString();
                    fechapodrido = dateTimePicker2.Text.ToString();
                    duracion = dateTimePicker3.Text.ToString();


                    conexion.Modificaciones("Update Inventario Set codigoProducto ='" + codpro + "',cantidad='" + cantidad + "', fechaIngreso='" + fechaingreso + "',fechaCaducidad='" + fechapodrido + "',duracionPromedio='" + duracion + "' where codigoInventario= '" + codinventario + "'");
                    //conexion.Modificaciones("Insert into Inventario values('" + txtcantidad.Text + "','" + txtcodProducto.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "' ) ");
                }
                catch (Exception)
                {

                    MessageBox.Show("Al parecer ha ocurrido un error al momento de modificar el product, favor revisar datos y casillas", "Error al modificar producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Se ha Modificado el producto correctamente", "Se ingreso el valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Busquedas1("Select * from Producto", dataGridView1);
                    conexion.Busquedas1(@"Select p.codigoInventario as 'Codigo Inventario',p.codigoProducto as 'Codigo Producto', v.nombreproducto ,p.[cantidad],
p.[fechaIngreso],p.[fechaCaducidad],p.[duracionPromedio] from [Inventario] as p
inner join Producto as v on v.codigoProducto= p.codigoProducto", dataGridView2);
                    LimpiarCasillas();
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtcodinventario.Text == "")
            {
                MessageBox.Show("Asegurese de seleccionar un producto de el listado de abajo para poder eliminar un producto", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    decimal cantidad;
                    int codpro, codinventario;
                    string fechaingreso, fechapodrido, duracion;
                    codinventario = Convert.ToInt32(txtcodinventario.Text);
                    cantidad = Convert.ToDecimal(txtcantidad.Text);
                    codpro = Convert.ToInt32(txtcodProducto.Text);
                    fechaingreso = dateTimePicker1.Text.ToString();
                    fechapodrido = dateTimePicker2.Text.ToString();
                    duracion = dateTimePicker3.Text.ToString();


                    conexion.Modificaciones(" Delete from Inventario where codigoInventario= '" + codinventario + "'");
                    //conexion.Modificaciones("Insert into Inventario values('" + txtcantidad.Text + "','" + txtcodProducto.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "' ) ");
                }
                catch (Exception)
                {

                    MessageBox.Show("Al parecer ha ocurrido un error al momento de Eliminar el producto, favor revisar datos y casillas", "Error al modificar producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Se ha Eliminado el producto correctamente", "Se ingreso el valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Busquedas1("Select * from Producto", dataGridView1);
                    conexion.Busquedas1(@"Select p.codigoInventario as 'Codigo Inventario',p.codigoProducto as 'Codigo Producto', v.nombreproducto ,p.[cantidad],
p.[fechaIngreso],p.[fechaCaducidad],p.[duracionPromedio] from [Inventario] as p
inner join Producto as v on v.codigoProducto= p.codigoProducto", dataGridView2);
                    LimpiarCasillas();
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }
    }
}