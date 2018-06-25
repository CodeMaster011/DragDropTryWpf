using Mvvm;
using Mvvm.Commands;
using System.Collections.ObjectModel;

namespace DragDropTryWpf.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public ObservableCollection<DragableItem> DragableCollection { get; set; } 
        public ObservableCollection<DragableItem> DragableCollection2 { get; set; }

        public DelegateCommand ClickToAddNewItemCommand { get; set; }

        public MainViewModel()
        {

            var dataCollection = new DragableItem[5];
            for (int i = 0; i < dataCollection.Length; i++)
            {
                dataCollection[i] = new DragableItem { Name = $"Item{i}" };
            }
            DragableCollection = new ObservableCollection<DragableItem>(dataCollection);

            dataCollection = new DragableItem[5];
            for (int i = 0; i < dataCollection.Length; i++)
            {
                dataCollection[i] = new DragableItem { Name = $"Item2{i}" };
            }
            DragableCollection2 = new ObservableCollection<DragableItem>(dataCollection);


            ClickToAddNewItemCommand = new DelegateCommand(() => DragableCollection.Insert(3, new DragableItem { Name = "New Item" }));
        }
    }

    public class DragableItem
    {
        public string Name { get; set; }
    }
}
