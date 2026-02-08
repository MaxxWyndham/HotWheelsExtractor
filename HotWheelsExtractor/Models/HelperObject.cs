using System.ComponentModel;
using System.Numerics;

namespace HotWheels.Models
{
    [DisplayName("HELPEROBJECT")]
    public class HelperObject : Node
    {
        [DisplayName("HELPER_CLASS")]
        public string HelperClass { get; set; }

        [DisplayName("BOUNDINGBOX_MIN")]
        public Vector3 BoundingBoxMin { get; set; }

        [DisplayName("BOUNDINGBOX_MAX")]
        public Vector3 BoundingBoxMax { get; set; }
    }
}
