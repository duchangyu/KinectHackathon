using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace client
{
    public class TestDataGenerator
    {

        public static DataTransfer GetOneData()
        {
            //string[] directions = { "left", "right", "forward", "backword" };

            DataTransfer dm = new DataTransfer();
            dm.MoveDirection = MoveDirection.backword;
            dm.LookAngle = 10;
            

            //dm.MoveDirection = 
            //dm.ReceivedFlag = false;
            //dm.Message = "OK";
            //dm.TimeStap = System.DateTime.Now;

            return dm;
        }
    }
}
