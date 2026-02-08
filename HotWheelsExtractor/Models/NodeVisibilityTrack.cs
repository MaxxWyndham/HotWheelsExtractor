using System.ComponentModel;

namespace HotWheels.Models
{
    [DisplayName("NODE_VISIBILITY_TRACK")]
    public class NodeVisibilityTrack
    {
        [LinkedObject("CONTROL_FLOAT_SAMPLE")]
        public ControlFloatSample ControlFloatSample { get; set; }
    }
}
