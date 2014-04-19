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
            //dm.MoveDirection = MoveDirection.forward;
            dm.MoveSpeed = 10;

            dm.TurnDirection = TurnDirection.left;
            dm.TurnAngle = 10;

            dm.LookDirection = LookDirection.up;
            dm.LookAngle = 10;



            HttpTransferExtData extData = new HttpTransferExtData
            {
                ReceivedFlag = false,
                TimeStap = System.DateTime.Now
            };
            dm.ExtData = extData;
           
            
            


            return dm;
        }
    }
}
