using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
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

namespace ShortBody.Resources.UserControls
{
    /// <summary>
    /// Interaction logic for DocumentControl.xaml
    /// </summary>
    public partial class DocumentControl : UserControl
    {
        public event EventHandler<DateEventArgs> DateChanged;

        private FlowDocumentScrollViewer flowDocument;
        private StackPanel TopPanel;
        FlowDocument document;



        public string TotalAmount
        {
            get { return (string)GetValue(TotalAmountProperty); }
            set { SetValue(TotalAmountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalAmount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalAmountProperty =
            DependencyProperty.Register("TotalAmount", typeof(string), typeof(DocumentControl), new PropertyMetadata(""));





        public string TotalVatValue
        {
            get { return (string)GetValue(TotalVatValueProperty); }
            set { SetValue(TotalVatValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalVatValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalVatValueProperty =
            DependencyProperty.Register("TotalVatValue", typeof(string), typeof(DocumentControl), new PropertyMetadata(""));






        // Use this to enable or disable the Vat StackPanel in the document control
        public bool HasVat
        {
            get { return (bool)GetValue(HasVatProperty); }
            set { SetValue(HasVatProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HasVat.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HasVatProperty =
            DependencyProperty.Register("HasVat", typeof(bool), typeof(DocumentControl), new PropertyMetadata(false));




        public int Year
        {
            get { return (int)GetValue(YearProperty); }
            set { SetValue(YearProperty, value); OnDataChanged(); }
        }

        // Using a DependencyProperty as the backing store for Year.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty YearProperty =
            DependencyProperty.Register("Year", typeof(int), typeof(DocumentControl), new PropertyMetadata(0));



        public int Month
        {
            get { return (int)GetValue(MonthProperty); }
            set { SetValue(MonthProperty, value); OnDataChanged(); }
        }

        // Using a DependencyProperty as the backing store for Month.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MonthProperty =
            DependencyProperty.Register("Month", typeof(int), typeof(DocumentControl), new PropertyMetadata(0));

      

        protected void OnDataChanged()
        {
            DateChanged?.BeginInvoke(this, new DateEventArgs(Month, Year),null,null);
        }



        public string CurrentDate
        {
            get { return (string)GetValue(CurrentDateProperty); }
            set { SetValue(CurrentDateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for What.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentDateProperty =
            DependencyProperty.Register("CurrentDate", typeof(string), typeof(DocumentControl), new PropertyMetadata(DateTime.Now.ToLongDateString()));



        public BitmapImage Logo
        {
            get { return (BitmapImage)GetValue(LogoProperty); }
            set { SetValue(LogoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for What.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LogoProperty =
            DependencyProperty.Register("Logo", typeof(BitmapImage), typeof(DocumentControl), new PropertyMetadata(null));



        public string CompanyName
        {
            get { return (string)GetValue(CompanyNameProperty); }
            set { SetValue(CompanyNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for What.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CompanyNameProperty =
            DependencyProperty.Register("CompanyName", typeof(string), typeof(DocumentControl), new PropertyMetadata("  "));

        public string CompanySlogan
        {
            get { return (string)GetValue(CompanySloganProperty); }
            set { SetValue(CompanySloganProperty, value); }
        }

        // Using a DependencyProperty as the backing store for What.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CompanySloganProperty =
            DependencyProperty.Register("CompanySlogan", typeof(string), typeof(DocumentControl), new PropertyMetadata("  "));



        public string What
        {
            get { return (string)GetValue(WhatProperty); }
            set { SetValue(WhatProperty, value); }
        }

        // Using a DependencyProperty as the backing store for What.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WhatProperty =
            DependencyProperty.Register("What", typeof(string), typeof(DocumentControl), new PropertyMetadata("  "));






        public string Who
        {
            get { return (string)GetValue(WhoProperty); }
            set { SetValue(WhoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Who.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WhoProperty =
            DependencyProperty.Register("Who", typeof(string), typeof(DocumentControl), new PropertyMetadata("  "));


     

        public DocumentControl()
        {
            InitializeComponent();
            
            
        }



        private  void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                flowDocument.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
                TopPanel.Visibility = Visibility.Collapsed;
                 Methods.PrintOnMultiPage(this);
            }
            catch { }
            finally {
                flowDocument.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
                TopPanel.Visibility = Visibility.Visible; }
           
          
          
        }

        private void PreviewButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                flowDocument.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
                TopPanel.Visibility = Visibility.Collapsed;
                Methods.PrintPreview(MainWindow.mainWindow,this);
            }
            catch { }
            finally
            {
                flowDocument.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
                TopPanel.Visibility = Visibility.Visible;
            }



        }

        private void document_Loaded(object sender, RoutedEventArgs e)
        {
            flowDocument = sender as FlowDocumentScrollViewer;
        }

        private void Fd_Loaded(object sender, RoutedEventArgs e)
        {
            document = sender as FlowDocument;
        }


        private  IEnumerable<string> GenerateYears()
        {
            yield return "All Years";
            foreach (var item in Enumerable.Range(2005, DateTime.Now.Year - 2004))
            {
                yield return item.ToString();
            }
        }

        private void cbo_Loaded(object sender, RoutedEventArgs e)
        {
            var cb = sender as ComboBox;
            if ((cb).Name == "cboYear")
            {
                cb.ItemsSource = GenerateYears();
            }
            else
                cb.ItemsSource = new List<string>() { "All Months", "January","February","March","April","May",
                                                    "June","July","August","September","October","November","December"};
        }

        private void cbo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cb = sender as ComboBox;
            if ((cb).Name == "cboYear")
            {
                int y = 0;
                int.TryParse(cb.SelectedItem.ToString(), out y);
                Year = y;
            }
            else if(cb.Name == "cboMonth")
            {
                Month = cb.SelectedIndex;
            }
        }

     
       

        private void topPanel_Loaded(object sender, RoutedEventArgs e)
        {
            TopPanel = sender as StackPanel;
        }
    }
}
