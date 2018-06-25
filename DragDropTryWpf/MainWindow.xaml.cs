using DragDropTryWpf.ViewModels;
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
using WPF.JoshSmith.ServiceProviders.UI;

namespace DragDropTryWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListViewDragDropManager<DragableItem> listViewDragDropManager;
        ListViewDragDropManager<DragableItem> listViewDragDropManager2;

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainViewModel();
            // this.Loaded += mainWindow_Loaded;
            listViewDragDropManager = new ListViewDragDropManager<DragableItem>(this.dragableListView) { IsDeleteSourceItem = true };
            listViewDragDropManager2 = new ListViewDragDropManager<DragableItem>(this.dragableListView2) { IsDeleteSourceItem = true };
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
