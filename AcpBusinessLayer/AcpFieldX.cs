using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer
{
	// Token: 0x0200000E RID: 14
	[global::System.Diagnostics.DebuggerDisplay("Name={UIName}, UIValue={UIValue}")]
	[global::System.Serializable]
	public class AcpFieldX<TDBType, TUIType> : global::AcpBusinessLayer.AcpField<TDBType> where TDBType : global::System.IComparable where TUIType : global::System.IComparable
	{
		// Token: 0x06000128 RID: 296 RVA: 0x000172CC File Offset: 0x000154CC
		protected AcpFieldX()
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000172E0 File Offset: 0x000154E0
		protected AcpFieldX(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(parent, name, uiLabel)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000172F8 File Offset: 0x000154F8
		protected AcpFieldX(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : base(parent, name, uiLabel, legacyUILabels)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00017310 File Offset: 0x00015510
		protected AcpFieldX(TDBType value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(value, parent, name, uiLabel)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00017328 File Offset: 0x00015528
		protected AcpFieldX(TDBType value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : base(value, parent, name, uiLabel, legacyUILabels)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00017344 File Offset: 0x00015544
		public AcpFieldX(TDBType value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(value, parent, name, uiLabel)
		{
			this.Converter = converter;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00017364 File Offset: 0x00015564
		public AcpFieldX(TDBType value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : base(value, parent, name, uiLabel, legacyUILabels)
		{
			this.Converter = converter;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00017388 File Offset: 0x00015588
		public AcpFieldX(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : this(parent, name, uiLabel)
		{
			this.Converter = converter;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000173A8 File Offset: 0x000155A8
		public AcpFieldX(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : this(parent, name, uiLabel, legacyUILabels)
		{
			this.Converter = converter;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000173C8 File Offset: 0x000155C8
		protected AcpFieldX(TUIType uiValue, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : this(parent, name, uiLabel)
		{
			this.Converter = converter;
			this.UIValue = uiValue;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000173F0 File Offset: 0x000155F0
		// (set) Token: 0x06000133 RID: 307 RVA: 0x000174A4 File Offset: 0x000156A4
		public global::System.Windows.Data.IValueConverter Converter
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)10380054;
				short num2 = num;
				num = (short)41247510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)586809344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)868941824;
				if (num != 0)
				{
				}
				num = (short)2063597569;
				if (num != 0)
				{
				}
				return this.<Converter>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)19491960;
				short num2 = num;
				num = (short)1746889848;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2059468800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)841940993;
				if (num != 0)
				{
				}
				num = (short)2050883584;
				if (num != 0)
				{
				}
				this.<Converter>k__BackingField = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00017558 File Offset: 0x00015758
		public object ConverterParameterObject
		{
			get
			{
				short num = (short)1914932089;
				short num2 = num;
				num = (short)722504569;
				switch (num2 == num)
				{
				default:
				{
					num = (short)799211520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)513277952;
				if (num != 0)
				{
				}
				num = (short)1530593281;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00017604 File Offset: 0x00015804
		// (set) Token: 0x06000136 RID: 310 RVA: 0x000176E4 File Offset: 0x000158E4
		public virtual TUIType UIValue
		{
			get
			{
				if (base.UIInvalid)
				{
					short num = (short)1374866880;
					short num2 = num;
					num = (short)1887686080;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A8;
					case 1:
						break;
					default:
					{
						num = (short)2000289792;
						short num3 = num;
						break;
					}
					}
					num = (short)600965120;
					if (num != 0)
					{
					}
					num = (short)1983250433;
					if (num != 0)
					{
					}
					IL_A8:
					return this.DirectUIValue;
				}
				return (TUIType)((object)this.Converter.Convert(this.Value, null, this.ConverterParameterObject, null));
			}
			set
			{
				int a_ = 8;
				short num = (short)1892745216;
				switch (num)
				{
				default:
				{
					num = (short)266862594;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						bool uiinvalid;
						switch (num2)
						{
						case 0:
							num = (short)907870209;
							if (num != 0)
							{
							}
							if (base.UIInvalid)
							{
								num = (short)234356740;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							try
							{
								num = (short)102301696;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1DE;
										}
										continue;
									case 1:
										if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
										{
											num = (short)726401027;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_24A;
									case 2:
										goto IL_28E;
									case 3:
										goto IL_248;
									case 4:
										num = (short)1553268737;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1DE:
									if (base.UIInvalid)
									{
										num = (short)2071592964;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_24A:
									this.Value = (TDBType)((object)this.Converter.ConvertBack(value, null, this.ConverterParameterObject, null));
									base.UIInvalid = false;
									num = (short)669450242;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_248:
								throw new global::System.FormatException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("軙듛믝샟蟡鳣迥鯧黩藫胭韯틱胳鏵胷軹\udcfb韽珿∁儃伅䄇搉程漍簏笑瀓㠕㠗夙紛瀝丟䴡倣إ䬧堩䤫伭䐯圱ᐳ圵ᠷ眹医娽⤿⑁㵃Ʌ⥇㹉ⵋᩍㅏ⅑㽓硕", a_));
								IL_28E:
								return;
							}
							catch (global::System.Exception)
							{
								if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
								{
									global::AcpCommonLib.UndoRedo.UndoableTask undoableTask = new global::AcpBusinessLayer.UndoRedo.ModifyUIValueTask<TUIType>(this, value);
									if (base.ValueSetter != null)
									{
										global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(undoableTask.ToString());
										containerTask.AddTask(undoableTask);
										this.CallValueSetter(containerTask);
										global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
									}
									else
									{
										global::AcpCommonLib.UndoRedo.UndoManager.AddTask(undoableTask);
									}
								}
								else
								{
									this.DirectUIValue = value;
									base.UIInvalid = true;
									uiinvalid = base.UIInvalid;
								}
								return;
							}
							finally
							{
								num = (short)1677721602;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									num = (short)227004144;
									short num3 = num;
									num = (short)1018154736;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1281490944;
										if (num != 0)
										{
										}
										switch (num2)
										{
										case 0:
											goto IL_3AD;
										case 1:
											goto IL_38B;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_372;
											}
											continue;
										}
										IL_372:
										if (uiinvalid)
										{
											num = (short)1674641409;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3AF;
									}
									IL_38B:
									this.FirePropertyChangedEvent();
									num = (short)1965621248;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3AD:
								IL_3AF:;
							}
							goto IL_3B0;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_72;
							}
							continue;
						case 3:
						{
							TUIType uivalue;
							if (uivalue.CompareTo(value) == 0)
							{
								num = (short)1870790661;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C1;
						}
						case 4:
							goto IL_3B0;
						case 5:
							num = (short)1355743232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
							{
								num = (short)1356333064;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C1;
						case 7:
						{
							num = (short)537657344;
							short num4 = num;
							TUIType uivalue = this.UIValue;
							num = (short)918814723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_3ED;
						}
						IL_72:
						if (this.UIValue != null)
						{
							num = (short)1115357191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_C1:
						uiinvalid = base.UIInvalid;
						num = (short)895680513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3B0:
						num = (short)315817990;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
					IL_3ED:
					return;
				}
				}
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00017B18 File Offset: 0x00015D18
		protected virtual bool ValidateHelper()
		{
			short num = (short)87621632;
			short num2 = num;
			num = (short)1431501707;
			short num3 = num;
			num = (short)58850187;
			switch (num3 == num)
			{
			}
			num = (short)590217217;
			if (num != 0)
			{
			}
			num = (short)74317824;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00017BC4 File Offset: 0x00015DC4
		public override void ResetToDefaultWithUndo()
		{
			short num = (short)1830551559;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					TUIType tuitype;
					global::AcpCommonLib.UndoRedo.UndoableTask undoableTask = new global::AcpBusinessLayer.UndoRedo.ModifyUIValueTask<TUIType>(this, tuitype);
					num = (short)362020875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
					{
						num = (short)544604164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_189;
				case 2:
				{
					TUIType tuitype;
					if (tuitype.CompareTo(this.UIValue) != 0)
					{
						num = (short)814481408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_189;
				}
				case 3:
				{
					TUIType tuitype = (TUIType)((object)this.Converter.Convert(this.DefaultValue, null, this.ConverterParameterObject, null));
					num = (short)402718721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)1142723162;
					short num3 = num;
					num = (short)373133914;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C0;
					default:
						num = (short)1488388096;
						if (num != 0)
						{
						}
						num = (short)1822490632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					num = (short)430702594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_D7;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 8:
				{
					TUIType tuitype;
					if (tuitype != null)
					{
						num = (short)1050607621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_189;
				}
				case 9:
				{
					num = (short)132317185;
					if (num != 0)
					{
					}
					global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
					global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(undoableTask.ToString());
					containerTask.AddTask(undoableTask);
					this.CallValueSetter(containerTask);
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
					goto IL_C0;
				}
				case 10:
					goto IL_257;
				case 11:
				{
					if (base.ValueSetter != null)
					{
						num = (short)455999488;
						short num4 = num;
						num = (short)833945609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(undoableTask);
					num = (short)965804042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_54:
				if (base.UIInvalid)
				{
					num = (short)1893662723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2AE;
				IL_C0:
				num = (short)125435910;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D7:
			IL_189:
			base.SetUITimer();
			return;
			IL_257:
			goto IL_189;
			IL_2AE:
			base.ResetToDefaultWithUndo();
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00017E88 File Offset: 0x00016088
		public override void ResetToDefaultWithUndo(global::AcpCommonLib.UndoRedo.ContainerTask taskContainer)
		{
			short num = (short)920715268;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
			for (;;)
			{
				TUIType tuitype;
				switch (num2)
				{
				case 0:
					undoableTask = new global::AcpBusinessLayer.UndoRedo.ModifyUIValueTask<TUIType>(this, tuitype);
					num = (short)849149960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (tuitype != null)
					{
						num = (short)1057554434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)1769865221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_8E;
				case 4:
					num = (short)1372389377;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 5:
					if (tuitype.CompareTo(this.UIValue) != 0)
					{
						num = (short)695468032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					goto IL_14F;
				case 7:
					return;
				case 8:
				{
					if (base.ValueSetter != null)
					{
						num = (short)275120128;
						short num3 = num;
						num = (short)1919483910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)385128703;
					short num4 = num;
					num = (short)1095670015;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8E;
					default:
						goto IL_CA;
					}
					break;
				}
				}
				IL_6E:
				if (base.UIInvalid)
				{
					num = (short)1911750659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.ResetToDefaultWithUndo(taskContainer);
				num = (short)668336135;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8E:
				tuitype = (TUIType)((object)this.Converter.Convert(this.DefaultValue, null, this.ConverterParameterObject, null));
				num = (short)2065891329;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CA:
			num = (short)1035993088;
			if (num != 0)
			{
			}
			taskContainer.AddTask(undoableTask);
			return;
			IL_14F:
			global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(undoableTask.ToString());
			containerTask.AddTask(undoableTask);
			this.CallValueSetter(containerTask);
			taskContainer.AddTask(containerTask);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000180DC File Offset: 0x000162DC
		public static implicit operator TUIType(global::AcpBusinessLayer.AcpFieldX<TDBType, TUIType> obj)
		{
			short num = (short)2028732416;
			short num2 = num;
			num = (short)884907217;
			short num3 = num;
			num = (short)1921162449;
			switch (num3 == num)
			{
			}
			num = (short)1522335745;
			if (num != 0)
			{
			}
			num = (short)445251584;
			if (num != 0)
			{
			}
			return obj.UIValue;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00018190 File Offset: 0x00016390
		protected internal override void FirePropertyChangedEvent()
		{
			int a_ = 8;
			short num = (short)264175616;
			short num2 = num;
			num = (short)385495475;
			short num3 = num;
			num = (short)904278451;
			switch (num3 == num)
			{
			}
			num = (short)792526848;
			if (num != 0)
			{
			}
			num = (short)1175388161;
			if (num != 0)
			{
			}
			base.FirePropertyChangedEvent();
			((global::AcpBusinessLayer.FeatureSection)base.Parent).FirePropertyChanged(base.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("藙觛韝뛟菡裣鏥跧", a_));
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00018270 File Offset: 0x00016470
		public override void ParseValueFrom(string value)
		{
			int a_ = 15;
			global::System.Type typeFromHandle = typeof(TUIType);
			short num2;
			try
			{
				int num;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_20:
						switch (num)
						{
						case 0:
							this.UIValue = (TUIType)((object)value);
							num2 = (short)19529734;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							goto IL_19D;
						case 2:
						{
							if (typeFromHandle == typeof(string))
							{
								num2 = (short)1100414976;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							global::System.Reflection.MethodInfo method = typeFromHandle.GetMethod(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뇠苢韤铦賨", a_), new global::System.Type[]
							{
								typeof(string)
							});
							num2 = (short)82837507;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 3:
						{
							global::System.Reflection.MethodInfo method;
							if (method != null)
							{
								num2 = (short)1383071749;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_19D;
						}
						case 4:
							goto IL_1DC;
						case 5:
						{
							global::System.Reflection.MethodInfo method;
							this.UIValue = (TUIType)((object)method.Invoke(null, new object[]
							{
								value
							}));
							num2 = (short)139526145;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 6:
						{
							num2 = (short)1158493553;
							short num3 = num2;
							num2 = (short)287323505;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_49;
							default:
								num2 = (short)828833792;
								if (num2 != 0)
								{
								}
								goto IL_19D;
							}
							break;
						}
						}
						goto IL_42;
						IL_19D:
						num2 = (short)7929857;
						if (num2 != 0)
						{
						}
						num2 = (short)1975582724;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1DC:
					goto IL_1E8;
				}
				IL_42:
				base.UnsupportedValue = false;
				IL_49:
				num2 = (short)613285890;
				num = (int)((global::System.IntPtr)num2);
				goto IL_20;
			}
			catch (global::System.Exception)
			{
				base.UnsupportedValue = true;
			}
			IL_1E8:
			num2 = (short)1122697216;
			short num4 = num2;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000184AC File Offset: 0x000166AC
		public override string ToString()
		{
			while (this.UIValue != null)
			{
				short num = (short)1306498358;
				short num2 = num;
				num = (short)1981519158;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)33685504;
					if (num != 0)
					{
					}
					num = (short)1815937024;
					short num3 = num;
					num = (short)1380188161;
					if (num != 0)
					{
					}
					TUIType uivalue = this.UIValue;
					return uivalue.ToString();
				}
				}
			}
			return string.Empty;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00018580 File Offset: 0x00016780
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00018630 File Offset: 0x00016830
		internal TUIType DirectUIValue
		{
			get
			{
				short num = (short)1409548288;
				short num2 = num;
				num = (short)1061577140;
				short num3 = num;
				num = (short)1902010804;
				switch (num3 == num)
				{
				}
				num = (short)1968570369;
				if (num != 0)
				{
				}
				num = (short)1566703616;
				if (num != 0)
				{
				}
				return this.tempUIBackup;
			}
			set
			{
				short num = (short)1038942208;
				short num2 = num;
				num = (short)294046201;
				short num3 = num;
				num = (short)2131741177;
				switch (num3 == num)
				{
				}
				num = (short)1521549313;
				if (num != 0)
				{
				}
				num = (short)1370161152;
				if (num != 0)
				{
				}
				this.tempUIBackup = value;
				base.ForceValid = false;
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000186EC File Offset: 0x000168EC
		public override global::AcpCommonLib.UndoRedo.UndoableTask CopyValueOf(global::AcpCommonLib.IAcpField source)
		{
			short num = (short)1290928128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				TDBType value;
				TDBType value2;
				global::AcpBusinessLayer.UndoRedo.SetValueTask setValueTask;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_16B;
					case 1:
						if (!value.Equals(value2))
						{
							num = (short)1175126019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return setValueTask;
					case 2:
						if (base.ValueSetter != null)
						{
							num = (short)1950547968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return setValueTask;
					case 3:
					{
						num = (short)1890582529;
						if (num != 0)
						{
						}
						setValueTask = new global::AcpBusinessLayer.UndoRedo.SetValueTask(this, source.ToString());
						num = (short)1929004019;
						short num3 = num;
						num = (short)278807539;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16B;
						default:
							num = (short)1941372928;
							if (num != 0)
							{
							}
							num = (short)68485122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_3F;
				}
				IL_16B:
				num = (short)1741619200;
				short num4 = num;
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(setValueTask.ToString());
				containerTask.AddTask(setValueTask);
				this.CallValueSetter(containerTask);
				return containerTask;
				IL_3F:
				setValueTask = null;
				value2 = ((global::AcpBusinessLayer.AcpField<TDBType>)source).Value;
				value = this.Value;
				num = (short)887750657;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00018894 File Offset: 0x00016A94
		public virtual global::AcpCommonLib.UndoRedo.UndoableTask CopyUIValue(object sourcevalue)
		{
			global::AcpBusinessLayer.UndoRedo.ModifyUIValueTask<TUIType> modifyUIValueTask;
			short num;
			for (;;)
			{
				TUIType newValue = (TUIType)((object)sourcevalue);
				modifyUIValueTask = new global::AcpBusinessLayer.UndoRedo.ModifyUIValueTask<TUIType>(this, newValue);
				if (base.ValueSetter != null)
				{
					break;
				}
				num = (short)257949697;
				if (num != 0)
				{
				}
				num = (short)1727735307;
				short num2 = num;
				num = (short)1472996875;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_92;
				}
			}
			global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(modifyUIValueTask.ToString());
			containerTask.AddTask(modifyUIValueTask);
			this.CallValueSetter(containerTask);
			return containerTask;
			IL_92:
			num = (short)1051852800;
			short num3 = num;
			num = (short)1304100864;
			if (num != 0)
			{
			}
			return modifyUIValueTask;
		}

		// Token: 0x04000041 RID: 65
		private TUIType tempUIBackup;
	}
}
