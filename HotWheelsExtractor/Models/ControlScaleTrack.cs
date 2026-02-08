using System.ComponentModel;
using System.Numerics;

namespace HotWheels.Models
{
    [DisplayName("CONTROL_SCALE_TRACK")]
    public class ControlScaleTrack
    {
        [DisplayName("CONTROL_SCALE_SAMPLE")]
        public Vector4 ControlRotSample { get; set; }
    }
}
