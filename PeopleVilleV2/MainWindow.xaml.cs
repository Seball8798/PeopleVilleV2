
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PeopleVilleLibraryV2;
using PeopleVilleLibraryV2.Date;
using PeopleVilleLibraryV2.InhibitansFolder;
using PeopleVilleLibraryV2.Transport;
using static PeopleVilleLibraryV2.Date.Days;

namespace PeopleVilleV2
{
   
    public partial class MainWindow : Window
    {
        int dayIndex;
        private readonly Days.WeekDays[] weekDays = (Days.WeekDays[])Enum.GetValues(typeof(Days.WeekDays));
        public MainWindow()
        {
            InitializeComponent();


        }

        private void SwitchDay_Click(object sender, RoutedEventArgs e)
        {
            if (dayIndex >= weekDays.Length)
                dayIndex = 0;

            DisplayDay.Content = weekDays[dayIndex++].ToString();
        }

        private void OutputFile_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
