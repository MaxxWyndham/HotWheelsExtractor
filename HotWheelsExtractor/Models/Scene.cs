using System.ComponentModel;
using System.Numerics;

namespace HotWheels.Models
{
    [DisplayName("SCENE")]
    public class Scene
    {
        [DisplayName("SCENE_FILENAME")]
        public string? FileName { get; set; }

        [DisplayName("SCENE_FIRSTFRAME")]
        public int FirstFrame { get; set; }

        [DisplayName("SCENE_LASTFRAME")]
        public int LastFrame { get; set; }

        [DisplayName("SCENE_FRAMESPEED")]
        public int FrameSpeed { get; set; }

        [DisplayName("SCENE_TICKSPERFRAME")]
        public int TicksPerFrame { get; set; }

        [DisplayName("SCENE_BACKGROUND_STATIC")]
        public Vector3 BackgroundStatic { get; set; }

        [DisplayName("SCENE_AMBIENT_STATIC")]
        public Vector3 AmbientStatic { get; set; }
    }
}
