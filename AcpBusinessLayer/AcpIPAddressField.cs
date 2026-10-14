using System;
using AcpBusinessLayer.UndoRedo;
using AcpBusinessLayer.ValueConverters;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer
{
	// Token: 0x02000010 RID: 16
	[global::System.Serializable]
	public class AcpIPAddressField : global::AcpBusinessLayer.AcpFieldX<long, string>
	{
		// Token: 0x06000152 RID: 338 RVA: 0x00018D84 File Offset: 0x00016F84
		public AcpIPAddressField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(parent, name, uiLabel)
		{
			base.Converter = new global::AcpBusinessLayer.ValueConverters.IPAddressConverter();
			if (base.Parent.Parent != null)
			{
				((global::AcpBusinessLayer.FeatureNode)base.Parent.Parent).RegisterValidity(this);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00018DCC File Offset: 0x00016FCC
		public AcpIPAddressField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : base(parent, name, uiLabel, legacyUILabels)
		{
			base.Converter = new global::AcpBusinessLayer.ValueConverters.IPAddressConverter();
			if (base.Parent.Parent != null)
			{
				((global::AcpBusinessLayer.FeatureNode)base.Parent.Parent).RegisterValidity(this);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00018E18 File Offset: 0x00017018
		public AcpIPAddressField(long value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(value, parent, name, uiLabel)
		{
			base.Converter = new global::AcpBusinessLayer.ValueConverters.IPAddressConverter();
			base.ForceValid = this.ValidateHelper();
			if (base.Parent.Parent != null)
			{
				((global::AcpBusinessLayer.FeatureNode)base.Parent.Parent).RegisterValidity(this);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00018E70 File Offset: 0x00017070
		public AcpIPAddressField(long value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : base(value, parent, name, uiLabel, legacyUILabels)
		{
			base.Converter = new global::AcpBusinessLayer.ValueConverters.IPAddressConverter();
			base.ForceValid = this.ValidateHelper();
			if (base.Parent.Parent != null)
			{
				((global::AcpBusinessLayer.FeatureNode)base.Parent.Parent).RegisterValidity(this);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00018EC8 File Offset: 0x000170C8
		private byte[] a(bool A_0)
		{
			while (!A_0)
			{
				short num = (short)455286115;
				short num2 = num;
				num = (short)1291787619;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1603796992;
					if (num != 0)
					{
					}
					num = (short)1599143936;
					short num3 = num;
					num = (short)1709834241;
					if (num != 0)
					{
					}
					long value = this.Value;
					return new byte[]
					{
						(byte)value,
						(byte)(value >> 8),
						(byte)(value >> 16),
						(byte)(value >> 24)
					};
				}
				}
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00018FA4 File Offset: 0x000171A4
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00019064 File Offset: 0x00017264
		public byte[] AddressBytes
		{
			get
			{
				short num = (short)840892416;
				short num2 = num;
				num = (short)1178351335;
				short num3 = num;
				num = (short)2120365799;
				switch (num3 == num)
				{
				}
				num = (short)1336868864;
				if (num != 0)
				{
				}
				num = (short)462749697;
				if (num != 0)
				{
				}
				byte[] array = new byte[16];
				this.a(false).CopyTo(array, 12);
				return array;
			}
			set
			{
				short num = (short)668401664;
				short num2 = num;
				num = (short)63283840;
				short num3 = num;
				num = (short)929538688;
				switch (num3 == num)
				{
				}
				num = (short)1058603008;
				if (num != 0)
				{
				}
				num = (short)1685192705;
				if (num != 0)
				{
				}
				long num4 = (long)((ulong)value[12]);
				num4 += (long)((long)((ulong)value[13]) << 8);
				num4 += (long)((long)((ulong)value[14]) << 16);
				num4 += (long)((long)((ulong)value[15]) << 24);
				this.Value = num4;
				base.ForceValid = this.ValidateHelper();
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00019148 File Offset: 0x00017348
		public override void ParseDefaultValueFrom(string value)
		{
			short num;
			try
			{
				num = (short)373499398;
				short num2 = num;
				num = (short)430777862;
				switch (num2 == num)
				{
				}
				num = (short)337051649;
				if (num != 0)
				{
				}
				num = (short)1302396928;
				if (num != 0)
				{
				}
				this.DefaultValue = (long)base.Converter.ConvertBack(value, null, base.Parent, null);
			}
			catch
			{
			}
			num = (short)459669504;
			short num3 = num;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00019224 File Offset: 0x00017424
		public override void ParseValueFrom(string value)
		{
			short num;
			try
			{
				num = (short)1547108353;
				if (num != 0)
				{
				}
				num = (short)1017371325;
				short num2 = num;
				num = (short)631429821;
				switch (num2 == num)
				{
				}
				num = (short)382205952;
				if (num != 0)
				{
				}
				base.UnsupportedValue = false;
				base.ForceValid = this.ValidateHelper();
				this.UIValue = value;
			}
			catch (global::System.Exception)
			{
				base.UnsupportedValue = true;
			}
			num = (short)1424818176;
			short num3 = num;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00019300 File Offset: 0x00017500
		public override void CalculateValidity()
		{
			short num = (short)771096580;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2076114945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (!base.UIInvalid)
					{
						num = (short)1953759234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)542769160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 5:
				{
					num = (short)842605909;
					short num3 = num;
					num = (short)639313237;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_52;
					default:
						num = (short)1346568193;
						if (num != 0)
						{
						}
						num = (short)1966342144;
						if (num != 0)
						{
						}
						if (base.Applicable)
						{
							num = (short)1417478144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 6:
					this.ValidityHelper();
					num = (short)1938358279;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_FD;
				case 8:
					if (base.ForceValid)
					{
						num = (short)842792966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_48;
				IL_52:
				num = (short)1723793411;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_48:
				if (global::AcpBusinessLayer.AcpDocument.Closing)
				{
					goto IL_52;
				}
				num = (short)1102970885;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_FD:
			num = (short)529203200;
			short num4 = num;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000194EC File Offset: 0x000176EC
		public override void SetValue(long newValue)
		{
			switch (0)
			{
			case 0:
				goto IL_6E;
			}
			short num;
			int num2;
			global::AcpBusinessLayer.FeatureNode featureNode;
			for (;;)
			{
				IL_0A:
				num = (short)690880513;
				if (num != 0)
				{
				}
				global::AcpCommonLib.Document containerDoc;
				switch (num2)
				{
				case 0:
				{
					num = (short)1900478464;
					short num3 = num;
					global::AcpBusinessLayer.Recordset recordset;
					containerDoc = recordset.ContainerDoc;
					num = (short)1757216770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)1435369484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (containerDoc != null)
					{
						num = (short)432537601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_243;
				case 3:
				{
					global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)featureNode.Parent;
					num = (short)1984888836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					global::AcpBusinessLayer.Recordset recordset;
					if (recordset != null)
					{
						num = (short)949223424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_243;
				}
				case 5:
					num = (short)547422218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1FA;
				case 7:
				{
					num = (short)1504052396;
					short num4 = num;
					num = (short)1650132140;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14A;
					default:
						num = (short)982646784;
						if (num != 0)
						{
						}
						if (featureNode != null)
						{
							num = (short)1876885509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_243;
					}
					break;
				}
				case 8:
					containerDoc.AddToModificationLog(base.BuildModificationLog(this.Value, newValue));
					num = (short)1725562893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (!global::AcpCommonLib.ConstraintManager.Suspended)
					{
						num = (short)2082275339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E9;
				case 10:
					if (newValue.CompareTo(this.Value) != 0)
					{
						num = (short)1011679235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_243;
				case 11:
					base.CallConstraintsX();
					num = (short)1013317638;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_14A;
				case 13:
					goto IL_243;
				}
				goto IL_6E;
				IL_14A:
				if (containerDoc.ModificationLogEnabled)
				{
					num = (short)1830813704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_243:
				base.SetValueNoConstraints(newValue);
				this.ValueChanged = true;
				base.ForceValid = this.ValidateHelper();
				base.UIInvalid = !base.ForceValid;
				num = (short)299433993;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1FA:
			IL_2E9:
			base.SetUITimer();
			this.FirePropertyChangedEvent();
			return;
			IL_6E:
			featureNode = (global::AcpBusinessLayer.FeatureNode)base.Parent.Parent;
			num = (short)1335361543;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000197F0 File Offset: 0x000179F0
		// (set) Token: 0x0600015E RID: 350 RVA: 0x000198A0 File Offset: 0x00017AA0
		public override long Value
		{
			get
			{
				short num = (short)2068705174;
				short num2 = num;
				num = (short)1927081878;
				switch (num2 == num)
				{
				}
				num = (short)1559298049;
				if (num != 0)
				{
				}
				num = (short)243466240;
				short num3 = num;
				num = (short)1930428416;
				if (num != 0)
				{
				}
				return base.Value;
			}
			set
			{
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
						goto IL_55;
					case 1:
						goto IL_B5;
					case 2:
						if (base.UIInvalid)
						{
							num2 = (short)1691222016;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B5;
					}
					goto IL_1C;
					IL_55:
					num2 = (short)1136001024;
					short num3 = num2;
					base.DirectUIValue = base.Converter.Convert(value, null, null, null).ToString();
					num2 = (short)787480577;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_B5:
					num2 = (short)560988763;
					short num4 = num2;
					num2 = (short)343999067;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_55;
					default:
						goto IL_E9;
					}
				}
				IL_E9:
				num2 = (short)428474368;
				if (num2 != 0)
				{
				}
				num2 = (short)23199745;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				base.Value = value;
				num2 = (short)2070806530;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000199D4 File Offset: 0x00017BD4
		public override global::AcpCommonLib.UndoRedo.UndoableTask CopyValueOf(global::AcpCommonLib.IAcpField source)
		{
			short num = (short)1946091520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				global::AcpBusinessLayer.UndoRedo.SetValueTask setValueTask;
				long value;
				long value2;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (base.ValueSetter != null)
						{
							num = (short)1279000578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return setValueTask;
					case 1:
					{
						num = (short)98555454;
						short num3 = num;
						num = (short)161338942;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18A;
						default:
						{
							num = (short)2035548161;
							if (num != 0)
							{
							}
							num = (short)945094656;
							if (num != 0)
							{
							}
							num = (short)1364590592;
							short num4 = num;
							setValueTask = new global::AcpBusinessLayer.UndoRedo.SetValueTask(this, source.ToString());
							num = (short)843251712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_18A;
					case 3:
						if (!value.Equals(value2))
						{
							num = (short)1495400449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return setValueTask;
					}
					goto IL_3E;
				}
				IL_18A:
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(setValueTask.ToString());
				containerTask.AddTask(setValueTask);
				this.CallValueSetter(containerTask);
				return containerTask;
				IL_3E:
				setValueTask = null;
				value2 = ((global::AcpBusinessLayer.AcpIPAddressField)source).Value;
				value = this.Value;
				num = (short)524222467;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00019B70 File Offset: 0x00017D70
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00019C28 File Offset: 0x00017E28
		public bool SkipValidation
		{
			get
			{
				short num = (short)1875574785;
				if (num != 0)
				{
				}
				num = (short)119187907;
				short num2 = num;
				num = (short)543664579;
				switch (num2 == num)
				{
				}
				num = (short)336527360;
				short num3 = num;
				num = (short)1745158144;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.SkipValidation) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				int a_ = 1;
				short num = (short)868417537;
				if (num != 0)
				{
				}
				if (value)
				{
					for (;;)
					{
						num = (short)1993015296;
						short num2 = num;
						num = (short)552135097;
						short num3 = num;
						num = (short)1381951929;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_95;
						}
					}
					IL_95:
					num = (short)470482944;
					if (num != 0)
					{
					}
					this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.SkipValidation;
					return;
				}
				throw new global::System.InvalidOperationException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("蟒뷔뻖꫘ﯚ규귞軠鏢胤闦鷨鋪췬賮郰鷲鯴飶跸\udbfa鿼髾℀焂怄理氈缊⌌", a_));
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00019D08 File Offset: 0x00017F08
		protected override bool ValidateHelper()
		{
			short num = (short)142475304;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)305856523;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					byte[] array;
					if (array[3] != 0)
					{
						num = (short)158597167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 2:
					num = (short)1306263553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					byte[] array;
					if (array[3] == 255)
					{
						num = (short)1609302051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 4:
					num = (short)1504903190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					byte[] array;
					if (array[2] == 0)
					{
						num = (short)478937090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_395;
				}
				case 6:
					goto IL_6C7;
				case 7:
				{
					num = (short)2096693249;
					if (num != 0)
					{
					}
					byte b;
					if (b == 128)
					{
						num = (short)952107025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C7;
				}
				case 8:
					num = (short)1582956549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					byte[] array;
					if (array[3] == 255)
					{
						num = (short)467861524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 10:
				{
					byte b;
					if (b == 192)
					{
						num = (short)49479680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D9;
				}
				case 11:
				{
					byte[] array;
					if (array[1] == 0)
					{
						num = (short)1468334093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D9;
				}
				case 12:
				{
					byte[] array;
					if (array[2] == 255)
					{
						num = (short)704446500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 13:
					num = (short)1979842604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_273;
				case 15:
				{
					byte b;
					if (b >= 192)
					{
						num = (short)1043202069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)710737965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 16:
				{
					byte b;
					if (b <= 223)
					{
						num = (short)1614282785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 17:
					num = (short)1166868508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
				{
					byte b;
					if (b != 127)
					{
						num = (short)140771367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 19:
				{
					byte[] array;
					if (array[3] == 0)
					{
						num = (short)1985675305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 20:
					goto IL_684;
				case 21:
					num = (short)1710358538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
				{
					byte[] array;
					if (array[3] != 255)
					{
						num = (short)1806958606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 23:
					goto IL_6C0;
				case 24:
					num = (short)242352140;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					num = (short)1148649475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_488;
				case 27:
				{
					num = (short)269877060;
					short num3 = num;
					num = (short)1754857284;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6C0;
					default:
						num = (short)1776287744;
						if (num != 0)
						{
						}
						num = (short)199163936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 28:
				{
					byte[] array;
					if (array[1] != 0)
					{
						num = (short)1800798214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 29:
				{
					byte b;
					if (b == 0)
					{
						num = (short)585957402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)594149391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 30:
					goto IL_44E;
				case 31:
				{
					byte[] array;
					if (array[2] == 255)
					{
						num = (short)1413480452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_273;
				}
				case 32:
				{
					if (this.SkipValidation)
					{
						num = (short)183238686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					byte[] array = this.a(false);
					byte b = array[0];
					num = (short)1137115152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 33:
					num = (short)2142044178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
				{
					byte[] array;
					if (array[1] == 255)
					{
						num = (short)423690264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 35:
					return false;
				case 36:
					num = (short)278265865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
				{
					byte[] array;
					if (array[1] == 0)
					{
						num = (short)717946888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_395;
				}
				case 38:
				{
					byte[] array;
					if (array[2] == 0)
					{
						num = (short)1959198766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 39:
					num = (short)796262429;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					switch (0)
					{
					case 0:
						goto IL_E6;
					}
					continue;
				case 41:
					goto IL_1BA;
				case 42:
				{
					byte[] array;
					if (array[3] != 0)
					{
						num = (short)1538261017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 43:
					goto IL_3D9;
				case 44:
				{
					byte[] array;
					if (array[2] != 0)
					{
						num = (short)1979645995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 45:
				{
					byte b;
					if (b >= 128)
					{
						num = (short)2042691607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)892469285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 46:
				{
					num = (short)1183973376;
					short num4 = num;
					num = (short)1291911187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 47:
					goto IL_395;
				}
				IL_E6:
				if (this.Value != 0L)
				{
					num = (short)195887131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_273:
				num = (short)1976369190;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_395:
				num = (short)1204879394;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D9:
				num = (short)2141192234;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6C0:
				num = (short)1238499335;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6C7:
				num = (short)1247084575;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1BA:
			return false;
			IL_44E:
			return true;
			IL_488:
			return false;
			IL_684:
			return false;
		}
	}
}
