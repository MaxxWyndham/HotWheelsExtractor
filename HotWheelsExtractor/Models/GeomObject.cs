using System.ComponentModel;
using System.Numerics;

namespace HotWheels.Models
{
    [DisplayName("GEOMOBJECT")]
    public class GeomObject : Node
    {
        [LinkedObject("MESH")]
        public Mesh Mesh { get; set; }

        [DisplayName("PROP_MOTIONBLUR")]
        public int MotionBlur { get; set; }

        [DisplayName("PROP_CASTSHADOW")]
        public int CastShadow { get; set; }

        [DisplayName("PROP_RECVSHADOW")]
        public int RecvShadow { get; set; }

        [LinkedObject("NODE_VISIBILITY_TRACK")]
        public NodeVisibilityTrack NodeVisibilityTrack { get; set; }

        [DisplayName("MATERIAL_REF")]
        public int MaterialRef { get; set; }

        [DisplayName("WIREFRAME_COLOR")]
        public Vector3 WireframeColour { get; set; }
    }
}
