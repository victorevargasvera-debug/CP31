using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AcpBusinessLayer;
using AcpCommonLib;

namespace SpecialFeatures.Clone_Configuration.Common
{
	// Token: 0x0200018C RID: 396
	internal class ClearAndRestorePassword
	{
		// Token: 0x0600131B RID: 4891 RVA: 0x000037D3 File Offset: 0x000019D3
		public ClearAndRestorePassword(global::AcpBusinessLayer.Recordset recordSet, string fieldName)
		{
			this.b = recordSet;
			this.c = fieldName;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x001BA6B0 File Offset: 0x001B88B0
		public void ClearFieldsAndRemember(global::System.Func<string, string> encryptionMethodAction)
		{
			short num = (short)1112801718;
			short num2 = num;
			num = (short)2034500022;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1654915072;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = this.b.GetEnumerator();
				try
				{
					num = (short)685113348;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string text;
						global::AcpBusinessLayer.AcpFieldX<string, string> acpFieldX;
						switch (num3)
						{
						case 0:
							text = encryptionMethodAction(text);
							num = (short)1700462598;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (acpFieldX != null)
							{
								num = (short)181862409;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 3:
							if (!enumerator.MoveNext())
							{
								num = (short)1647312901;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							acpFieldX = (enumerator.Current.AllFields.FirstOrDefault(new global::System.Func<global::AcpCommonLib.IAcpField, bool>(this.b)) as global::AcpBusinessLayer.AcpFieldX<string, string>);
							num = (short)669122562;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_A6;
							}
							continue;
						case 5:
							num = (short)2125791240;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_1A8;
						case 7:
							num = (short)1798569985;
							if (num != 0)
							{
							}
							if (!string.IsNullOrEmpty(text))
							{
								num = (short)2120024064;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A8;
						case 8:
							goto IL_215;
						case 9:
							text = acpFieldX.Value;
							num = (short)976748551;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_114:
						num = (short)1709178883;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A6:
						goto IL_114;
						IL_1A8:
						this.a.Enqueue(text);
						acpFieldX.SetValue(string.Empty);
						num = (short)1120206849;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_215:;
				}
				finally
				{
					num = (short)1736441856;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_247;
							}
							continue;
						case 1:
							goto IL_27D;
						case 2:
							enumerator.Dispose();
							num = (short)1600323585;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_247:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2022047746;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_27D:;
				}
				break;
			}
			}
			num = (short)251854848;
			short num4 = num;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x001BA984 File Offset: 0x001B8B84
		public void RestorePasswordsAndForgot(global::System.Func<string, string> encryptionMethodAction, int trimPassword = -1)
		{
			short num = (short)551158107;
			short num2 = num;
			num = (short)1687224667;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1464401920;
				if (num != 0)
				{
				}
				num = (short)2098331649;
				if (num != 0)
				{
				}
				num = (short)1583087616;
				short num3 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = this.b.GetEnumerator();
				try
				{
					num = (short)42074113;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)1670381573;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_EA;
							}
							continue;
						case 4:
						{
							global::AcpBusinessLayer.AcpFieldX<string, string> acpFieldX = enumerator.Current.AllFields.FirstOrDefault(new global::System.Func<global::AcpCommonLib.IAcpField, bool>(this.a)) as global::AcpBusinessLayer.AcpFieldX<string, string>;
							string text = this.a.Dequeue();
							if (!string.IsNullOrEmpty(text))
							{
								text = encryptionMethodAction(text);
							}
							if (trimPassword > 0)
							{
								text = text.Substring(0, trimPassword);
							}
							if (acpFieldX == null)
							{
								num = (short)1028587522;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							acpFieldX.SetValue(text);
							num = (short)514850819;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_1E9;
						case 6:
							if (!enumerator.MoveNext())
							{
								num = (short)214695936;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)397148164;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_196:
						num = (short)266207238;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_EA:
						goto IL_196;
					}
					IL_1E9:;
				}
				finally
				{
					num = (short)1814822912;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_21B;
							}
							continue;
						case 1:
							goto IL_24F;
						case 2:
							enumerator.Dispose();
							num = (short)1903886337;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_21B:
						if (enumerator == null)
						{
							break;
						}
						num = (short)839843842;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_24F:;
				}
				break;
			}
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x001BAC00 File Offset: 0x001B8E00
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)1082514224;
			short num2 = num;
			num = (short)1533860656;
			switch (num2 == num)
			{
			}
			num = (short)74252289;
			if (num != 0)
			{
			}
			num = (short)948109312;
			if (num != 0)
			{
			}
			num = (short)11927552;
			short num3 = num;
			return A_0.Name == this.c;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x001BACBC File Offset: 0x001B8EBC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)10558997;
			short num2 = num;
			num = (short)1604525589;
			switch (num2 == num)
			{
			}
			num = (short)895877121;
			if (num != 0)
			{
			}
			num = (short)1751973888;
			if (num != 0)
			{
			}
			num = (short)1760755712;
			short num3 = num;
			return A_0.Name == this.c;
		}

		// Token: 0x04000A37 RID: 2615
		private readonly global::System.Collections.Generic.Queue<string> a = new global::System.Collections.Generic.Queue<string>();

		// Token: 0x04000A38 RID: 2616
		private readonly global::AcpBusinessLayer.Recordset b;

		// Token: 0x04000A39 RID: 2617
		private readonly string c;
	}
}
