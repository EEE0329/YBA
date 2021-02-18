using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack; 

namespace WindowsFormsApp1
{
    public partial class Consultar_RNC : Form
    {
        public Consultar_RNC()
        {
            InitializeComponent();
        }

        WebBrowser navegador = new WebBrowser();
        private void iconButton1_Click(object sender, EventArgs e)
        {
           
            //navegador.Navigate("www.dgii.gov.do/app/WebApps/ConsultasWeb/consultas/rnc.aspx#");
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(datos_cargados);
           // if(navegador.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler())
            webBrowser1.Document.GetElementById("ctl00_cphMain_txtRNCCedula").SetAttribute("value", txtRNC.Text);
            webBrowser1.Document.GetElementById("ctl00_cphMain_btnBuscarPorRNC").InvokeMember("click");
           

        }
        private void Consultar_RNC_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("www.dgii.gov.do/app/WebApps/ConsultasWeb/consultas/rnc.aspx#");
            //navegador.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.datos_cargados);
            List<string> milista = new List<string>();
            //milista =
             

        }

        private void datos_cargados(object sender, EventArgs e)
        {
            List<string> milista = new List<string>();

            foreach (HtmlElement td in webBrowser1.Document.All)
            {
                milista.Add(td.GetAttribute("classname").Contains("table table - bordered table - striped").ToString());
            }


        }

        

        
    }
}
