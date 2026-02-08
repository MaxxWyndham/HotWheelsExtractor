using System.ComponentModel;
using System.Numerics;

namespace HotWheels.Models
{
    [DisplayName("CONTROL_POS_TRACK")]
    public class ControlPosTrack
    {
        [DisplayName("CONTROL_POS_SAMPLE")]
        public Vector4 ControlPosSample { get; set; }
    }
}
