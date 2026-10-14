using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000049 RID: 73
	[global::System.Runtime.Serialization.DataContract(Namespace = "http://www.motorola.com/Cps/Acp/Communication")]
	public class IshItemCollection : global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600018A RID: 394 RVA: 0x0001E360 File Offset: 0x0001C560
		public IshItemCollection(int initialCapacity)
		{
			this.a = new global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>(initialCapacity);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0001E380 File Offset: 0x0001C580
		public IshItemCollection() : this(0)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0001E394 File Offset: 0x0001C594
		public global::Motorola.Common.Communication.CommonUtil.IshHeader AddHeader(byte partition, ushort ishType, ushort ishId)
		{
			short num = (short)574206152;
			short num2 = num;
			num = (short)236237000;
			switch (num2 == num)
			{
			}
			num = (short)79822849;
			if (num != 0)
			{
			}
			num = (short)671088640;
			short num3 = num;
			num = (short)1196687360;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, ishType, ishId);
			global::Motorola.Common.Communication.CommonUtil.IshItem value = default(global::Motorola.Common.Communication.CommonUtil.IshItem);
			value.ItemSize = -1;
			value.Data = null;
			value.Result = global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined;
			this.a.Add(ishHeader, value);
			return ishHeader;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0001E478 File Offset: 0x0001C678
		public global::Motorola.Common.Communication.CommonUtil.IshHeader AddItem(byte partition, ushort ishType, ushort ishId, int itemSize, byte[] data)
		{
			short num = (short)1655669228;
			short num2 = num;
			num = (short)2028306924;
			switch (num2 == num)
			{
			}
			num = (short)1594687488;
			if (num != 0)
			{
			}
			num = (short)1715339264;
			short num3 = num;
			num = (short)550436865;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, ishType, ishId);
			global::Motorola.Common.Communication.CommonUtil.IshItem value = default(global::Motorola.Common.Communication.CommonUtil.IshItem);
			value.ItemSize = itemSize;
			value.Data = data;
			value.Result = global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined;
			this.a.Add(ishHeader, value);
			return ishHeader;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0001E564 File Offset: 0x0001C764
		public void Add(global::Motorola.Common.Communication.CommonUtil.IshHeader headers, global::Motorola.Common.Communication.CommonUtil.IshItem item)
		{
			short num = (short)1962314910;
			short num2 = num;
			num = (short)1503300766;
			switch (num2 == num)
			{
			}
			num = (short)1972764672;
			if (num != 0)
			{
			}
			num = (short)1993867264;
			short num3 = num;
			num = (short)1492516865;
			if (num != 0)
			{
			}
			this.a.Add(headers, item);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001E61C File Offset: 0x0001C81C
		public void Update(global::Motorola.Common.Communication.CommonUtil.IshHeader headers, global::Motorola.Common.Communication.CommonUtil.IshItem item)
		{
			short num = (short)777851269;
			short num2 = num;
			num = (short)201593221;
			switch (num2 == num)
			{
			}
			num = (short)239665153;
			if (num != 0)
			{
			}
			num = (short)1914306560;
			short num3 = num;
			num = (short)1890844672;
			if (num != 0)
			{
			}
			this.a[headers] = item;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001E6D4 File Offset: 0x0001C8D4
		public void UpdateRange(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> ishPairs)
		{
			short num = (short)1377566720;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = ishPairs.GetEnumerator();
			try
			{
				num = (short)999817217;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)305070084;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_6A;
						}
						continue;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							goto IL_10F;
						}
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
						this.a[keyValuePair.Key] = keyValuePair.Value;
						num = (short)884539395;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_141;
					}
					IL_A2:
					num = (short)1044970905;
					short num4 = num;
					num = (short)62324121;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_10F:
						num = (short)405471232;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)1887043584;
						if (num != 0)
						{
						}
						num = (short)1568145410;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6A:
					goto IL_A2;
				}
				IL_141:;
			}
			finally
			{
				num = (short)1339097089;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1616838658;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1577385985;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_19F;
						}
						continue;
					case 2:
						goto IL_1D3;
					}
					IL_19F:
					if (enumerator == null)
					{
						break;
					}
					num = (short)410517504;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1D3:;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001E8D4 File Offset: 0x0001CAD4
		public void AddRange(global::Motorola.Common.Communication.CommonUtil.IshItemCollection itemCltn)
		{
			short num = (short)1656225793;
			if (num != 0)
			{
			}
			num = (short)1380319232;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = itemCltn.GetEnumerator();
			try
			{
				num = (short)121110531;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 1:
					{
						if (enumerator.MoveNext())
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							num = (short)35258370;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)804658048;
						short num4 = num;
						num = (short)1806375808;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C7;
						default:
							num = (short)882114560;
							if (num != 0)
							{
							}
							num = (short)2056192004;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						if (!this.ContainsHeader(keyValuePair.Key))
						{
							goto IL_C7;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					case 4:
						num = (short)340787206;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						this.a.Add(keyValuePair.Key, keyValuePair.Value);
						num = (short)1117716480;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_1B1;
					}
					goto IL_9A;
					IL_C7:
					num = (short)235077637;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_E1:
					num = (short)301137921;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A:
					goto IL_E1;
				}
				IL_1B1:;
			}
			finally
			{
				num = (short)1603993601;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)248381442;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1E4;
						}
						continue;
					case 2:
						goto IL_218;
					}
					IL_1E4:
					if (enumerator == null)
					{
						break;
					}
					num = (short)635371520;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_218:;
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0001EB18 File Offset: 0x0001CD18
		public void RemoveRangeByIshName(global::Motorola.Common.Communication.CommonUtil.IshItemCollection itemCltn)
		{
			short num = (short)1131544576;
			short num2 = num;
			num = (short)1005977600;
			switch (num)
			{
			default:
			{
				num = (short)1451229185;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = itemCltn.GetEnumerator();
				try
				{
					num = (short)55705603;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
						{
							if (enumerator.MoveNext())
							{
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
								global::Motorola.Common.Communication.CommonUtil.IshHeader header = new global::Motorola.Common.Communication.CommonUtil.IshHeader(0, keyValuePair.Key.IshType, keyValuePair.Key.IshID);
								num = (short)1834156034;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1203161400;
							short num4 = num;
							num = (short)1484638520;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_106;
							default:
								num = (short)162136064;
								if (num != 0)
								{
								}
								num = (short)369426436;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader header;
							if (this.ContainsHeader(header))
							{
								goto IL_106;
							}
							break;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_B9;
							}
							continue;
						case 4:
							num = (short)798949382;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader header;
							this.Remove(header);
							num = (short)1192034304;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_1EC;
						}
						goto IL_B9;
						IL_106:
						num = (short)431423493;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_123:
						num = (short)2034106369;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B9:
						goto IL_123;
					}
					IL_1EC:;
				}
				finally
				{
					num = (short)216334337;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1347485698;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_222;
							}
							continue;
						case 2:
							goto IL_25A;
						}
						IL_222:
						if (enumerator == null)
						{
							break;
						}
						num = (short)468647936;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_25A:;
				}
				return;
			}
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001EDA0 File Offset: 0x0001CFA0
		public void ReplacePartition(byte originalPartID, byte replacePartID)
		{
			short num = (short)1570439168;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
				using (global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>.Enumerator enumerator = this.a.GetEnumerator())
				{
					num = (short)16973827;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)207683588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)1538654210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.PartitionNumber == originalPartID)
							{
								num = (short)1648951301;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_1ED;
							}
							continue;
						case 4:
							num = (short)1830551558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							ushort ishType = key.IshType;
							key = keyValuePair.Key;
							global::Motorola.Common.Communication.CommonUtil.IshHeader headers = new global::Motorola.Common.Communication.CommonUtil.IshHeader(replacePartID, ishType, key.IshID);
							ishItemCollection.Add(headers, keyValuePair.Value);
							list.Add(keyValuePair.Key);
							num = (short)1180958720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_2EE;
						}
						IL_236:
						num = (short)789577729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1ED:
						goto IL_236;
					}
					IL_2EE:
					goto IL_19C;
				}
				goto IL_301;
				for (;;)
				{
					IL_19C:
					using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>.Enumerator enumerator2 = list.GetEnumerator())
					{
						num = (short)1097531395;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.Common.Communication.CommonUtil.IshHeader header;
								this.Remove(header);
								num = (short)1549074433;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)2027421701;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)899021670;
								short num3 = num;
								num = (short)1545599846;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_B3;
								default:
								{
									num = (short)378929152;
									if (num != 0)
									{
									}
									global::Motorola.Common.Communication.CommonUtil.IshHeader header = enumerator2.Current;
									num = (short)2057568260;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_7E;
								}
								continue;
							case 4:
							{
								global::Motorola.Common.Communication.CommonUtil.IshHeader header;
								if (this.ContainsHeader(header))
								{
									num = (short)147587072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								goto IL_B3;
							case 6:
								goto IL_189;
							}
							IL_80:
							num = (short)264241154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_7E:
							goto IL_80;
							IL_B3:
							num = (short)361234438;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_189:
						break;
					}
				}
				IL_301:
				num = (short)1614544896;
				short num4 = num;
				num = (short)337772545;
				if (num != 0)
				{
				}
				this.AddRange(ishItemCollection);
				return;
			}
			}
		}

		// Token: 0x1700006A RID: 106
		public global::Motorola.Common.Communication.CommonUtil.IshItem this[byte partition, ushort ishType, ushort ishId]
		{
			get
			{
				short num = (short)1813203676;
				short num2 = num;
				num = (short)796543708;
				switch (num2 == num)
				{
				}
				num = (short)805437440;
				short num3 = num;
				num = (short)739573761;
				if (num != 0)
				{
				}
				num = (short)1005912064;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.IshHeader key = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, ishType, ishId);
				return this[key];
			}
			set
			{
				short num = (short)718730396;
				short num2 = num;
				num = (short)1370485916;
				switch (num2 == num)
				{
				}
				num = (short)1318256640;
				short num3 = num;
				num = (short)1167917056;
				if (num != 0)
				{
				}
				num = (short)1649541121;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.IshHeader key = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, ishType, ishId);
				this[key] = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0001F2B0 File Offset: 0x0001D4B0
		public int Count
		{
			get
			{
				short num = (short)838162397;
				short num2 = num;
				num = (short)143611869;
				switch (num2 == num)
				{
				}
				num = (short)1823277056;
				short num3 = num;
				num = (short)1048576;
				if (num != 0)
				{
				}
				num = (short)1190199297;
				if (num != 0)
				{
				}
				return this.a.Count;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0001F368 File Offset: 0x0001D568
		public bool ContainsHeader(global::Motorola.Common.Communication.CommonUtil.IshHeader header)
		{
			short num = (short)1924320645;
			short num2 = num;
			num = (short)477482373;
			switch (num2 == num)
			{
			}
			num = (short)857341952;
			short num3 = num;
			num = (short)1067909121;
			if (num != 0)
			{
			}
			num = (short)1907032064;
			if (num != 0)
			{
			}
			return this.a.ContainsKey(header);
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0001F41C File Offset: 0x0001D61C
		public global::System.Collections.Generic.ICollection<global::Motorola.Common.Communication.CommonUtil.IshHeader> Headers
		{
			get
			{
				short num = (short)290656086;
				short num2 = num;
				num = (short)1858146134;
				switch (num2 == num)
				{
				}
				num = (short)362217472;
				short num3 = num;
				num = (short)1671954433;
				if (num != 0)
				{
				}
				num = (short)1394147328;
				if (num != 0)
				{
				}
				return this.a.Keys;
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001F4D0 File Offset: 0x0001D6D0
		public bool Remove(global::Motorola.Common.Communication.CommonUtil.IshHeader header)
		{
			short num = (short)597718731;
			short num2 = num;
			num = (short)493975243;
			switch (num2 == num)
			{
			}
			num = (short)132907008;
			short num3 = num;
			num = (short)305856513;
			if (num != 0)
			{
			}
			num = (short)1778384896;
			if (num != 0)
			{
			}
			return this.a.Remove(header);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001F584 File Offset: 0x0001D784
		public void RemoveAll(global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>, bool> condition)
		{
			short num = (short)13138834;
			short num2 = num;
			num = (short)1083145106;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)890765312;
				short num3 = num;
				num = (short)1435500545;
				if (num != 0)
				{
				}
				num = (short)755564544;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>.Enumerator enumerator = this.a.Where(condition).ToList<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>().GetEnumerator())
				{
					num = (short)1751252993;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2126118916;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							this.a.Remove(keyValuePair.Key);
							num = (short)1232928770;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_EC;
							}
							continue;
						case 3:
							goto IL_170;
						case 4:
							num = (short)22806531;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_120:
						num = (short)1265172480;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_EC:
						goto IL_120;
					}
					IL_170:;
				}
				break;
			}
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001F724 File Offset: 0x0001D924
		public void Clear()
		{
			short num = (short)1055868292;
			short num2 = num;
			num = (short)222053764;
			switch (num2 == num)
			{
			}
			num = (short)81723392;
			short num3 = num;
			num = (short)291962881;
			if (num != 0)
			{
			}
			num = (short)1589182464;
			if (num != 0)
			{
			}
			this.a.Clear();
		}

		// Token: 0x1700006D RID: 109
		public global::Motorola.Common.Communication.CommonUtil.IshItem this[global::Motorola.Common.Communication.CommonUtil.IshHeader key]
		{
			get
			{
				short num = (short)218528057;
				short num2 = num;
				num = (short)1803909433;
				switch (num2 == num)
				{
				}
				num = (short)1537474560;
				short num3 = num;
				num = (short)784728065;
				if (num != 0)
				{
				}
				num = (short)335151104;
				if (num != 0)
				{
				}
				return this.a[key];
			}
			set
			{
				short num = (short)1035097786;
				short num2 = num;
				num = (short)1557878458;
				switch (num2 == num)
				{
				}
				num = (short)890175488;
				short num3 = num;
				num = (short)2129657856;
				if (num != 0)
				{
				}
				num = (short)90963969;
				if (num != 0)
				{
				}
				this.a[key] = value;
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001F944 File Offset: 0x0001DB44
		public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> GetEnumerator()
		{
			short num = (short)2092731111;
			short num2 = num;
			num = (short)1520077543;
			switch (num2 == num)
			{
			}
			num = (short)1132462080;
			short num3 = num;
			num = (short)505217024;
			if (num != 0)
			{
			}
			num = (short)345178113;
			if (num != 0)
			{
			}
			return this.a.GetEnumerator();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001F9FC File Offset: 0x0001DBFC
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)19075123;
			short num2 = num;
			num = (short)1123225651;
			switch (num2 == num)
			{
			}
			num = (short)381943808;
			short num3 = num;
			num = (short)1312292864;
			if (num != 0)
			{
			}
			num = (short)1144389633;
			if (num != 0)
			{
			}
			return this.a.GetEnumerator();
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001FAB8 File Offset: 0x0001DCB8
		public byte[] ToByteArray(bool littleEndian)
		{
			short num = (short)389742592;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				int num3;
				int num4;
				global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>.ValueCollection.Enumerator enumerator;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						if (num3 == 0)
						{
							num = (short)1094189058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array = new byte[num3 * 6 + num4];
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array);
						num = (short)1579548675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)189136898;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1530920965;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.CommonUtil.IshItem ishItem = enumerator.Current;
									num = (short)310640643;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_219;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_10F;
									}
									continue;
								case 3:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItem ishItem;
									if (ishItem.Result == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
									{
										num = (short)924319748;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									num3++;
									global::Motorola.Common.Communication.CommonUtil.IshItem ishItem;
									num4 += ishItem.ItemSize;
									num = (short)746389510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									num = (short)1781671981;
									short num5 = num;
									num = (short)1360013357;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)439222272;
										if (num != 0)
										{
										}
										num = (short)1887240193;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_152:
								num = (short)1991311360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10F:
								goto IL_152;
							}
							IL_219:
							goto IL_5ED;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_2;
						IL_5ED:
						num = (short)215744517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_5E8;
					case 3:
						goto IL_22C;
					case 4:
						goto IL_5B1;
					case 5:
					{
						num = (short)1970864128;
						short num6 = num;
						if (num4 != 0)
						{
							num = (short)373030916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CA;
					}
					}
					goto IL_46;
					IL_5B1:
					num = (short)1724317696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_2:
					try
					{
						IL_22C:
						using (global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>.Enumerator enumerator2 = this.a.GetEnumerator())
						{
							num = (short)133038080;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_289;
									}
									continue;
								case 1:
								{
									global::System.IO.MemoryStream memoryStream;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									memoryStream.WriteByte(key.PartitionNumber);
									memoryStream.WriteByte((byte)(key.IshType & 255));
									memoryStream.WriteByte((byte)(key.IshType >> 8));
									memoryStream.WriteByte((byte)(key.IshID & 255));
									memoryStream.WriteByte((byte)(key.IshID >> 8));
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									memoryStream.WriteByte((byte)(value.ItemSize & 255));
									memoryStream.WriteByte((byte)(value.ItemSize >> 8));
									byte b = value.Data[value.Data.Length - 1];
									value.Data[value.Data.Length - 1] = value.Data[value.Data.Length - 2];
									value.Data[value.Data.Length - 2] = b;
									memoryStream.Write(value.Data, 0, value.ItemSize);
									num = (short)1407254533;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)182124552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (littleEndian)
									{
										num = (short)655097857;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.IO.MemoryStream memoryStream;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									memoryStream.WriteByte(key.PartitionNumber);
									memoryStream.WriteByte((byte)(key.IshType >> 8));
									memoryStream.WriteByte((byte)(key.IshType & 255));
									memoryStream.WriteByte((byte)(key.IshID >> 8));
									memoryStream.WriteByte((byte)(key.IshID & 255));
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									memoryStream.WriteByte((byte)(value.ItemSize >> 8));
									memoryStream.WriteByte((byte)(value.ItemSize & 255));
									memoryStream.Write(value.Data, 0, value.ItemSize);
									num = (short)1317076996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									if (value.Result == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
									{
										num = (short)486014983;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)171573251;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_532;
								case 9:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)731643906;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator2.Current;
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									num = (short)484114438;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_4D7:
								num = (short)1733885961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_289:
								goto IL_4D7;
							}
							IL_532:
							byte[] array;
							return array;
						}
					}
					finally
					{
						num = (short)2143551488;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.IO.MemoryStream memoryStream;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_577;
								}
								continue;
							case 1:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)1809580034;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_5AE;
							}
							IL_577:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)2133262337;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_5AE:;
					}
					goto IL_5B1;
				}
				IL_CA:
				return null;
				IL_5E8:
				goto IL_CA;
				IL_46:
				num3 = 0;
				num4 = 0;
				enumerator = this.a.Values.GetEnumerator();
				num = (short)1855782913;
				if (num != 0)
				{
				}
				num = (short)971505665;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00020168 File Offset: 0x0001E368
		public global::System.Collections.Generic.List<ushort> GetIshTypeList()
		{
			short num = (short)1461482891;
			short num2 = num;
			num = (short)1279817099;
			global::System.Collections.Generic.List<ushort> list;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)734593024;
				short num3 = num;
				num = (short)80281601;
				if (num != 0)
				{
				}
				num = (short)2014576640;
				if (num != 0)
				{
				}
				list = new global::System.Collections.Generic.List<ushort>();
				using (global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>.KeyCollection.Enumerator enumerator = this.a.Keys.GetEnumerator())
				{
					num = (short)1548681218;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1100808197;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = enumerator.Current;
							num = (short)2039611395;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_1AB;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_F0;
							}
							continue;
						case 3:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
							if (!list.Contains(ishHeader.IshType))
							{
								num = (short)1409024004;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
							list.Add(ishHeader.IshType);
							num = (short)1693581318;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1873149953;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_135:
						num = (short)189792256;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_F0:
						goto IL_135;
					}
					IL_1AB:;
				}
				break;
			}
			}
			return list;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00020344 File Offset: 0x0001E544
		public static int IshPairCompare(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> x, global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> y)
		{
			short num = (short)1575157761;
			if (num != 0)
			{
			}
			num = (short)706648417;
			short num2 = num;
			num = (short)1909365089;
			switch (num2 == num)
			{
			default:
			{
				num = (short)493289472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)314703872;
			if (num != 0)
			{
			}
			return x.Key.CompareTo(y.Key);
		}

		// Token: 0x040001C7 RID: 455
		[global::System.Runtime.Serialization.DataMember]
		private global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> a;
	}
}
