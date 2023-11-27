
namespace Informes
{
    partial class Form1
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enemigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviliarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enemigoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enemigoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.idToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaDeTamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 28);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 422);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem,
            this.gráficosToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.informaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enemigoToolStripMenuItem,
            this.moviliarioToolStripMenuItem,
            this.objetosToolStripMenuItem,
            this.habitacionesToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // enemigoToolStripMenuItem
            // 
            this.enemigoToolStripMenuItem.Name = "enemigoToolStripMenuItem";
            this.enemigoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.enemigoToolStripMenuItem.Text = "Enemigos";
            this.enemigoToolStripMenuItem.Click += new System.EventHandler(this.enemigoToolStripMenuItem_Click);
            // 
            // moviliarioToolStripMenuItem
            // 
            this.moviliarioToolStripMenuItem.Name = "moviliarioToolStripMenuItem";
            this.moviliarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.moviliarioToolStripMenuItem.Text = "Moviliario";
            this.moviliarioToolStripMenuItem.Click += new System.EventHandler(this.moviliarioToolStripMenuItem_Click);
            // 
            // objetosToolStripMenuItem
            // 
            this.objetosToolStripMenuItem.Name = "objetosToolStripMenuItem";
            this.objetosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.objetosToolStripMenuItem.Text = "Objetos";
            this.objetosToolStripMenuItem.Click += new System.EventHandler(this.objetosToolStripMenuItem_Click);
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            this.habitacionesToolStripMenuItem.Click += new System.EventHandler(this.habitacionesToolStripMenuItem_Click);
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circularesToolStripMenuItem});
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.gráficosToolStripMenuItem.Text = "Gráficos";
            // 
            // circularesToolStripMenuItem
            // 
            this.circularesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enemigoToolStripMenuItem1});
            this.circularesToolStripMenuItem.Name = "circularesToolStripMenuItem";
            this.circularesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.circularesToolStripMenuItem.Text = "Circulares";
            // 
            // enemigoToolStripMenuItem1
            // 
            this.enemigoToolStripMenuItem1.Name = "enemigoToolStripMenuItem1";
            this.enemigoToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.enemigoToolStripMenuItem1.Text = "Enemigos";
            this.enemigoToolStripMenuItem1.Click += new System.EventHandler(this.enemigoToolStripMenuItem1_Click);
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enemigoToolStripMenuItem2});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // enemigoToolStripMenuItem2
            // 
            this.enemigoToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idToolStripMenuItem,
            this.nombreToolStripMenuItem});
            this.enemigoToolStripMenuItem2.Name = "enemigoToolStripMenuItem2";
            this.enemigoToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.enemigoToolStripMenuItem2.Text = "Enemigo";
            // 
            // idToolStripMenuItem
            // 
            this.idToolStripMenuItem.Name = "idToolStripMenuItem";
            this.idToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.idToolStripMenuItem.Text = "Id";
            this.idToolStripMenuItem.Click += new System.EventHandler(this.idToolStripMenuItem_Click);
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nombreToolStripMenuItem.Text = "Nombre";
            this.nombreToolStripMenuItem.Click += new System.EventHandler(this.nombreToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitacionesToolStripMenuItem1,
            this.objetosToolStripMenuItem1});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // habitacionesToolStripMenuItem1
            // 
            this.habitacionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaDeTamañoToolStripMenuItem});
            this.habitacionesToolStripMenuItem1.Name = "habitacionesToolStripMenuItem1";
            this.habitacionesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.habitacionesToolStripMenuItem1.Text = "Habitaciones";
            // 
            // mediaDeTamañoToolStripMenuItem
            // 
            this.mediaDeTamañoToolStripMenuItem.Name = "mediaDeTamañoToolStripMenuItem";
            this.mediaDeTamañoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mediaDeTamañoToolStripMenuItem.Text = "Media de Tamaño";
            this.mediaDeTamañoToolStripMenuItem.Click += new System.EventHandler(this.mediaDeTamañoToolStripMenuItem_Click_1);
            // 
            // objetosToolStripMenuItem1
            // 
            this.objetosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadToolStripMenuItem});
            this.objetosToolStripMenuItem1.Name = "objetosToolStripMenuItem1";
            this.objetosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.objetosToolStripMenuItem1.Text = "Objetos";
            // 
            // cantidadToolStripMenuItem
            // 
            this.cantidadToolStripMenuItem.Name = "cantidadToolStripMenuItem";
            this.cantidadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cantidadToolStripMenuItem.Text = "Cantidad";
            this.cantidadToolStripMenuItem.Click += new System.EventHandler(this.cantidadToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enemigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviliarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enemigoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enemigoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mediaDeTamañoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cantidadToolStripMenuItem;
    }
}