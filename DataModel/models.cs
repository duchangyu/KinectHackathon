using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace DataModel
{
    public enum StatusCommand { on, running, off }

    public enum MoveDirection { forward, backword, none}

    public enum TurnDirection { left, right, none };

    public enum LookDirection { up, down, none };


    public class DataTransfer
    {
        public StatusCommand StatusCommand { get; set; }
        public MoveDirection MoveDirection { get; set; }
        public double MoveSpeed { get; set; }
        public TurnDirection TurnDirection { get; set; }
        public double TurnAngle { get; set; }
        public LookDirection LookDirection { get; set; }
        public double LookAngle { get; set; }



        public HttpTransferExtData ExtData { get; set; }


        public override string ToString()
        {
            return MoveDirection.ToString() + "_" + ExtData.TimeStap.ToString();
        }
    }

    public class HttpTransferExtData
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public bool ReceivedFlag { get; set; }
        public DateTime TimeStap { get; set; }
    }
}
