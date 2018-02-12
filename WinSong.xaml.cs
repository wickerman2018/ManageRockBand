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
    /// Логика взаимодействия для WinSong.xaml
    /// </summary>
    public partial class WinSong : Window
    {
        public WinSong()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfManageRockGroups.RockGroupsDataSet rockGroupsDataSet = ((WpfManageRockGroups.RockGroupsDataSet)(this.FindResource("rockGroupsDataSet")));
            // Загрузить данные в таблицу Song. Можно изменить этот код как требуется.
            WpfManageRockGroups.RockGroupsDataSetTableAdapters.SongTableAdapter rockGroupsDataSetSongTableAdapter = new WpfManageRockGroups.RockGroupsDataSetTableAdapters.SongTableAdapter();
            rockGroupsDataSetSongTableAdapter.Fill(rockGroupsDataSet.Song);
            System.Windows.Data.CollectionViewSource songViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("songViewSource")));
            songViewSource.View.MoveCurrentToFirst();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            WinAddSong s = new WinAddSong();
            s.ShowDialog();
        }
    }
}
