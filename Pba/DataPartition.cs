using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200000C RID: 12
	[global::System.Serializable]
	public class DataPartition
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00004674 File Offset: 0x00002874
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00004728 File Offset: 0x00002928
		[global::System.Xml.Serialization.XmlAttribute("ID")]
		public byte PartitionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1597852742;
				short num2 = num;
				num = (short)1811631174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1670774784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1986265089;
				if (num != 0)
				{
				}
				num = (short)1537540096;
				if (num != 0)
				{
				}
				return this.<PartitionID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2126150081;
				short num2 = num;
				num = (short)756382145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)712114176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2073690113;
				if (num != 0)
				{
				}
				num = (short)1189675008;
				if (num != 0)
				{
				}
				this.<PartitionID>k__BackingField = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000047D8 File Offset: 0x000029D8
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00004888 File Offset: 0x00002A88
		[global::System.Xml.Serialization.XmlAttribute("Name")]
		public string PartitionName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)160664463;
				short num2 = num;
				num = (short)1116048271;
				switch (num2 == num)
				{
				default:
				{
					num = (short)579272704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1686437889;
				if (num != 0)
				{
				}
				num = (short)1340997632;
				if (num != 0)
				{
				}
				return this.<PartitionName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1246564863;
				short num2 = num;
				num = (short)494080511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1210712064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)450756609;
				if (num != 0)
				{
				}
				num = (short)935657472;
				if (num != 0)
				{
				}
				this.<PartitionName>k__BackingField = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00004938 File Offset: 0x00002B38
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000049E8 File Offset: 0x00002BE8
		[global::System.Xml.Serialization.XmlElement("Block")]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock> DataBlocks
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)413454807;
				short num2 = num;
				num = (short)1780470231;
				switch (num2 == num)
				{
				default:
				{
					num = (short)611581952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)940507136;
				if (num != 0)
				{
				}
				num = (short)129040385;
				if (num != 0)
				{
				}
				return this.<DataBlocks>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)786312342;
				short num2 = num;
				num = (short)771239062;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1495334912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)979566593;
				if (num != 0)
				{
				}
				num = (short)1491271680;
				if (num != 0)
				{
				}
				this.<DataBlocks>k__BackingField = value;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004A98 File Offset: 0x00002C98
		public DataPartition()
		{
			this.PartitionID = 0;
			this.PartitionName = string.Empty;
			this.DataBlocks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004AC8 File Offset: 0x00002CC8
		public void Initialize(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishitemCollection)
		{
			int a_ = 19;
			short num = (short)924844033;
			if (num != 0)
			{
			}
			num = (short)985399296;
			short num2 = num;
			num = (short)823001088;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = ishitemCollection.GetEnumerator();
				try
				{
					num = (short)1188691972;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
							goto IL_176;
						case 2:
							num = (short)37355521;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)459866114;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> block = enumerator.Current;
							global::Motorola.Common.Communication.Pba.DataBlock dataBlock = new global::Motorola.Common.Communication.Pba.DataBlock();
							dataBlock.Initialize(block);
							this.DataBlocks.Add(dataBlock);
							this.PartitionID = block.Key.PartitionNumber;
							this.PartitionName = global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("鿐볒釔닖뿘닚돜뫞藠", a_);
							num = (short)338821120;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_BB;
							}
							continue;
						}
						IL_11F:
						num = (short)1016659971;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_BB:
						goto IL_11F;
					}
					IL_176:;
				}
				finally
				{
					num = (short)1315766274;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							num = (short)1576322726;
							short num4 = num;
							num = (short)202950310;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_21E;
							}
							break;
						}
						case 1:
							enumerator.Dispose();
							num = (short)2074345472;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1AE;
							}
							continue;
						}
						IL_1AE:
						if (enumerator == null)
						{
							goto IL_235;
						}
						num = (short)1016135681;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_21E:
					num = (short)1971453952;
					if (num != 0)
					{
					}
					IL_235:;
				}
				return;
			}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004D1C File Offset: 0x00002F1C
		public void Initialize(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList)
		{
			int a_ = 18;
			short num = (short)805054961;
			short num2 = num;
			num = (short)596584945;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1664811009;
				if (num != 0)
				{
				}
				num = (short)1149632512;
				if (num != 0)
				{
				}
				num = (short)1920466944;
				short num3 = num;
				using (global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>>.Enumerator enumerator = fdiBlockList.GetEnumerator())
				{
					num = (short)168361987;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2034565121;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<ushort, byte[]> fdiBlock = enumerator.Current;
							global::Motorola.Common.Communication.Pba.DataBlock dataBlock = new global::Motorola.Common.Communication.Pba.DataBlock();
							dataBlock.Initialize(fdiBlock);
							this.DataBlocks.Add(dataBlock);
							num = (short)1123483650;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)440336388;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_E5;
							}
							continue;
						case 4:
							goto IL_16B;
						}
						IL_11E:
						num = (short)402522112;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E5:
						goto IL_11E;
					}
					IL_16B:;
				}
				break;
			}
			}
			this.PartitionID = 0;
			this.PartitionName = global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("黏뷑郓돕뻗동닛믝蓟", a_);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004ED0 File Offset: 0x000030D0
		public void Initialize(byte[] cpImage)
		{
			int a_ = 11;
			short num = (short)1841425274;
			short num2 = num;
			num = (short)701426554;
			switch (num2 == num)
			{
			}
			num = (short)679477248;
			short num3 = num;
			num = (short)1631322113;
			if (num != 0)
			{
			}
			num = (short)1219035136;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Pba.DataBlock dataBlock = new global::Motorola.Common.Communication.Pba.DataBlock();
			dataBlock.Initialize(cpImage);
			this.DataBlocks.Add(dataBlock);
			this.PartitionID = 0;
			this.PartitionName = global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("蟈꓊觌꫎럐뫒믔닖뷘", a_);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004FB8 File Offset: 0x000031B8
		public void UpdateWithSubPartition(global::Motorola.Common.Communication.Pba.DataPartition newSubPartition)
		{
			short num = (short)583869628;
			short num2 = num;
			num = (short)474883260;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)204668929;
				if (num != 0)
				{
				}
				num = (short)1045757952;
				if (num != 0)
				{
				}
				num = (short)1835532288;
				short num3 = num;
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator = newSubPartition.DataBlocks.GetEnumerator())
				{
					num = (short)572129286;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							num = (short)165085186;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_202;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1604583425;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.Pba.DataPartition.a a = new global::Motorola.Common.Communication.Pba.DataPartition.a();
							a.a = enumerator.Current;
							global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.DataBlock> source = this.DataBlocks.Where(new global::System.Func<global::Motorola.Common.Communication.Pba.DataBlock, bool>(a.b));
							num = (short)1783824388;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.DataBlock> source;
							if (source.Any<global::Motorola.Common.Communication.Pba.DataBlock>())
							{
								num = (short)2033778693;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.Pba.DataPartition.a a;
							this.DataBlocks.Add(a.a);
							num = (short)202702855;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.Common.Communication.Pba.DataPartition.a a;
							global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.DataBlock> source;
							source.Single<global::Motorola.Common.Communication.Pba.DataBlock>().UpdateWithNewData(a.a);
							num = (short)1016987648;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_EC;
							}
							continue;
						}
						IL_154:
						num = (short)1568997379;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_EC:
						goto IL_154;
					}
					IL_202:;
				}
				break;
			}
			}
		}

		// Token: 0x0200000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600004A RID: 74 RVA: 0x00005208 File Offset: 0x00003408
			internal bool b(global::Motorola.Common.Communication.Pba.DataBlock A_0)
			{
				short num = (short)1882193921;
				if (num != 0)
				{
				}
				if (A_0.BlockType == this.a.BlockType)
				{
					num = (short)1074430939;
					short num2 = num;
					num = (short)657228763;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)208273408;
						if (num != 0)
						{
						}
						num = (short)1247084544;
						short num3 = num;
						break;
					}
					}
					return A_0.BlockID == this.a.BlockID;
				}
				return false;
			}

			// Token: 0x04000021 RID: 33
			public global::Motorola.Common.Communication.Pba.DataBlock a;
		}
	}
}
