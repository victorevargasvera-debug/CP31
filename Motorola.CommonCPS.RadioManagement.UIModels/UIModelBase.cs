using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.ViewModel;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000009 RID: 9
	public abstract class UIModelBase : global::Microsoft.Practices.Prism.ViewModel.NotificationObject, global::System.ComponentModel.IDataErrorInfo, global::System.ICloneable
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00007250 File Offset: 0x00005450
		public UIModelBase()
		{
			base.PropertyChanged += this.a;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00007278 File Offset: 0x00005478
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00007328 File Offset: 0x00005528
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual string Comments
		{
			get
			{
				short num = (short)140503981;
				short num2 = num;
				num = (short)443476909;
				switch (num2 == num)
				{
				}
				num = (short)1046478849;
				if (num != 0)
				{
				}
				num = (short)76742656;
				if (num != 0)
				{
				}
				num = (short)1914634240;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)552337414;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value != this.a)
						{
							goto IL_1B4;
						}
						return;
					case 1:
						value = string.Empty;
						num = (short)173473799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						num = (short)262799365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_F8;
					case 5:
						if (string.IsNullOrEmpty(value))
						{
							num = (short)721944576;
							short num3 = num;
							num = (short)1477705732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a = value.Trim();
						num = (short)282198018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					case 7:
						goto IL_143;
					}
					IL_44:
					if (string.IsNullOrEmpty(value))
					{
						num = (short)1632436225;
						if (num != 0)
						{
						}
						num = (short)1157758977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_143:
					num = (short)2000312011;
					short num4 = num;
					num = (short)1789875915;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_1B4:
						num = (short)890372099;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1196949504;
						if (num != 0)
						{
						}
						num = (short)767688704;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_F8:
				this.a = string.Empty;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00007508 File Offset: 0x00005708
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000075B8 File Offset: 0x000057B8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual global::System.Guid? ID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1386118711;
				short num2 = num;
				num = (short)1510702647;
				switch (num2 == num)
				{
				}
				num = (short)191102976;
				if (num != 0)
				{
				}
				num = (short)1722810369;
				if (num != 0)
				{
				}
				num = (short)1105788928;
				short num3 = num;
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)822870017;
				if (num != 0)
				{
				}
				num = (short)947235497;
				short num2 = num;
				num = (short)1779542697;
				switch (num2 == num)
				{
				}
				num = (short)33947648;
				if (num != 0)
				{
				}
				num = (short)1014169600;
				short num3 = num;
				this.g = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00007668 File Offset: 0x00005868
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00007718 File Offset: 0x00005918
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool Reserved
		{
			get
			{
				short num = (short)585472015;
				short num2 = num;
				num = (short)543266831;
				switch (num2 == num)
				{
				}
				num = (short)1262682113;
				if (num != 0)
				{
				}
				num = (short)1563099136;
				if (num != 0)
				{
				}
				num = (short)1166999552;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)832765953;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_15;
					case 2:
						this.c = value;
						num = (short)1919746048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_31;
					IL_15:
					switch (0)
					{
					case 0:
					{
						IL_31:
						num = (short)937426944;
						short num3 = num;
						num = (short)603521025;
						if (num != 0)
						{
						}
						num = (short)1949872193;
						short num4 = num;
						num = (short)850440257;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
							num = (short)387448832;
							if (num != 0)
							{
							}
							if (value == this.c)
							{
								return;
							}
							num = (short)1627848706;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00007838 File Offset: 0x00005A38
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000078E8 File Offset: 0x00005AE8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual int IndexInGrid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1660281507;
				short num2 = num;
				num = (short)1990124195;
				switch (num2 == num)
				{
				}
				num = (short)755957761;
				if (num != 0)
				{
				}
				num = (short)537067520;
				if (num != 0)
				{
				}
				num = (short)1159790592;
				short num3 = num;
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1466706895;
				short num2 = num;
				num = (short)1233136591;
				switch (num2 == num)
				{
				}
				num = (short)110034944;
				if (num != 0)
				{
				}
				num = (short)813039617;
				if (num != 0)
				{
				}
				num = (short)1185742848;
				short num3 = num;
				this.h = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00007994 File Offset: 0x00005B94
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00007A44 File Offset: 0x00005C44
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate Validator
		{
			get
			{
				short num = (short)1035694758;
				short num2 = num;
				num = (short)1265529510;
				switch (num2 == num)
				{
				}
				num = (short)287440896;
				if (num != 0)
				{
				}
				num = (short)884408321;
				if (num != 0)
				{
				}
				num = (short)1855979520;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)686030851;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.a(null);
						goto IL_89;
					case 1:
						return;
					case 2:
						this.e = value;
						num = (short)623378436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)132513793;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 4:
					{
						if (this.e == null)
						{
							return;
						}
						num = (short)1841269179;
						short num3 = num;
						num = (short)215255483;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_89;
						default:
						{
							num = (short)1006239744;
							if (num != 0)
							{
							}
							num = (short)1023279104;
							short num4 = num;
							num = (short)1137115136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_60:
					if (this.e != value)
					{
						num = (short)492830722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_89:
					num = (short)1021313025;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00007BAC File Offset: 0x00005DAC
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00007C5C File Offset: 0x00005E5C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool IsLoading
		{
			get
			{
				short num = (short)701710520;
				short num2 = num;
				num = (short)1733378232;
				switch (num2 == num)
				{
				}
				num = (short)179896321;
				if (num != 0)
				{
				}
				num = (short)544931840;
				if (num != 0)
				{
				}
				num = (short)172949504;
				short num3 = num;
				return this.f;
			}
			set
			{
				short num = (short)880956357;
				short num2 = num;
				num = (short)1464751045;
				switch (num2 == num)
				{
				}
				num = (short)818348033;
				if (num != 0)
				{
				}
				num = (short)14614528;
				if (num != 0)
				{
				}
				num = (short)3145728;
				short num3 = num;
				this.f = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00007D0C File Offset: 0x00005F0C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string Error
		{
			get
			{
				short num = (short)1232266585;
				short num2 = num;
				num = (short)1186587993;
				switch (num2 == num)
				{
				}
				num = (short)1655504897;
				if (num != 0)
				{
				}
				num = (short)1183252480;
				if (num != 0)
				{
				}
				num = (short)1476591616;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x17000033 RID: 51
		public virtual string this[string propertyName]
		{
			get
			{
				short num = (short)1452016932;
				short num2 = num;
				num = (short)711329060;
				switch (num2 == num)
				{
				}
				num = (short)1552285697;
				if (num != 0)
				{
				}
				num = (short)332857344;
				if (num != 0)
				{
				}
				num = (short)734986240;
				short num3 = num;
				return null;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007E64 File Offset: 0x00006064
		public virtual void CleanErrors()
		{
			short num = (short)891818993;
			short num2 = num;
			num = (short)2076120049;
			switch (num2 == num)
			{
			}
			num = (short)1225326593;
			if (num != 0)
			{
			}
			num = (short)245628928;
			if (num != 0)
			{
			}
			num = (short)2136342528;
			short num3 = num;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007F0C File Offset: 0x0000610C
		public virtual bool IsValidRecord()
		{
			short num = (short)196542222;
			short num2 = num;
			num = (short)76873486;
			switch (num2 == num)
			{
			}
			num = (short)707264513;
			if (num != 0)
			{
			}
			num = (short)1399914496;
			if (num != 0)
			{
			}
			num = (short)399966208;
			short num3 = num;
			return true;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00007FB4 File Offset: 0x000061B4
		public virtual global::System.Collections.Generic.Dictionary<string, string> InvalidFieldErrorInfo()
		{
			short num = (short)2071068673;
			if (num != 0)
			{
			}
			num = (short)1822379600;
			short num2 = num;
			num = (short)237588048;
			switch (num2 == num)
			{
			}
			num = (short)108855296;
			if (num != 0)
			{
			}
			num = (short)129564672;
			short num3 = num;
			return new global::System.Collections.Generic.Dictionary<string, string>();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008060 File Offset: 0x00006260
		public virtual bool IsNewVersion(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase sourceUIMode)
		{
			short num = (short)1949678658;
			short num2 = num;
			num = (short)1956428866;
			switch (num2 == num)
			{
			}
			num = (short)150536192;
			if (num != 0)
			{
			}
			num = (short)1302724609;
			if (num != 0)
			{
			}
			num = (short)173015040;
			short num3 = num;
			return true;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000810C File Offset: 0x0000630C
		public void InvokeRaisePropertyChanged(string propertyName)
		{
			short num = (short)343005181;
			short num2 = num;
			num = (short)1735776253;
			switch (num2 == num)
			{
			}
			num = (short)876871680;
			if (num != 0)
			{
			}
			num = (short)1556283393;
			if (num != 0)
			{
			}
			num = (short)1001127936;
			short num3 = num;
			this.RaisePropertyChanged(propertyName);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000081B8 File Offset: 0x000063B8
		public virtual object Clone()
		{
			short num = (short)1334058705;
			short num2 = num;
			num = (short)1545084625;
			switch (num2 == num)
			{
			}
			num = (short)522911745;
			if (num != 0)
			{
			}
			num = (short)137297920;
			if (num != 0)
			{
			}
			num = (short)252706816;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = (global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase)base.MemberwiseClone();
			uimodelBase.CleanEventHandler();
			return uimodelBase;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00008274 File Offset: 0x00006474
		protected bool Validate(string error)
		{
			short num = (short)1087542379;
			short num2 = num;
			num = (short)1519948907;
			switch (num2 == num)
			{
			}
			num = (short)259784705;
			if (num != 0)
			{
			}
			num = (short)986710016;
			if (num != 0)
			{
			}
			num = (short)962723840;
			short num3 = num;
			bool flag = string.IsNullOrEmpty(error);
			this.b = (flag ? string.Empty : error);
			return flag;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00008340 File Offset: 0x00006540
		protected void CleanEventHandler()
		{
			short num = (short)2040909767;
			short num2 = num;
			num = (short)932958151;
			switch (num2 == num)
			{
			}
			num = (short)533135360;
			if (num != 0)
			{
			}
			num = (short)851443713;
			if (num != 0)
			{
			}
			num = (short)38141952;
			short num3 = num;
			this.a();
			base.PropertyChanged += this.a;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008404 File Offset: 0x00006604
		private void a()
		{
			int a_ = 6;
			short num = (short)1769340928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				global::System.Delegate @delegate;
				global::System.Reflection.EventInfo @event;
				for (;;)
				{
					IL_31:
					global::System.Delegate[] array;
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_CE;
					case 1:
						goto IL_CE;
					case 2:
						goto IL_E6;
					case 3:
					{
						global::System.Delegate[] invocationList = @delegate.GetInvocationList();
						array = invocationList;
						num3 = 0;
						num = (short)436656631;
						short num4 = num;
						num = (short)1081530871;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E6;
						default:
						{
							num = (short)575537152;
							if (num != 0)
							{
							}
							num = (short)1604255745;
							if (num != 0)
							{
							}
							num = (short)1226047488;
							short num5 = num;
							num = (short)518324225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						if (@delegate != null)
						{
							num = (short)1999175683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						return;
					}
					goto IL_50;
					IL_CE:
					num = (short)1191837698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E6:
					if (num3 >= array.Length)
					{
						num = (short)1921843205;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::System.Delegate handler = array[num3];
						@event.RemoveEventHandler(this, handler);
						num3++;
						num = (short)1690107904;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_50:
				global::System.Type typeFromHandle = typeof(global::Microsoft.Practices.Prism.ViewModel.NotificationObject);
				@event = typeFromHandle.GetEvent(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅀㅂ⩄㝆ⱈ㥊㥌㙎ቐ㭒㑔㥖㹘㹚㥜", a_));
				global::System.Reflection.FieldInfo field = typeFromHandle.GetField(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅀㅂ⩄㝆ⱈ㥊㥌㙎ቐ㭒㑔㥖㹘㹚㥜", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
				object value = field.GetValue(this);
				@delegate = (value as global::System.Delegate);
				num = (short)98893828;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008614 File Offset: 0x00006814
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)2081997119;
					short num3 = num2;
					num2 = (short)726516031;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)230293504;
						if (num2 != 0)
						{
						}
						if (A_1.PropertyName.EndsWith(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("୍≏⁑㭓⑕", a_), global::System.StringComparison.Ordinal))
						{
							num2 = (short)1886257154;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 2:
				{
					this.RaisePropertyChanged(A_1.PropertyName.Substring(0, A_1.PropertyName.Length - 5));
					num2 = (short)649068544;
					short num4 = num2;
					num2 = (short)921305088;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_25;
			}
			return;
			IL_25:
			this.a(A_1);
			num2 = (short)1300627457;
			if (num2 != 0)
			{
			}
			num2 = (short)474284033;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00008770 File Offset: 0x00006970
		private void a(global::System.ComponentModel.PropertyChangedEventArgs A_0)
		{
			int a_ = 12;
			short num2;
			for (;;)
			{
				if (!this.d)
				{
					try
					{
						switch (0)
						{
						case 0:
							goto IL_4A;
						}
						int num;
						for (;;)
						{
							IL_20:
							switch (num)
							{
							case 0:
								if (this.Validator != null)
								{
									num2 = (short)1419968513;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_147;
							case 1:
								this.Validator.Validate(this, A_0);
								num2 = (short)1916141573;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								num2 = (short)1572405254;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								num2 = (short)1843527688;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								goto IL_15F;
							case 5:
								goto IL_147;
							case 6:
								if (A_0.PropertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᕆⱈ㡊⡌㵎❐㙒ㅔ", a_))
								{
									num2 = (short)1944125443;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_10D;
							case 7:
								if (A_0 != null)
								{
									num2 = (short)1227751426;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_10D;
							case 8:
								goto IL_10B;
							}
							goto IL_4A;
							IL_10D:
							num2 = (short)867893248;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_147:
							num2 = (short)451149828;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_10B:
						IL_15F:
						goto IL_169;
						IL_4A:
						this.d = true;
						num2 = (short)1397882887;
						num = (int)((global::System.IntPtr)num2);
						goto IL_20;
					}
					finally
					{
						this.d = false;
					}
				}
				IL_169:
				num2 = (short)858182119;
				short num3 = num2;
				num2 = (short)719245799;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1A0;
				}
			}
			IL_1A0:
			num2 = (short)179896320;
			if (num2 != 0)
			{
			}
			num2 = (short)1169817600;
			short num4 = num2;
			num2 = (short)1235091457;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x04000009 RID: 9
		private string a;

		// Token: 0x0400000A RID: 10
		private string b;

		// Token: 0x0400000B RID: 11
		private bool c;

		// Token: 0x0400000C RID: 12
		private bool d;

		// Token: 0x0400000D RID: 13
		private global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate e;

		// Token: 0x0400000E RID: 14
		private bool f;

		// Token: 0x0400000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid? g;

		// Token: 0x04000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int h;
	}
}
