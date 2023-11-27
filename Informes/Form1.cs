using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Informes.reports;
using Informes.reports.gráficos;
using Informes.reports.filter;

namespace Informes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enemigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enemy enemy = new Enemy();
            crystalReportViewer1.ReportSource = enemy;
        }

        private void moviliarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Furniture furniture = new Furniture();
            crystalReportViewer1.ReportSource = furniture;
        }

        private void objetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Object_Inf object_Inf = new Object_Inf();
            crystalReportViewer1.ReportSource = object_Inf;
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            crystalReportViewer1.ReportSource = room;
        }

        private void enemigoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gEnemy gEnemy = new gEnemy();
            crystalReportViewer1.ReportSource = gEnemy;
        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltroPorNombreEnemy filtroPorNombreEnemy = new FiltroPorNombreEnemy();
            crystalReportViewer1.ReportSource = filtroPorNombreEnemy;
        }

        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltroPorIdEnemy filtroPorIdEnemy = new FiltroPorIdEnemy();
            crystalReportViewer1.ReportSource = filtroPorIdEnemy;
        }

        private void mediaDeTamañoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AVGRoom avgRoom = new AVGRoom();
            crystalReportViewer1.ReportSource = avgRoom;
        }

        private void cantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountObjetos countObjetos = new CountObjetos();
            crystalReportViewer1.ReportSource = countObjetos;
        }
    }
}
