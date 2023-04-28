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
using System.Windows.Shapes;

namespace pr4d
{
    /// <summary>
    /// Логика взаимодействия для add.xaml
    /// </summary>
    public partial class add : Window
    {
        NedvizhimostEntities db;

        public PropertyType PropertyTypes { get; private set; }
        public add(NedvizhimostEntities db, object PropertyType)
        {
            this.db = db;
            var a = PropertyType as PropertyType;
            if(a is PropertyType)
            {
                PropertyTypes = a;
                DataContext = PropertyTypes;
            }
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
