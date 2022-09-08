using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class PCStruct
    {
        public void SteamDecode(BitReader reader)
        {
            u64_0 = reader.ReadUInt64();
            b_0 = reader.ReadByte();
            if (b_0 == 1)
                bytearray_2 = reader.ReadBytes(12);
            b_3 = reader.ReadByte();
            Name = reader.ReadString();
            bytearray_0 = reader.ReadBytes(25);
            EquippedItems = reader.ReadList<ItemInfo>();
            u16_3 = reader.ReadUInt16();
            b_12 = reader.ReadByte();
            subPKTInitPC29s = reader.ReadList<subPKTInitPC29>();
            GearLevel = reader.ReadUInt32();
            Level = reader.ReadUInt16();
            b_1 = reader.ReadByte();
            ClassId = reader.ReadUInt16();
            u32_0 = reader.ReadUInt32();
            b_2 = reader.ReadByte();
            skillRunes = reader.Read<SkillRunes>();
            statusEffectDatas = reader.ReadList<StatusEffectData>();
            u16_0 = reader.ReadUInt16();
            u32_1 = reader.ReadUInt32();
            bytearray_1 = reader.ReadBytes(5);
            itemInfos = reader.ReadList<ItemInfo>();
            b_4 = reader.ReadByte();
            b_5 = reader.ReadByte();
            b_6 = reader.ReadByte();
            u32_2 = reader.ReadUInt32();
            PlayerId = reader.ReadUInt64();
            u32_3 = reader.ReadUInt32();
            u16_1 = reader.ReadUInt16();
            u32_4 = reader.ReadUInt32();
            statPair = reader.Read<StatPair>();
            b_7 = reader.ReadByte();
            u32_5 = reader.ReadUInt32();
            u32_6 = reader.ReadUInt32();
            subPKTNewNpc5 = reader.Read<subPKTNewNpc5>();
            b_8 = reader.ReadByte();
            b_9 = reader.ReadByte();
            u16_2 = reader.ReadUInt16();
            b_10 = reader.ReadByte();
            u32_7 = reader.ReadUInt32();
            PartyId = reader.ReadUInt64();
            str_0 = reader.ReadString();
            u32_8 = reader.ReadUInt32();
            b_11 = reader.ReadByte();
            u32list_0 = reader.ReadList<UInt32>();
        }
    }
}
