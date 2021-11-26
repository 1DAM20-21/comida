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
            get
            {

                return tipoComida;
            }
            set
            {
                tipoComida = value;
                NotifyPropertyChanged("TipoComida");
            }
        }

        public void CrearListaItems()
        {
            TipoComida.Add("China");
            TipoComida.Add("Mejicana");
            TipoComida.Add("Americana");

        }

       


        public MainWindowVM()
        {
            /*Cambiar esto depende de estar en casa o en el insti casa-->J clase--->D*/
            Comidas = Plato.GetSamples(@"D:\2DAM\DInt\UD5\ut5_actv1_recursos\FotosPlatos");
            CrearListaItems();


        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
