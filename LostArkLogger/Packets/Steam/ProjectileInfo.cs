using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class ProjectileInfo
    {
        public void SteamDecode(BitReader reader)
        {
            OwnerId = reader.ReadUInt64();
            u16_0 = reader.ReadUInt16();
            SkillLevel = reader.ReadByte();
            u32_4 = reader.ReadUInt32();
            b_4 = reader.ReadByte();
            if (b_4 == 1)
                u64list_0 = reader.ReadList<UInt64>();
            u16_1 = reader.ReadUInt16();
            SkillId = reader.ReadUInt32();
            u64_3 = reader.ReadUInt64();
            bytearray_0 = reader.ReadBytes(6);
            ProjectileId = reader.ReadUInt64();
            SkillEffect = reader.ReadUInt32();
            u64_0 = reader.ReadUInt64();
            u32_0 = reader.ReadUInt32();
            b_0 = reader.ReadByte();
            b_1 = reader.ReadByte();
            if (b_1 == 1)
                u32_1 = reader.ReadUInt32();
            b_2 = reader.ReadByte();
            u32_2 = reader.ReadUInt32();
            Tripods = reader.ReadBytes(3);
            b_3 = reader.ReadByte();
            if (b_3 == 1)
                u64_1 = reader.ReadUInt64();
            u32_3 = reader.ReadUInt32();
            u64_2 = reader.ReadUInt64();
        }
    }
}
