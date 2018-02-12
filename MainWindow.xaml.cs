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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfManageRockGroups
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WinLogin l = new WinLogin();
            l.ShowDialog();
            WpfManageRockGroups.RockGroupsDataSet rockGroupsDataSet = ((WpfManageRockGroups.RockGroupsDataSet)(this.FindResource("rockGroupsDataSet")));
            // Загрузить данные в таблицу Band. Можно изменить этот код как требуется.
            WpfManageRockGroups.RockGroupsDataSetTableAdapters.BandTableAdapter rockGroupsDataSetBandTableAdapter = new WpfManageRockGroups.RockGroupsDataSetTableAdapters.BandTableAdapter();
            rockGroupsDataSetBandTableAdapter.Fill(rockGroupsDataSet.Band);
            System.Windows.Data.CollectionViewSource bandViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("bandViewSource")));
            bandViewSource.View.MoveCurrentToFirst();
        }

        private void btnArtist_Click(object sender, RoutedEventArgs e)
        {
            WinArtist a = new WinArtist();
            a.ShowDialog();
        }

        private void btnSong_Click(object sender, RoutedEventArgs e)
        {
            WinSong s = new WinSong();
            s.ShowDialog();
        }

        private void btnBand_Click(object sender, RoutedEventArgs e)
        {
            WinAddGroup ab = new WinAddGroup();
            ab.ShowDialog();
        }


    }
}
