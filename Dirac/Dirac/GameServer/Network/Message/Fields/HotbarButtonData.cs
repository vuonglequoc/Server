using System.Text;

namespace Dirac.GameServer.Network.Message
{
    public class HotbarButtonData
    {
        public int /* sno */ SNOSkill;
        public int Field1;
        public int /* gbid */ ItemGBId;

        public void Parse(GameBitBuffer buffer)
        {
            SNOSkill = buffer.ReadInt(32);
            Field1 = buffer.ReadInt(3) + (-1);
            ItemGBId = buffer.ReadInt(32);
        }

        public void Encode(GameBitBuffer buffer)
        {
            buffer.WriteInt(32, SNOSkill);
            buffer.WriteInt(3, Field1 - (-1));
            buffer.WriteInt(32, ItemGBId);
        }

        public void AsText(StringBuilder b, int pad)
        {
            b.Append(' ', pad);
            b.AppendLine("HotbarButtonData:");
            b.Append(' ', pad++);
            b.AppendLine("{");
            b.Append(' ', pad);
            b.AppendLine("m_snoPower: 0x" + SNOSkill.ToString("X8"));
            b.Append(' ', pad);
            b.AppendLine("Field1: " + Field1);
            b.Append(' ', pad);
            b.AppendLine("m_gbidItem: 0x" + ItemGBId.ToString("X8"));
            b.Append(' ', --pad);
            b.AppendLine("}");
        }
    }
}