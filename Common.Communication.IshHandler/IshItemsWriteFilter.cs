using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000012 RID: 18
	public class IshItemsWriteFilter
	{
		// Token: 0x06000128 RID: 296 RVA: 0x000176F4 File Offset: 0x000158F4
		public IshItemsWriteFilter(global::System.Collections.Generic.IList<byte> writePartitions, global::System.Collections.Generic.IList<ushort> programmableTypes)
		{
			this.a = new global::System.Collections.Generic.List<ushort>();
			foreach (byte item in writePartitions)
			{
				this.a.Add((ushort)item);
			}
			this.b = ((programmableTypes == null) ? null : new global::System.Collections.Generic.HashSet<ushort>(programmableTypes));
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00017774 File Offset: 0x00015974
		public IshItemsWriteFilter(global::System.Collections.Generic.IList<ushort> writePartitions, global::System.Collections.Generic.IList<ushort> interestTypes)
		{
			this.a = writePartitions;
			this.b = ((interestTypes == null) ? null : new global::System.Collections.Generic.HashSet<ushort>(interestTypes));
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000177A4 File Offset: 0x000159A4
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection GetCollectionToWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			short num = (short)800594505;
			short num2 = num;
			num = (short)820976201;
			switch (num2 == num)
			{
			}
			num = (short)395575297;
			if (num != 0)
			{
			}
			num = (short)844169216;
			short num3 = num;
			num = (short)2137915392;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaObject.GetCodeplugInIshItemCollection();
			return this.GetCollectionToWrite(codeplugInIshItemCollection);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0001785C File Offset: 0x00015A5C
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection GetCollectionToWrite(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItems)
		{
			short num = (short)246153216;
			short num2 = num;
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = ishItems.GetEnumerator();
			try
			{
				num = (short)331153408;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)474480643;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
						num = (short)1245904901;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)432335540;
						short num4 = num;
						num = (short)174123700;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1878065152;
							if (num != 0)
							{
							}
							num = (short)509149190;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						ishItemCollection.Add(keyValuePair.Key, keyValuePair.Value);
						num = (short)579534850;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
						if (this.CanIshItemWrite(keyValuePair.Key))
						{
							num = (short)669712388;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_181;
					}
					IL_BE:
					num = (short)1832386561;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A:
					goto IL_BE;
				}
				IL_181:;
			}
			finally
			{
				num = (short)1746534401;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1042153474;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1B6;
						}
						continue;
					case 2:
						goto IL_210;
					}
					IL_1B6:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1630273537;
					if (num != 0)
					{
					}
					num = (short)1963196416;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_210:;
			}
			return ishItemCollection;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00017A9C File Offset: 0x00015C9C
		protected bool CanIshItemWrite(global::Motorola.Common.Communication.CommonUtil.IshHeader header)
		{
			short num = (short)166658050;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1535705088;
					short num3 = num;
					num = (short)1598095361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (this.a(header.IshType))
					{
						num = (short)1826226179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
				{
					num = (short)33410248;
					short num4 = num;
					num = (short)576179400;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_99;
					default:
						num = (short)2110980096;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					}
					break;
				}
				case 3:
					goto IL_119;
				}
				goto IL_82;
				IL_99:
				num = (short)1438384128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_82:
				if (this.a.Contains((ushort)header.PartitionNumber))
				{
					goto IL_99;
				}
				return false;
			}
			return false;
			IL_119:
			num = (short)1357905921;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00017BEC File Offset: 0x00015DEC
		private bool a(ushort A_0)
		{
			short num = (short)1419771906;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9E;
				case 1:
					if (this.b.Count > 0)
					{
						num = (short)686555139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
				{
					num = (short)1493968934;
					short num3 = num;
					num = (short)632039462;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9E;
					default:
						num = (short)1365114880;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					}
					break;
				}
				case 3:
					goto IL_10F;
				}
				IL_7F:
				if (this.b != null)
				{
					num = (short)113049600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_9E:
				num = (short)2139422720;
				short num4 = num;
				num = (short)780730369;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			num = (short)1737293825;
			if (num != 0)
			{
			}
			return this.b.Contains(A_0);
		}

		// Token: 0x0400001F RID: 31
		private global::System.Collections.Generic.IList<ushort> a;

		// Token: 0x04000020 RID: 32
		private global::System.Collections.Generic.HashSet<ushort> b;
	}
}
