using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000097 RID: 151
	public class DataField : global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x00050818 File Offset: 0x0004EA18
		public DataField(string name, bool isVisible)
		{
			this.a = isVisible;
			base.Name = name;
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0005083C File Offset: 0x0004EA3C
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x000508EC File Offset: 0x0004EAEC
		public object Data
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)655949824;
				short num2 = num;
				num = (short)1360687259;
				short num3 = num;
				num = (short)1367699611;
				switch (num3 == num)
				{
				}
				num = (short)347340801;
				if (num != 0)
				{
				}
				num = (short)2031419392;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)228524032;
				short num2 = num;
				num = (short)1171453608;
				short num3 = num;
				num = (short)1197864616;
				switch (num3 == num)
				{
				}
				num = (short)168689664;
				if (num != 0)
				{
				}
				num = (short)133234689;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x000509A0 File Offset: 0x0004EBA0
		public override bool IsEditable
		{
			get
			{
				short num = (short)852754432;
				short num2 = num;
				num = (short)1818325272;
				short num3 = num;
				num = (short)2014933272;
				switch (num3 == num)
				{
				}
				num = (short)161742849;
				if (num != 0)
				{
				}
				num = (short)1987969024;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00050A48 File Offset: 0x0004EC48
		public override bool IsVisible
		{
			get
			{
				short num = (short)556859392;
				short num2 = num;
				num = (short)1706029447;
				short num3 = num;
				num = (short)213971335;
				switch (num3 == num)
				{
				}
				num = (short)1754791937;
				if (num != 0)
				{
				}
				num = (short)841154560;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00050AF8 File Offset: 0x0004ECF8
		public override bool IsPasteable
		{
			get
			{
				short num = (short)111017984;
				short num2 = num;
				num = (short)1489580344;
				short num3 = num;
				num = (short)1985818936;
				switch (num3 == num)
				{
				}
				num = (short)1038942209;
				if (num != 0)
				{
				}
				num = (short)1401880576;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00050BA0 File Offset: 0x0004EDA0
		public override string ValueForCompare
		{
			get
			{
				int a_ = 17;
				short num = (short)851836928;
				switch (num)
				{
				default:
				{
					num = (short)1153761281;
					if (num != 0)
					{
					}
					num = (short)80347136;
					short num2 = num;
					num = (short)715456514;
					int num3 = (int)((global::System.IntPtr)num);
					global::System.Text.StringBuilder stringBuilder;
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> enumerator;
						switch (num3)
						{
						case 0:
							try
							{
								num = (short)1776156672;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_111;
										}
										continue;
									case 1:
										num = (short)510722050;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_1AF;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)2046689281;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus featureOptionStatus = enumerator.Current;
										stringBuilder.Append(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("㝋繍ⵏ网⽓杕╗慙", a_), featureOptionStatus.FeatureName, featureOptionStatus.FeatureStatus));
										num = (short)993198084;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_15C:
									num = (short)1365966851;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_111:
									goto IL_15C;
								}
								IL_1AF:
								goto IL_2A8;
							}
							finally
							{
								for (;;)
								{
									IL_1B4:
									num = (short)791805954;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											goto IL_268;
										case 1:
											enumerator.Dispose();
											num = (short)1168244736;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
										{
											num = (short)1068342153;
											short num4 = num;
											num = (short)669096841;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_1B4;
											default:
												num = (short)1951203328;
												if (num != 0)
												{
												}
												switch (0)
												{
												case 0:
													goto IL_232;
												}
												continue;
											}
											break;
										}
										}
										IL_232:
										if (enumerator == null)
										{
											goto IL_26A;
										}
										num = (short)1298989057;
										num3 = (int)((global::System.IntPtr)num);
									}
								}
								IL_268:
								IL_26A:;
							}
							goto IL_26B;
						case 1:
							goto IL_26B;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_AC;
							}
							continue;
						}
						IL_AC:
						if (this.Data is global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)
						{
							num = (short)581566465;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AF;
						IL_26B:
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = this.Data as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
						stringBuilder = new global::System.Text.StringBuilder();
						enumerator = radioBase.RadioFeatureSet.GetEnumerator();
						num = (short)1199308800;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2A8:
					return stringBuilder.ToString();
					IL_2AF:
					return base.ValueForCompare;
				}
				}
			}
		}

		// Token: 0x04000292 RID: 658
		private bool a;

		// Token: 0x04000293 RID: 659
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private object b;
	}
}
