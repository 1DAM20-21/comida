using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> comidas;
        private ObservableCollection<String> tipoComida = new ObservableCollection<string>();



        public ObservableCollection<Plato> Comidas
        {
            get { return comidas; }
            set
            {
                comidas = value;
                NotifyPropertyChanged("Comidas");
            }
        }

        public ObservableCollection<String> TipoComida
        {
            get {
               
                return tipoComida; }
            set
            {
                tipoComida = value;
                NotifyPropertyChanged("TipoComida");
            }
        }

        public ObservableCollection<String> CrearListaItems(ObservableCollection<String> TipoComida)
        {
            TipoComida.Add("China");
            TipoComida.Add("Mejicana");
            TipoComida.Add("Americana");
            return TipoComida;
        }


        public MainWindowVM()
        {
            Comidas = new ObservableCollection<Plato>();
          

        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
