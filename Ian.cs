using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RhythmBase;
using RhythmBase.Assets;
using RhythmBase.Components;

namespace Revalian
{
    internal class Ian
    {
        public void AddNewSprite(RDLevel chart, string spritePath, byte room)
        {
            Sprite sprite = new();
            sprite.Name = spritePath;
            chart.CreateDecoration(new SingleRoom(room), sprite);
        }
    }
}
