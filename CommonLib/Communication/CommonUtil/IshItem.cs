using System;
using System.Globalization;
using System.Runtime.Serialization;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004B RID: 75
	[global::System.Runtime.Serialization.DataContract(Namespace = "http://www.motorola.com/Cps/Acp/Communication")]
	public struct IshItem
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00020ED4 File Offset: 0x0001F0D4
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00020F84 File Offset: 0x0001F184
		public int ItemSize
		{
			get
			{
				short num = (short)2016781958;
				short num2 = num;
				num = (short)615753350;
				switch (num2 == num)
				{
				}
				num = (short)1263140865;
				if (num != 0)
				{
				}
				num = (short)219217920;
				if (num != 0)
				{
				}
				num = (short)977338368;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1379397352;
				short num2 = num;
				num = (short)1364258536;
				switch (num2 == num)
				{
				}
				num = (short)1966473216;
				if (num != 0)
				{
				}
				num = (short)1010106369;
				if (num != 0)
				{
				}
				num = (short)1861681152;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00021034 File Offset: 0x0001F234
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x000210E0 File Offset: 0x0001F2E0
		public byte[] Data
		{
			get
			{
				short num = (short)1127750366;
				short num2 = num;
				num = (short)249567966;
				switch (num2 == num)
				{
				}
				num = (short)1678442496;
				if (num != 0)
				{
				}
				num = (short)1312358401;
				if (num != 0)
				{
				}
				num = (short)1341259776;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)668872298;
				short num2 = num;
				num = (short)1093742186;
				switch (num2 == num)
				{
				}
				num = (short)1034944513;
				if (num != 0)
				{
				}
				num = (short)262144;
				if (num != 0)
				{
				}
				num = (short)625410048;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00021190 File Offset: 0x0001F390
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00021244 File Offset: 0x0001F444
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult Result
		{
			get
			{
				short num = (short)214475959;
				short num2 = num;
				num = (short)118662327;
				switch (num2 == num)
				{
				}
				num = (short)2055340033;
				if (num != 0)
				{
				}
				num = (short)410976256;
				if (num != 0)
				{
				}
				num = (short)778108928;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1073106608;
				short num2 = num;
				num = (short)1301630640;
				switch (num2 == num)
				{
				}
				num = (short)915210241;
				if (num != 0)
				{
				}
				num = (short)1489502208;
				if (num != 0)
				{
				}
				num = (short)1227620352;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000212F4 File Offset: 0x0001F4F4
		public IshItem(int itemSize, byte[] data, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult result)
		{
			this.a = itemSize;
			this.b = data;
			this.c = result;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00021318 File Offset: 0x0001F518
		public override string ToString()
		{
			int a_ = 7;
			short num = (short)432311288;
			short num2 = num;
			num = (short)1650363384;
			switch (num2 == num)
			{
			}
			num = (short)320471040;
			if (num != 0)
			{
			}
			num = (short)837156865;
			if (num != 0)
			{
			}
			num = (short)398458880;
			short num3 = num;
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䈊礌樎簐䀒簔洖簘☚昜⼞尠༢Ԥ挦䠨弪䰬ሮ䨰Ȳ䠴᜶嬸䈺䤼娾㉀潂敄ᕆⱈ㡊㡌⍎═湒⹔敖⑘", a_), this.ItemSize, (this.Data == null) ? global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("攊砌挎紐", a_) : (this.Data.Length.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⬊漌瘎攐瘒昔", a_)), this.Result.ToString());
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00021444 File Offset: 0x0001F644
		public override bool Equals(object obj)
		{
			if (obj is global::Motorola.Common.Communication.CommonUtil.IshItem)
			{
				short num = (short)1658191873;
				if (num != 0)
				{
				}
			}
			else
			{
				short num = (short)1239847322;
				short num2 = num;
				num = (short)2074644890;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1287323648;
					if (num != 0)
					{
					}
					num = (short)1606483968;
					short num3 = num;
					return false;
				}
				}
			}
			global::Motorola.Common.Communication.CommonUtil.IshItem objB = (global::Motorola.Common.Communication.CommonUtil.IshItem)obj;
			return this == objB;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0002150C File Offset: 0x0001F70C
		public override int GetHashCode()
		{
			short num = (short)305321510;
			short num2 = num;
			num = (short)423941670;
			switch (num2 == num)
			{
			}
			num = (short)943587329;
			if (num != 0)
			{
			}
			num = (short)455933952;
			if (num != 0)
			{
			}
			num = (short)441450496;
			short num3 = num;
			return this.a.GetHashCode() ^ this.c.GetHashCode() ^ this.b.GetHashCode();
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000215E0 File Offset: 0x0001F7E0
		public static bool operator ==(global::Motorola.Common.Communication.CommonUtil.IshItem objA, global::Motorola.Common.Communication.CommonUtil.IshItem objB)
		{
			short num = (short)2116485123;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1936588800;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_14F;
				case 1:
				{
					num = (short)285378316;
					short num4 = num;
					num = (short)511149836;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)1040449536;
						if (num != 0)
						{
						}
						if (objA.Result == objB.Result)
						{
							num = (short)1277689856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				case 2:
					num = (short)737083393;
					if (num != 0)
					{
					}
					num = (short)811859969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				}
				IL_5E:
				if (objA.ItemSize != objB.ItemSize)
				{
					return false;
				}
				num = (short)1424293890;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14F:
			return global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CompareBytes(objA.Data, objB.Data) == 0;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00021744 File Offset: 0x0001F944
		public static bool operator !=(global::Motorola.Common.Communication.CommonUtil.IshItem objA, global::Motorola.Common.Communication.CommonUtil.IshItem objB)
		{
			short num = (short)1508199026;
			short num2 = num;
			num = (short)1612794482;
			switch (num2 == num)
			{
			}
			num = (short)1167130625;
			if (num != 0)
			{
			}
			num = (short)657063936;
			if (num != 0)
			{
			}
			num = (short)149159936;
			short num3 = num;
			return !(objA == objB);
		}

		// Token: 0x040001CB RID: 459
		[global::System.Runtime.Serialization.DataMember]
		private int a;

		// Token: 0x040001CC RID: 460
		[global::System.Runtime.Serialization.DataMember]
		private byte[] b;

		// Token: 0x040001CD RID: 461
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult c;
	}
}
