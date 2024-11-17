using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using RhythmBase.Components;
using RhythmBase.Events;
using RhythmBase.Extensions;
using RhythmBase.Utils;

namespace Revalian
{
    public partial class Ian
    {
        public static void AddNewSprite(RDLevel chart, string spritePath, byte room, bool visibility, int depth, RDPointE pos, RDSizeE scale,
            float? angle, RDPointE pivot, bool is_event)
        {
            string sprite = Path.GetRelativePath(chart.Path, spritePath);
            sprite = sprite.Substring(3, sprite.Length - 3);
            if (sprite.Substring(sprite.Length - 5) == ".json")
                sprite = sprite.Substring(0, sprite.Length - 5);
            DecorationEventCollection deco = chart.CreateDecoration(new SingleRoom(room), sprite);
            deco.Depth = depth;
            deco.Visible = visibility;
            if (is_event)
            {
                deco.Add(new Move() { Beat = chart.Calculator.BeatOf(1), Position = pos, Scale = scale, Angle = angle, Pivot = pivot });
                //deco.Add(new Tint() { Beat = chart.Calculator.BeatOf(1), Opacity = 100 });
                //deco.Add(new Tile() { Beat = chart.Calculator.BeatOf(1) });
            }
        }

        public static List<DecorationEventCollection> GetSprite(RDLevel chart)
        {
            List<DecorationEventCollection> sprites = new();
            IReadOnlyCollection<DecorationEventCollection> decos = chart.Decorations;
            foreach (DecorationEventCollection sprite in decos)
                sprites.Add(sprite);
            return sprites;
        }

        public static List<string> SpriteListToString(List<DecorationEventCollection> sprites)
        {
            List<string> sprite_string = new();
            foreach (DecorationEventCollection sprite in sprites)
                sprite_string.Add((sprite.Index+1).ToString() + "[房间" + (sprite.Room.Value+1).ToString() + "]: " + sprite.Filename);
            return sprite_string;
        }

        public static List<BaseDecorationAction> GetSpriteEvent(DecorationEventCollection sprite, RDBeat begin_beat, RDBeat end_beat, bool include_begin = false, bool include_end = true) 
        {
            List<IBaseEvent> ibe_events;
            List<BaseDecorationAction> events = new();
            ibe_events = sprite.Where<IBaseEvent>(i => i.Active && (
                (i.Beat > begin_beat && i.Beat < end_beat) || 
                (include_begin && i.Beat == begin_beat) || 
                (include_end && i.Beat == end_beat)
            )).ToList();
            foreach (IBaseEvent event_ in ibe_events)
                events.Add((BaseDecorationAction)event_);
            return events;
        }

        public static void AddSpriteEvent(RDLevel chart, DecorationEventCollection sprite, List<BaseDecorationAction> events, float? parallax_x, float? parallax_y, 
            float? offset_x, float? offset_y, float?[] scale, float? angle, float?[] pivot)
        {
            offset_x += 50; offset_y += 50;
            foreach (BaseDecorationAction eve in events)
            {
                if (eve.Type == EventType.Move)
                {
                    Move oeve = eve.Clone<Move>();
                    RDPointE? old_pos = oeve.Position;
                    if (old_pos != null)
                    {
                        float? x = old_pos.Value.X.ToString() != null ? 
                            ((float)offset_x - (parallax_x / 100) * ((float)offset_x - float.Parse(old_pos.Value.X.ToString()))) : null;
                        float? y = old_pos.Value.Y.ToString() != null ?
                            ((float)offset_y - (parallax_y / 100) * ((float)offset_y - float.Parse(old_pos.Value.Y.ToString()))) : null;
                        oeve.Position = new RDPointE(x, y);
                    }
                    if (oeve.Scale != null)
                        oeve.Scale = new RDSizeE(scale[0] ?? oeve.Scale.Value.Width, scale[1] ?? oeve.Scale.Value.Height);
                    oeve.Angle ??= angle;
                    if (oeve.Pivot != null)
                        oeve.Pivot = new RDPointE(pivot[0] ?? oeve.Pivot.Value.X, pivot[1] ?? oeve.Pivot.Value.Y);
                    chart.Add(oeve);
                    sprite.Add(oeve);
                }
                /*else if (eve.Type == EventType.Tile)
                {
                    Tile oeve = (Tile)eve;
                    RDPointE? old_speed = oeve.Speed;
                    if (old_speed != null)
                    {
                        float x = float.Parse(old_speed.Value.X.ToString()), y = float.Parse(old_speed.Value.Y.ToString());
                        //teve.Speed = new RDPointE((parallax_x / 100) * (x - center_x) + x, (parallax_y / 100) * (y - center_y) + y);
                    }
                    oeve.Speed = new RDPoint(10, 24);
                    sprite.Add(oeve);
                }*/
                else
                {
                    chart.Add(eve.Type switch
                    {
                        EventType.Move => eve.Clone<Move>(),
                        EventType.Tile => eve.Clone<Tile>(),
                        EventType.Tint => eve.Clone<Tint>(),
                        EventType.SetVisible => eve.Clone<SetVisible>(),
                        EventType.PlayAnimation => eve.Clone<PlayAnimation>(),
                        EventType.Comment => eve.Clone<Comment>(),
                        _ => throw new Exception("OH NO"),
                    });
                    sprite.Add(eve);
                }
            }
        }
    }
}
