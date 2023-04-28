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
    /// Логика взаимодействия для add1.xaml
    /// </summary>
        public partial class Add : Window
        {
            NedvizhimostEntities db;
            public Deal Deal { get; private set; }
            public DealEnd DealEnd { get; private set; }

            public Payment Payment { get; private set; }
            public Realtor Realtor { get; private set; }
        public PropertyType PropertyType { get; internal set; }

        public Add(NedvizhimostEntities db, object deal)
            {

                this.db = db;
                var a = deal as Realtor;
                if (a is Realtor)
                {
                    Realtor = a;
                    DataContext = Realtor;
                }
                var b = deal as DealEnd;
                if (b is DealEnd)
                {
                    DealEnd = b;

                    DataContext = DealEnd;

                }
                var c = deal as Payment;
                if (c is Payment)
                {
                    Payment = c;

                    DataContext = Payment;

                }

            }

            private void Accept_Click(object sender, RoutedEventArgs e)
            {

            }

            private void Click(object sender, RoutedEventArgs e)
            {

            }
        }
}
