﻿
namespace Proyecto_Falcom_Bodega
{
    partial class VisualizacionReporteProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BodegaFalcomDataSet = new Proyecto_Falcom_Bodega.BodegaFalcomDataSet();
            this.ReporteProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteProductoTableAdapter = new Proyecto_Falcom_Bodega.BodegaFalcomDataSetTableAdapters.ReporteProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BodegaFalcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Falcom_Bodega.ReporteProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // BodegaFalcomDataSet
            // 
            this.BodegaFalcomDataSet.DataSetName = "BodegaFalcomDataSet";
            this.BodegaFalcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteProductoBindingSource
            // 
            this.ReporteProductoBindingSource.DataMember = "ReporteProducto";
            this.ReporteProductoBindingSource.DataSource = this.BodegaFalcomDataSet;
            // 
            // ReporteProductoTableAdapter
            // 
            this.ReporteProductoTableAdapter.ClearBeforeFill = true;
            // 
            // VisualizacionReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VisualizacionReporteProducto";
            this.Text = "VisualizacionReporteProducto";
            this.Load += new System.EventHandler(this.VisualizacionReporteProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BodegaFalcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteProductoBindingSource;
        private BodegaFalcomDataSet BodegaFalcomDataSet;
        private BodegaFalcomDataSetTableAdapters.ReporteProductoTableAdapter ReporteProductoTableAdapter;
    }
}