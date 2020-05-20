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
    /// Lógica de interacción para ListaPersonal.xaml
    /// </summary>
    public partial class ListaPersonal : Page
    {
        public ListaPersonal()
        {
            InitializeComponent();

            Refresh();
        }

        private void Refresh()
        {
            List<PersonViewModel> lst = new List<PersonViewModel>();
            using (Model.polyuprotecEntities1 db = new Model.polyuprotecEntities1())
            {
                lst = (from d in db.Carpeta
                       select new PersonViewModel
                       {
                           Nombre = d.Nombre,
                           Estado = d.Estado,
                           id_Carpetas = d.id_Carpetas
                       }).ToList();
            }

            DG.ItemsSource = lst;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Usuario.StaticMainFrame.Content = new FormPerson();
        }

        private void Button_Eliminar(object sender, RoutedEventArgs e)
        {
            int id_Carpetas = (int)((Button)sender).CommandParameter;

            using (Model.polyuprotecEntities1 db = new Model.polyuprotecEntities1())
            {
                var oCarpeta = db.Carpeta.Find(id_Carpetas);

                db.Carpeta.Remove(oCarpeta);
                db.SaveChanges();
            }

            Refresh();
        }

        private void Button_Editar(object sender, RoutedEventArgs e)
        {
            int id_Carpetas = (int)((Button)sender).CommandParameter;

            FormPerson pFormulario = new FormPerson(id_Carpetas);


            Usuario.StaticMainFrame.Content = pFormulario;


        }
    }

    public class PersonViewModel
    {
        public int id_Carpetas { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
    }
}
