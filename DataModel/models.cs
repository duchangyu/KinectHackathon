using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    public enum StatusCommand { on, running, off }

    public enum MoveDirection { forward, backword }

    public enum TurnDirection { left, right };

    public enum LookDirection { up, down };


    public class DataTransfer
    {
        public StatusCommand StatusCommand { get; set; }
        public MoveDirection MoveDirection { get; set; }
        public double Speed { get; set; }
        public TurnDirection TurnDirection { get; set; }
        public double TurnAngle { get; set; }
        public LookDirection LookDirection { get; set; }
        public double LookAngle { get; set; }


        //public string Direction { get; set; }
        //public int Steps { get; set; }
        //public string Status { get; set; }
        //public string Message { get; set; }
        public bool ReceivedFlag { get; set; }
        //public DateTime TimeStap { get; set; }

        //public override string ToString()
        //{
        //    return Direction + "_" + TimeStap.ToString();
        //}

    }
}
