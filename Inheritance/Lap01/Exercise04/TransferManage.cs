using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise04
{
    internal class TransferManage
    {
        List<InforTranfer> ListTransfer;
        internal TransferManage()
        {
            ListTransfer = new List<InforTranfer>();
        }

        internal TransferManage(List<InforTranfer> listTransfer)
        {
            ListTransfer = listTransfer;
        }

        internal void AddTranfer()
        {
            Console.WriteLine("Add Tranfer In City: 0\nAdd Tranfer out City: 1 ");

            if (int.Parse(Console.ReadLine()) == 0)
            {
                TranferInCity tf = new TranferInCity();
                tf.InputInfo();
                tf.GetMoney();
                ListTransfer.Add(tf);
            }
            else if (int.Parse(Console.ReadLine()) == 0)
            {
                TranferOutCity tf = new TranferOutCity();
                tf.InputInfo();
                tf.GetMoney();
                ListTransfer.Add(tf);
            }

        }
    }
}
