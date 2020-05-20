using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiseñoTres
{
    /// <summary>
    /// Lógica de interacción para FormPerson.xaml
    /// </summary>
    public partial class FormPerson : Page
    {
        public int id_Carpetas = 0;
        public FormPerson(int id_Carpetas = 0)
        {
            InitializeComponent();

            this.id_Carpetas = id_Carpetas;
            if (this.id_Carpetas != 0)
            {
                using (Model.polyuprotecEntities1 db = new Model.polyuprotecEntities1())
                {
                    var oCarpeta = db.Carpeta.Find(this.id_Carpetas);

                    documento.Text = oCarpeta.id_Carpetas.ToString();
                    Nombre.Text = oCarpeta.Nombre;
                    Estado.Text = oCarpeta.Estado;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (id_Carpetas == 0)
            {
                using (Model.polyuprotecEntities1 db = new Model.polyuprotecEntities1())
                {
                    var oCarpeta = new Model.Carpeta();
                    oCarpeta.id_Carpetas = int.Parse(documento.Text);
                    oCarpeta.Nombre = Nombre.Text;
                    oCarpeta.Estado = Estado.Text;

                    db.Carpeta.Add(oCarpeta);
                    db.SaveChanges();

                    Usuario.StaticMainFrame.Content = new ListaPersonal();
                }
            }
            else
            {
                using (Model.polyuprotecEntities1 db = new Model.polyuprotecEntities1())
                {
                    var oCarpeta = db.Carpeta.Find(id_Carpetas);
                    oCarpeta.id_Carpetas = int.Parse(documento.Text);
                    oCarpeta.Nombre = Nombre.Text;
                    oCarpeta.Estado = Estado.Text;

                    db.Entry(oCarpeta).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    Usuario.StaticMainFrame.Content = new ListaPersonal();
                }
            }
                
        }
    }
}
