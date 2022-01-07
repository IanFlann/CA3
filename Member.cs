using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3
{
    public enum PaymentSchedule { Annual, Biannual, Monthly }
    public enum MemberType { Regular, Junior, Senior }

    public class Member
    {
        //Attributes
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Fee { get; set; }
        public decimal basicFee;
        public PaymentSchedule PaymentType { get; set; }
        public MemberType memberType { get; set; }

        public DateTime RenewalDate
        {
            get
            {
                return JoinDate.AddYears(1);              
            }
        }

        public int TotalDays { get; }

        public int DaysToRenewal
        {
            get
            {
                return (int)(RenewalDate - JoinDate).TotalDays;
            }
        }

        //Constructors
        public Member()
        {
 
        }

        public Member(string name, decimal newFee, DateTime joinDate, PaymentSchedule paymentSchedule, MemberType mt)
        {
            Name = name;
            JoinDate = joinDate.Date;
            PaymentType = paymentSchedule;
            basicFee = newFee;
            Fee = CalculateFees(newFee);
            memberType = mt;
        }

        public decimal CalculateFees(decimal fee)
        {
            if (PaymentType == PaymentSchedule.Monthly)
            {
                Fee = fee / 12;
            }

            else if (PaymentType == PaymentSchedule.Biannual)
            {
                Fee = fee / 2;
            }

            else
                Fee = fee;

            return Fee;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public string AllInfo()
        {
            return $"{Name} \nJoin Date: {JoinDate} \nBasic Fee: {basicFee} \nPayment Schedule: {PaymentType} - {Fee} \nRenewal Date: {RenewalDate:dd:MM:yy} \nDays to Renewal: {DaysToRenewal} \nMember Type : {memberType}";
        }
    }
}
