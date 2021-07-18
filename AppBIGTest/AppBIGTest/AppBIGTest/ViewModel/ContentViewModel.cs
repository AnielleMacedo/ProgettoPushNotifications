using AppBIGTest.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace AppBIGTest.ViewModel
{

    public class ContentViewModel 
    {

        private ObservableCollection<ContentModel> contentCollection;


        public ObservableCollection<ContentModel> ContentCollection 
        {
            get { return contentCollection; }
            set { contentCollection = value; }
        }


        /// <summary>
        /// construct
        /// </summary>
        public ContentViewModel()
        {
            //esempi contenuto push preimpostato
            contentCollection = new ObservableCollection<ContentModel>
            {
                new ContentModel() { Content = "Acensione delle luce" },
                new ContentModel() { Content = "Allarme scattato: rilevata fuga di gas" },
                new ContentModel() { Content = "Allarme scattato: presenza di fumo" },
                new ContentModel() { Content = "Allarme scattato: carichi di corrente" },
                new ContentModel() { Content = "Allarme scattato: allagamento" },
                new ContentModel() { Content = "Allarme scattato: prevenzione di blackout da sovraccarico" },
                new ContentModel() { Content = "Blocco Porta" },
                new ContentModel() { Content = "Cambio scenario" },
                new ContentModel() { Content = "Impianto avviato" },
                new ContentModel() { Content = "Irrigazione giardino ativa" },
                new ContentModel() { Content = "Luce accesa" },
                new ContentModel() { Content = "Luce spenta" },
                new ContentModel() { Content = "Porta bloccata" },
                new ContentModel() { Content = "Porta liberata" },
                new ContentModel() { Content = "Raffreddamento stanza" },
                new ContentModel() { Content = "Regolazione temperatura stanza" },
                new ContentModel() { Content = "Regolazione delle luce in presenza" },
                new ContentModel() { Content = "Riscaldamento stanza" },
                new ContentModel() { Content = "Risparmio energetico" },
                new ContentModel() { Content = "Spegnimento delle luce" }
            };





        }
    }

}
