using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RhythmBase.Adofai.Components;
using RhythmBase.Assets;
using RhythmBase.Components;
using RhythmBase.Events;

namespace Revalian
{
    public partial class Ian
    {
        public static void AddNewSprite(RDLevel chart, string spritePath, byte room, bool visibility, int depth, PointE pos, PointE scale)
        {
            Sprite sprite = new(spritePath);
            DecorationEventCollection deco = chart.CreateDecoration(new SingleRoom(room), sprite);
            deco.Depth = depth;
            deco.Visible = visibility;
            deco.Add(new Move() { Beat = chart.Calculator.BeatOf(1), Position = pos, Scale = scale});
            deco.Add(new Tint() { Beat = chart.Calculator.BeatOf(1) });
            deco.Add(new Tile() { Beat = chart.Calculator.BeatOf(1) });
        }
    }
}
