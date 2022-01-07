using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3
{
    class JuniorMember : Member
    {
        public new string MemberType = "Junior";
        public JuniorMember()
        {

        }

        public JuniorMember(string name, decimal newFee, DateTime joinDate, PaymentSchedule paymentSchedule, MemberType mt)
           : base(name, newFee, joinDate, paymentSchedule, mt)
        {
            Name = name;
            JoinDate = joinDate.Date;
            PaymentType = paymentSchedule;
            basicFee = newFee;
            Fee = CalculateFees(newFee);
            memberType = mt;
        }
    }
}
