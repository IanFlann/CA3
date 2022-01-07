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

namespace CA3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Member> allMembers = new List<Member>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            JuniorMember jm1 = new JuniorMember() { Name = "Jack Murphy", Fee = 1000, JoinDate = new DateTime(2020, 5, 7), PaymentType = PaymentSchedule.Annual , memberType = MemberType.Junior};
            JuniorMember jm2 = new JuniorMember() { Name = "Emily Kelly", Fee = 1000, JoinDate = new DateTime(2021, 1, 10), PaymentType = PaymentSchedule.Biannual , memberType = MemberType.Junior };
            JuniorMember jm3 = new JuniorMember() { Name = "Daniel Ryan", Fee = 1000, JoinDate = new DateTime(2020, 11, 30), PaymentType = PaymentSchedule.Monthly, memberType = MemberType.Junior };
            allMembers.Add(jm1); allMembers.Add(jm2); allMembers.Add(jm3);

            Member m1 = new Member() { Name = "Ella Doyle", Fee = 1000, JoinDate = new DateTime(2019, 3, 20), PaymentType = PaymentSchedule.Annual, memberType = MemberType.Regular };
            Member m2 = new Member() { Name = "Fionn Kennedy", Fee = 1000, JoinDate = new DateTime(2018, 8, 15), PaymentType = PaymentSchedule.Biannual, memberType = MemberType.Regular };
            Member m3 = new Member() { Name = "Louise Moore", Fee = 1000, JoinDate = new DateTime(2017, 2, 10), PaymentType = PaymentSchedule.Monthly, memberType = MemberType.Regular };
            allMembers.Add(m1); allMembers.Add(m2); allMembers.Add(m3);

            SeniorMember sm1 = new SeniorMember() { Name = "Cian Daly", Fee = 1000, JoinDate = new DateTime(2015, 4, 24), PaymentType = PaymentSchedule.Annual, memberType = MemberType.Senior };
            SeniorMember sm2 = new SeniorMember() { Name = "Bobby Quinn", Fee = 1000, JoinDate = new DateTime(2014, 12, 1), PaymentType = PaymentSchedule.Biannual, memberType = MemberType.Senior };
            SeniorMember sm3 = new SeniorMember() { Name = "Eve Gallagher", Fee = 1000, JoinDate = new DateTime(2013, 6, 1), PaymentType = PaymentSchedule.Monthly, memberType = MemberType.Senior };
            allMembers.Add(sm1); allMembers.Add(sm2); allMembers.Add(sm3);

            lstbxMemberList.ItemsSource = allMembers;

            //Never got to start the radio buttons due to running out of time sorry
        }

        private void lstbxMemberList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Member m = (Member)lstbxMemberList.SelectedItem;

            txtblkMemberDetails.Text = m.AllInfo();
        }
    }
}
