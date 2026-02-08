using System.ComponentModel;
using System.Numerics;

namespace HotWheels.Models
{
    [DisplayName("CONTROL_FLOAT_SAMPLE")]
    public class ControlFloatSample
    {
        [DisplayName("CONTROL_FLOAT_KEY")]
        public Vector2 FloatKey { get; set; }
    }
}
