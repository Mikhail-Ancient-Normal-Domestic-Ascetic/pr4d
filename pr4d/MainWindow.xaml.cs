using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace pr4d
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NedvizhimostEntities db;
        public ObservableCollection<PropertyType> PropertyTypes { get; set; }
        public ObservableCollection<Property> Properties { get; set; }
        public ObservableCollection<Sex> Sexes { get; set; }
        public ObservableCollection<Realtor> Realtors { get; set; }
        public ObservableCollection<Payment> Payments { get; set; }
        public ObservableCollection<Deal> Deals { get; set; }
        public ObservableCollection<DealEnd> DealEnds { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            db = new NedvizhimostEntities();
            PropertyTypes = new ObservableCollection<PropertyType>(db.PropertyType);
            List.ItemsSource = PropertyTypes;
            Properties = new ObservableCollection<Property>(db.Property);
            List2.ItemsSource = Properties;

            Sexes = new ObservableCollection<Sex>(db.Sex);
            List4.ItemsSource = Sexes;

            Realtors = new ObservableCollection<Realtor>(db.Realtor);
            List7.ItemsSource = Realtors;

            Payments = new ObservableCollection<Payment>(db.Payment);
            List6.ItemsSource = Realtors;

            Deals = new ObservableCollection<Deal>(db.Deal);
            List5.ItemsSource = Deals;

            DealEnds = new ObservableCollection<DealEnd>(db.DealEnd);
            List3.ItemsSource = DealEnds;



        }






        private void Update()
        {
            PropertyTypes = new ObservableCollection<PropertyType>(db.PropertyType);
            List.ItemsSource = PropertyTypes;
            Properties = new ObservableCollection<Property>(db.Property);
            List2.ItemsSource = Properties;
            DealEnds = new ObservableCollection<DealEnd>(db.DealEnd);
            List3.ItemsSource = DealEnds;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add win = new Add(db, new Deal());
            if (win.ShowDialog() == true)
            {
                Deal Deals = win.Deal;
                db.Deal.Add(Deals);
                try
                {
                    db.SaveChanges();
                }
                catch { }
                Update();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Deal Deals = List.SelectedItem as Deal;
            if (Deals == null) return;
            Add entry = new Add(db, new Deal
            {
                deal_id = Deals.deal_id,
                realtor = Deals.realtor,
                property_id = Deals.property_id,
                type_of_deal = Deals.type_of_deal,
                deal_date = Deals.deal_date,

            });
            if (entry.ShowDialog() == true)
            {
                Deals = db.Deal.Find(entry.Deal.deal_id);
                if (Deals != null)
                {
                    Deals.deal_id = Deals.deal_id;
                    Deals.realtor = Deals.realtor;
                    Deals.property_id = Deals.property_id;
                    Deals.type_of_deal = Deals.type_of_deal;
                    Deals.deal_date = Deals.deal_date;
                    db.SaveChanges();
                    List.Items.Refresh();
                }

            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Deal Deals = List.SelectedItem as Deal;
            if (Deals == null) return;
            try
            {
                db.Deal.Remove(Deals);
                db.SaveChanges();
                Update();
            }
            catch
            {
                MessageBox.Show("Ошибкаааа!!!");
            }

        }



        private void List2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Add win = new Add(db, new PropertyType());
            if (win.ShowDialog() == true)
            {
                PropertyType PropertyType = win.PropertyType;
                db.PropertyType.Add(PropertyType);
                try
                {
                    db.SaveChanges();
                }
                catch { }
                Update();

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PropertyType PropertyType = List3.SelectedItem as PropertyType;
            if (PropertyTypes == null) return;
            try
            {
                db.PropertyType.Remove(PropertyType);
                db.SaveChanges();
            }
            catch { }
            DataContext = db.PropertyType.ToList();
        }
    }
}
