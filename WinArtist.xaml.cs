using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfManageRockGroups
{
    /// <summary>
    /// Логика взаимодействия для WinArtist.xaml
    /// </summary>
    public partial class WinArtist : Window
    {
        public WinArtist()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfManageRockGroups.RockGroupsDataSet rockGroupsDataSet = ((WpfManageRockGroups.RockGroupsDataSet)(this.FindResource("rockGroupsDataSet")));
            // Загрузить данные в таблицу Artist. Можно изменить этот код как требуется.
            WpfManageRockGroups.RockGroupsDataSetTableAdapters.ArtistTableAdapter rockGroupsDataSetArtistTableAdapter = new WpfManageRockGroups.RockGroupsDataSetTableAdapters.ArtistTableAdapter();
            rockGroupsDataSetArtistTableAdapter.Fill(rockGroupsDataSet.Artist);
            System.Windows.Data.CollectionViewSource artistViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("artistViewSource")));
            artistViewSource.View.MoveCurrentToFirst();
        }

        private void btnAddArtist_Click(object sender, RoutedEventArgs e)
        {
            WinAddArtist aa = new WinAddArtist();
            aa.ShowDialog();
        }
    }
}
