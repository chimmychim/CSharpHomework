using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ordertest;

namespace ordertest
{
    class Test
    {

        public static bool IsOrder(string isorderId)
        {
            string orderId="";
          
            if (Regex.IsMatch(orderId, isorderId))
                Console.WriteLine("格式正确");
            else
                Console.WriteLine("格式错误");
            return System.Text.RegularExpressions.Regex.IsMatch(isorderId, @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-)[0-9]{3})$");
        }

        public static bool IsPhoneNumber(string iscustomerPhoneNumber)
        {
            string customerPhoneNumber="";
           
            if (Regex.IsMatch(customerPhoneNumber, iscustomerPhoneNumber))
                Console.WriteLine("格式正确");
            else
                Console.WriteLine("格式错误");
            return System.Text.RegularExpressions.Regex.IsMatch(iscustomerPhoneNumber, @"^0{0,1}(13[4-9]|15[7-9]|15[0-2]|18[7-8])[0-9]{8}$");

        }

    }
}
