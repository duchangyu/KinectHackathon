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

            Array values = Enum.GetValues(typeof(MoveDirection));
            Random random = new Random();
            MoveDirection randomMoveDirection = (MoveDirection)values.GetValue(random.Next(values.Length));

            DataTransfer dm = new DataTransfer();
            dm.MoveDirection = randomMoveDirection;
            dm.LookAngle = 10;
            dm.LookDirection = LookDirection.up;


            dm.ExtData.ReceivedFlag = false;
            dm.ExtData.TimeStap = System.DateTime.Now;
            
            


            return dm;
        }
    }
}
