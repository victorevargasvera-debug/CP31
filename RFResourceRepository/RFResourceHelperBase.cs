using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace RFResourceRepository
{
	// Token: 0x0200000B RID: 11
	public abstract class RFResourceHelperBase
	{
		// Token: 0x0600409B RID: 16539 RVA: 0x00349614 File Offset: 0x00347814
		public global::System.Drawing.Bitmap GetRFIconByResourceID(string resourceID)
		{
			short num;
			global::System.Drawing.Bitmap result;
			try
			{
				num = (short)1112050701;
				short num2 = num;
				num = (short)1458277389;
				object obj;
				global::System.Drawing.Bitmap bitmap;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_282:
					bitmap = (global::System.Drawing.Bitmap)obj;
					num = (short)243859456;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)413007872;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_99;
					}
					break;
				}
				for (;;)
				{
					IL_53:
					switch (num3)
					{
					case 0:
						goto IL_188;
					case 1:
						goto IL_287;
					case 2:
						num = (short)795410441;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						bitmap.MakeTransparent();
						num = (short)1361051662;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						obj = this.a[resourceID];
						num = (short)598081537;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (this.a.ContainsKey(resourceID))
						{
							num = (short)1729757188;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						obj = global::RFResourceRepository.RFICONResources.ResourceManager.GetObject(resourceID, global::System.Globalization.CultureInfo.CurrentCulture);
						this.a.Add(resourceID, obj);
						num = (short)1997209612;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						bitmap = ((global::System.Drawing.Icon)obj).ToBitmap();
						num = (short)393281544;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (bitmap != null)
						{
							num = (short)1811218435;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BF;
					case 8:
						goto IL_188;
					case 9:
						if (obj is global::System.Drawing.Bitmap)
						{
							num = (short)830996495;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1038811149;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_2DA;
					case 11:
						if (obj != null)
						{
							num = (short)360382466;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_188;
					case 12:
						goto IL_287;
					case 13:
						if (obj is global::System.Drawing.Icon)
						{
							num = (short)1385234438;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_188;
					case 14:
						goto IL_2BF;
					case 15:
						goto IL_282;
					}
					goto IL_99;
					IL_188:
					num = (short)1193869319;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_287:
					num = (short)815136779;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BF:
					result = bitmap;
					num = (short)174391306;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_2DA:
				goto IL_2E1;
				IL_99:
				num = (short)448724993;
				if (num != 0)
				{
				}
				bitmap = null;
				num = (short)1794965509;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_53;
			}
			catch
			{
				result = null;
			}
			IL_2E1:
			num = (short)1887371264;
			short num4 = num;
			return result;
		}

		// Token: 0x0600409C RID: 16540
		public abstract string GetRFResourceValueByResourceID(string resourceID, string[] args = null);

		// Token: 0x0600409D RID: 16541 RVA: 0x00349948 File Offset: 0x00347B48
		public string GetRFResourceByID(string resourceID, string[] args = null)
		{
			string result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (result == resourceID)
						{
							num2 = (short)1282342913;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
					{
						num2 = (short)1888747520;
						short num3 = num2;
						num2 = (short)1741138233;
						short num4 = num2;
						num2 = (short)515483961;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)697892864;
							if (num2 != 0)
							{
							}
							num2 = (short)565510145;
							if (num2 != 0)
							{
							}
							result = this.GetResourceByID(resourceID, args);
							num2 = (short)1117650946;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						return result;
					}
					break;
				}
				IL_1C:
				result = this.GetErrorMessageByID(resourceID, args);
				num2 = (short)1042153472;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x0600409E RID: 16542
		public abstract string GetErrorMessageByID(string errorID, string[] args = null);

		// Token: 0x0600409F RID: 16543
		public abstract string GetResourceByID(string resourceID, string[] args = null);

		// Token: 0x060040A0 RID: 16544
		public abstract global::System.Resources.ResourceManager GetRFResourceManager();

		// Token: 0x04000010 RID: 16
		private global::System.Collections.Generic.Dictionary<string, object> a = new global::System.Collections.Generic.Dictionary<string, object>();
	}
}
