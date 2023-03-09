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
using System.Windows.Shapes;
using RoomLibrary1;

namespace RoomExample
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Room room = new Room();
        LivingRoom livingRoom= new LivingRoom();
        Office office= new Office();
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = "";
            ListRooms.Content += room.Info() + "\n";
            ListRooms.Content += office.Info();

        }

        private void BAddRoom_Click(object sender, RoutedEventArgs e)
        {
            room.RoomLength = Convert.ToDouble(TBLengthR.Text);
            room.RoomWidth = Convert.ToDouble(TBWidthR.Text);
        }

        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            livingRoom.RoomLength = Convert.ToDouble(TBLengthL.Text);
            livingRoom.RoomWidth = Convert.ToDouble(TBWidthL.Text);
            livingRoom.NumWin = Convert.ToInt32(TBNumW.Text);
        }

        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            office.RoomLength = Convert.ToDouble(TBLengthO.Text);
            office.RoomWidth = Convert.ToDouble(TBWidthO.Text);
            office.NumSockets = Convert.ToInt32(TBNumS.Text);
        }
    }
}
