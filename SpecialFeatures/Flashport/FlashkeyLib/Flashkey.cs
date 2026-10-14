using System;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashkeyLib
{
	// Token: 0x020000FF RID: 255
	internal sealed class Flashkey
	{
		// Token: 0x06000E3A RID: 3642 RVA: 0x0000318A File Offset: 0x0000138A
		public Flashkey()
		{
			this.a = new byte[0];
			this.b = null;
			this.c = new byte[0];
			this.d = 24;
			this.e = 2;
			this.f = 0;
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00140910 File Offset: 0x0013EB10
		internal Flashkey(global::SpecialFeatures.Flashport.FlashkeyLib.Flashkey key)
		{
			this.d = key.d;
			this.a = key.a;
			this.c = key.c;
			this.b = key.b;
			this.e = key.e;
			this.f = key.f;
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x0014096C File Offset: 0x0013EB6C
		internal int KeyDecDataSize
		{
			get
			{
				short num = (short)1462539528;
				short num2 = num;
				num = (short)1441502472;
				switch (num2 == num)
				{
				}
				num = (short)734789633;
				if (num != 0)
				{
				}
				num = (short)287440896;
				if (num != 0)
				{
				}
				num = (short)2095906816;
				short num3 = num;
				return this.f;
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00140A1C File Offset: 0x0013EC1C
		internal bool InitFlashkey(byte[] keyData, byte[] serialNumber, byte[] decData)
		{
			int a_ = 13;
			short num = (short)1312161793;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_226;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 2:
					goto IL_147;
				case 3:
				{
					if (serialNumber == null)
					{
						num = (short)1884291072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a = new byte[keyData.Length];
					global::System.Array.Copy(keyData, this.a, this.a.Length);
					this.c = new byte[serialNumber.Length];
					global::System.Array.Copy(serialNumber, this.c, this.c.Length);
					this.d = (short)serialNumber[0];
					this.b = new global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyLayout();
					num = (short)407335891;
					short num3 = num;
					num = (short)1897296851;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
						num = (short)1969815552;
						if (num != 0)
						{
						}
						num = (short)1227948034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_1B0;
				case 5:
					goto IL_60;
				}
				IL_46:
				if (keyData == null)
				{
					num = (short)2031621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)26345475;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_60:
				num = (short)1819082753;
				if (num != 0)
				{
				}
				num = (short)1966538752;
				short num4 = num;
				num = (short)777715716;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_147:
			bool flag = this.b.InitLayout(decData);
			if (flag)
			{
				this.e = global::System.Convert.ToInt32(this.b.GetFieldValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FileVersion, decData));
				this.f = this.b.KeyDecDataSize;
			}
			return flag;
			IL_1B0:
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮏ튕聯ﶛ", a_));
			IL_226:
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾕ聯튛춟삡솣풥", a_));
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00140C54 File Offset: 0x0013EE54
		internal bool UpdateUpgradesRemCounter(int howMany, ref byte[] decData)
		{
			int a_ = 1;
			short num = (short)1693712386;
			int num2 = (int)((global::System.IntPtr)num);
			bool result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A5;
				case 1:
				{
					int num3;
					if (howMany <= num3)
					{
						num = (short)692453379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = 0;
					this.b.SetFieldValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesRemaining, ref decData, num3);
					result = true;
					num = (short)2099380224;
					short num4 = num;
					num = (short)884801540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 3:
				{
					int num3;
					num3 -= howMany;
					this.b.SetFieldValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesRemaining, ref decData, num3);
					result = true;
					num = (short)1670119424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_1E0;
				case 5:
				{
					object fieldValue;
					int num3 = (int)global::System.Convert.ToInt16(fieldValue);
					num = (short)1791164417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
				{
					object fieldValue;
					if (fieldValue != null)
					{
						num = (short)1130102789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_227;
				}
				case 7:
				{
					object fieldValue = this.b.GetFieldValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesRemaining, decData);
					num = (short)124977158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					if (howMany > 0)
					{
						num = (short)1311703047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16F;
				case 9:
					goto IL_71;
				}
				IL_56:
				if (decData == null)
				{
					num = (short)1928003593;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					for (;;)
					{
						result = false;
						num = (short)1874422068;
						short num5 = num;
						num = (short)1856727348;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_122;
						}
					}
					IL_122:
					num = (short)1330184192;
					if (num != 0)
					{
					}
					num = (short)1754660872;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_71:
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캉揄", a_));
			IL_A5:
			goto IL_227;
			IL_16F:
			throw new global::System.ArgumentOutOfRangeException();
			IL_1E0:
			IL_227:
			num = (short)178913281;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00140EB4 File Offset: 0x0013F0B4
		internal object GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType fType, byte[] decData)
		{
			short num = (short)1150710020;
			short num2 = num;
			num = (short)253456644;
			switch (num2 == num)
			{
			}
			num = (short)664535041;
			if (num != 0)
			{
			}
			num = (short)1447952384;
			if (num != 0)
			{
			}
			num = (short)1920860160;
			short num3 = num;
			return this.b.GetFieldValue(fType, decData);
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00140F6C File Offset: 0x0013F16C
		internal int LayoutVersion
		{
			get
			{
				short num = (short)1617764245;
				short num2 = num;
				num = (short)928456597;
				switch (num2 == num)
				{
				}
				num = (short)1567424513;
				if (num != 0)
				{
				}
				num = (short)932446208;
				if (num != 0)
				{
				}
				num = (short)110886912;
				short num3 = num;
				return this.e;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0014101C File Offset: 0x0013F21C
		public short KeyType
		{
			get
			{
				short num = (short)250544129;
				if (num != 0)
				{
				}
				num = (short)1409991205;
				short num2 = num;
				num = (short)668254757;
				switch (num2 == num)
				{
				}
				num = (short)937820160;
				if (num != 0)
				{
				}
				num = (short)201654272;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x001410C8 File Offset: 0x0013F2C8
		internal void GetKeyData(out byte[] keyData)
		{
			short num;
			if (this.a != null)
			{
				num = (short)508950257;
				short num2 = num;
				num = (short)911734513;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1646526465;
					if (num != 0)
					{
					}
					num = (short)2083586048;
					if (num != 0)
					{
					}
					keyData = new byte[this.a.Length];
					global::System.Array.Copy(this.a, keyData, keyData.Length);
					return;
				}
			}
			num = (short)1911816192;
			short num3 = num;
			keyData = new byte[0];
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x001411A8 File Offset: 0x0013F3A8
		internal void StoreKeyData(byte[] keyData)
		{
			short num;
			if (this.a != null)
			{
				num = (short)376644296;
				short num2 = num;
				num = (short)1751065288;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1856897025;
					if (num != 0)
					{
					}
					num = (short)1207697408;
					if (num != 0)
					{
					}
					global::System.Array.Clear(this.a, 0, this.a.Length);
					global::System.Array.Resize<byte>(ref this.a, keyData.Length);
					global::System.Array.Copy(keyData, this.a, this.a.Length);
					return;
				}
			}
			num = (short)528023552;
			short num3 = num;
			this.a = new byte[keyData.Length];
			global::System.Array.Copy(keyData, this.a, this.a.Length);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x001412B8 File Offset: 0x0013F4B8
		internal void GetSerialNumber(out byte[] serial)
		{
			short num;
			if (this.c != null)
			{
				num = (short)2069189573;
				short num2 = num;
				num = (short)1982157765;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)691404800;
					if (num != 0)
					{
					}
					num = (short)1768816641;
					if (num != 0)
					{
					}
					serial = new byte[this.c.Length];
					global::System.Array.Copy(this.c, serial, serial.Length);
					return;
				}
			}
			num = (short)1456799744;
			short num3 = num;
			serial = new byte[0];
		}

		// Token: 0x0400077C RID: 1916
		private byte[] a;

		// Token: 0x0400077D RID: 1917
		private global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyLayout b;

		// Token: 0x0400077E RID: 1918
		private byte[] c;

		// Token: 0x0400077F RID: 1919
		private short d;

		// Token: 0x04000780 RID: 1920
		private int e;

		// Token: 0x04000781 RID: 1921
		private int f;
	}
}
