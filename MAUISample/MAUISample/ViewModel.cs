using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUISample
{
	internal class ViewModel : INotifyPropertyChanged
	{
		private string selectedItem;

		public string SelectedItem
		{
			get { return selectedItem; }
			set
			{
				selectedItem = value;
				OnPropertyChanged(nameof(SelectedItem));
			}
		}
		public ICommand ListViewSelectionChangedCommand { get; set; }

		public ViewModel()
		{
			this.SelectedItem = "old value";
			ListViewSelectionChangedCommand = new Command(OnSelectionChanged);
		}

		private void OnSelectionChanged(object obj)
		{
			this.SelectedItem = "new value";
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
				this.PropertyChanged(this, new PropertyChangedEventArgs(name));
		}
	}
}
