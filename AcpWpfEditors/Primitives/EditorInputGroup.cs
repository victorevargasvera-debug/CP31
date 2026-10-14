using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000056 RID: 86
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class EditorInputGroup : global::DevComponents.WpfEditors.Primitives.EditorGroup
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0006B304 File Offset: 0x00069504
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x0006B3C0 File Offset: 0x000695C0
		public bool AutoAdvance
		{
			get
			{
				short num = (short)1173454757;
				short num2 = num;
				num = (short)32669605;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2062614528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1307639809;
				if (num != 0)
				{
				}
				num = (short)690356224;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.AutoAdvanceProperty);
			}
			set
			{
				short num = (short)1328480257;
				if (num != 0)
				{
				}
				num = (short)233504768;
				short num2 = num;
				num = (short)531460199;
				short num3 = num;
				num = (short)659255399;
				switch (num3 == num)
				{
				}
				num = (short)927858688;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.AutoAdvanceProperty, value);
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0006B47C File Offset: 0x0006967C
		private static void d(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (editorInputGroup != null)
					{
						num2 = (short)950468609;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					editorInputGroup.OnAutoOverwriteChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num2 = (short)756744194;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_129;
				}
				break;
			}
			IL_1C:
			editorInputGroup = (A_0 as global::DevComponents.WpfEditors.Primitives.EditorInputGroup);
			num2 = (short)439413082;
			short num3 = num2;
			num2 = (short)768600410;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_129:
				return;
			case 1:
				break;
			default:
			{
				num2 = (short)1461321728;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)75366400;
			if (num2 != 0)
			{
			}
			num2 = (short)1291452417;
			if (num2 != 0)
			{
			}
			num2 = (short)984547328;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0006B5B4 File Offset: 0x000697B4
		protected virtual void OnAutoOverwriteChanged(bool oldValue, bool newValue)
		{
			global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
			short num;
			try
			{
				num = (short)1092288520;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1422803233;
						short num3 = num;
						num = (short)633684257;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_182;
						default:
						{
							num = (short)911867904;
							if (num != 0)
							{
							}
							global::DevComponents.WpfEditors.Primitives.EditorInputBase editorInputBase;
							if (editorInputBase != null)
							{
								num = (short)1914503175;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						break;
					}
					case 1:
					{
						global::DevComponents.WpfEditors.Primitives.EditorInputBase editorInputBase;
						if (editorInputBase.AutoOverwrite != newValue)
						{
							num = (short)1033043971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						global::DevComponents.WpfEditors.Primitives.EditorInputBase editorInputBase;
						editorInputBase.AutoOverwrite = newValue;
						num = (short)837746690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_182;
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)526909444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.Primitives.EditorInputBase editorInputBase = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfEditors.Primitives.EditorInputBase;
						num = (short)1600192512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_199;
					case 7:
						num = (short)951123969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_56;
						}
						continue;
					}
					IL_E9:
					num = (short)1475215365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56:
					goto IL_E9;
					IL_182:
					num = (short)230752262;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_199:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_1BA;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_1A8:
					switch (num2)
					{
					case 0:
						disposable.Dispose();
						num = (short)789118977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_236;
					case 2:
						if (disposable != null)
						{
							num = (short)1890451456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_238;
					}
					goto IL_1BA;
				}
				IL_236:
				IL_238:
				goto EndFinally_7;
				IL_1BA:
				num = (short)1967587329;
				if (num != 0)
				{
				}
				disposable = (enumerator as global::System.IDisposable);
				num = (short)417005570;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_1A8;
				EndFinally_7:;
			}
			num = (short)1046478848;
			short num4 = num;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0006B840 File Offset: 0x00069A40
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x0006B8F8 File Offset: 0x00069AF8
		public bool AutoOverwrite
		{
			get
			{
				short num = (short)1109994251;
				short num2 = num;
				num = (short)693512971;
				switch (num2 == num)
				{
				}
				num = (short)1212743680;
				short num3 = num;
				num = (short)899219456;
				if (num != 0)
				{
				}
				num = (short)1519648769;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.AutoOverwriteProperty);
			}
			set
			{
				short num = (short)47775745;
				if (num != 0)
				{
				}
				num = (short)766100941;
				short num2 = num;
				num = (short)1744946637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)799145984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074069504;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.AutoOverwriteProperty, value);
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0006B9B0 File Offset: 0x00069BB0
		private static object a(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup = A_0 as global::DevComponents.WpfEditors.Primitives.EditorInputGroup;
			short num;
			if (editorInputGroup != null)
			{
				num = (short)286492760;
				short num2 = num;
				num = (short)590121048;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_82;
				case 1:
					break;
				default:
				{
					num = (short)238551040;
					short num3 = num;
					break;
				}
				}
				num = (short)569835520;
				if (num != 0)
				{
				}
				IL_82:
				return editorInputGroup.OnCoerceSelectNextInputCharacters((string)A_1);
			}
			num = (short)245432321;
			if (num != 0)
			{
			}
			return A_1;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0006BA74 File Offset: 0x00069C74
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_F0;
				case 1:
					return;
				case 2:
				{
					num2 = (short)1089422437;
					short num3 = num2;
					num2 = (short)712590437;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F0;
					default:
						num2 = (short)1596194816;
						if (num2 != 0)
						{
						}
						if (editorInputGroup != null)
						{
							num2 = (short)1265041408;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_1C;
				IL_F0:
				editorInputGroup.OnSelectNextInputCharactersChanged((string)A_1.OldValue, (string)A_1.NewValue);
				num2 = (short)410910721;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)11993088;
			short num4 = num2;
			num2 = (short)761462785;
			if (num2 != 0)
			{
			}
			editorInputGroup = (A_0 as global::DevComponents.WpfEditors.Primitives.EditorInputGroup);
			num2 = (short)1238368258;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0006BBAC File Offset: 0x00069DAC
		protected virtual string OnCoerceSelectNextInputCharacters(string value)
		{
			short num = (short)2073559042;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)859466413;
					short num3 = num;
					num = (short)248081069;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return value;
					default:
						num = (short)1429209089;
						if (num != 0)
						{
						}
						num = (short)1754464256;
						if (num != 0)
						{
						}
						value = "";
						num = (short)301858817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return value;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (value != null)
				{
					break;
				}
				num = (short)734134272;
				short num4 = num;
				num = (short)1323433984;
				num2 = (int)((global::System.IntPtr)num);
			}
			return value;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0006BCC4 File Offset: 0x00069EC4
		protected virtual void OnSelectNextInputCharactersChanged(string oldValue, string newValue)
		{
			short num = (short)1976277855;
			short num2 = num;
			num = (short)1502124895;
			switch (num2 == num)
			{
			}
			num = (short)456589312;
			short num3 = num;
			num = (short)2029846529;
			if (num != 0)
			{
			}
			num = (short)968097792;
			if (num != 0)
			{
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0006BD6C File Offset: 0x00069F6C
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x0006BE24 File Offset: 0x0006A024
		public string SelectNextInputCharacters
		{
			get
			{
				short num = (short)477207917;
				short num2 = num;
				num = (short)1745395053;
				switch (num2 == num)
				{
				}
				num = (short)628293632;
				short num3 = num;
				num = (short)1080426497;
				if (num != 0)
				{
				}
				num = (short)1195573248;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.SelectNextInputCharactersProperty);
			}
			set
			{
				short num = (short)755560526;
				short num2 = num;
				num = (short)1161818190;
				switch (num2 == num)
				{
				}
				num = (short)1660485632;
				short num3 = num;
				num = (short)591659009;
				if (num != 0)
				{
				}
				num = (short)363855872;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.SelectNextInputCharactersProperty, value);
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0006BED8 File Offset: 0x0006A0D8
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)893124609;
					if (num2 != 0)
					{
					}
					goto IL_EE;
				case 1:
					return;
				case 2:
				{
					num2 = (short)542547154;
					short num3 = num2;
					num2 = (short)789814482;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EE;
					default:
						num2 = (short)144965632;
						if (num2 != 0)
						{
						}
						if (editorInputGroup != null)
						{
							num2 = (short)1298857984;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_1C;
				IL_EE:
				editorInputGroup.OnAllowEmptyStateChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
				num2 = (short)1888813057;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)1552220160;
			short num4 = num2;
			editorInputGroup = (A_0 as global::DevComponents.WpfEditors.Primitives.EditorInputGroup);
			num2 = (short)1195245570;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0006C00C File Offset: 0x0006A20C
		protected virtual void OnAllowEmptyStateChanged(bool oldValue, bool newValue)
		{
			global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
			short num;
			try
			{
				num = (short)815529990;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 1:
						num = (short)620822532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1817837569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
						num = (short)1137246213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Windows.UIElement uielement;
						((global::DevComponents.WpfEditors.Primitives.EditorNumericInput)uielement).AllowEmptyState = newValue;
						num = (short)1674313728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_157;
					case 5:
					{
						global::System.Windows.UIElement uielement;
						if (uielement is global::DevComponents.WpfEditors.Primitives.EditorNumericInput)
						{
							num = (short)1863518013;
							short num3 = num;
							num = (short)350095165;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1264058368;
								if (num != 0)
								{
								}
								num = (short)73269251;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
						}
						break;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_4F;
						}
						continue;
					}
					IL_DF:
					num = (short)419168258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F:
					goto IL_DF;
				}
				IL_157:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_178;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_166:
					switch (num2)
					{
					case 0:
						disposable.Dispose();
						num = (short)1326055425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1C6;
					case 2:
						if (disposable != null)
						{
							num = (short)1626865664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C8;
					}
					goto IL_178;
				}
				IL_1C6:
				IL_1C8:
				num = (short)178257921;
				if (num != 0)
				{
				}
				goto EndFinally_6;
				IL_178:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)42008578;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_166;
				EndFinally_6:;
			}
			num = (short)1947205632;
			short num4 = num;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x0006C250 File Offset: 0x0006A450
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x0006C308 File Offset: 0x0006A508
		public bool AllowEmptyState
		{
			get
			{
				short num = (short)1364516575;
				short num2 = num;
				num = (short)208527071;
				switch (num2 == num)
				{
				}
				num = (short)1705181184;
				short num3 = num;
				num = (short)631570433;
				if (num != 0)
				{
				}
				num = (short)1353973760;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.AllowEmptyStateProperty);
			}
			set
			{
				short num = (short)1910755291;
				short num2 = num;
				num = (short)2065747931;
				switch (num2 == num)
				{
				}
				num = (short)1055522816;
				short num3 = num;
				num = (short)1953759233;
				if (num != 0)
				{
				}
				num = (short)1103495168;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.AllowEmptyStateProperty, value);
			}
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0006C3C4 File Offset: 0x0006A5C4
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_EC;
				case 1:
					return;
				case 2:
				{
					num2 = (short)1336033036;
					short num3 = num2;
					num2 = (short)556941068;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EC;
					default:
						num2 = (short)408158208;
						if (num2 != 0)
						{
						}
						if (editorInputGroup != null)
						{
							num2 = (short)877985792;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_1C;
				IL_EC:
				editorInputGroup.OnIsReadOnlyChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
				num2 = (short)2035875841;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)475463680;
			short num4 = num2;
			num2 = (short)989069313;
			if (num2 != 0)
			{
			}
			editorInputGroup = (A_0 as global::DevComponents.WpfEditors.Primitives.EditorInputGroup);
			num2 = (short)1292632066;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0006C4F4 File Offset: 0x0006A6F4
		protected virtual void OnIsReadOnlyChanged(bool oldValue, bool newValue)
		{
			short num = (short)2064515073;
			if (num != 0)
			{
			}
			num = (short)1493565440;
			short num2 = num;
			global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
			try
			{
				num = (short)1727660038;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 1:
						num = (short)299302916;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1440546817;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
						num = (short)864878597;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Windows.UIElement uielement;
						((global::DevComponents.WpfEditors.Primitives.EditorInputBase)uielement).IsReadOnly = newValue;
						num = (short)384761856;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1A8;
					case 5:
					{
						global::System.Windows.UIElement uielement;
						if (uielement is global::DevComponents.WpfEditors.Primitives.EditorInputBase)
						{
							num = (short)1591176456;
							short num4 = num;
							num = (short)1193700616;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1182990336;
								if (num != 0)
								{
								}
								num = (short)547422211;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
						}
						break;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_A0;
						}
						continue;
					}
					IL_130:
					num = (short)457441282;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_A0:
					goto IL_130;
				}
				IL_1A8:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_1C6;
				}
				int num3;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_1B4:
					switch (num3)
					{
					case 0:
						disposable.Dispose();
						num = (short)774897665;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_215;
					case 2:
						if (disposable != null)
						{
							num = (short)1302921216;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					}
					goto IL_1C6;
				}
				IL_215:
				IL_217:
				goto EndFinally_6;
				IL_1C6:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1994063874;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_1B4;
				EndFinally_6:;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x0006C738 File Offset: 0x0006A938
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x0006C7F0 File Offset: 0x0006A9F0
		public bool IsReadOnly
		{
			get
			{
				short num = (short)1949349549;
				short num2 = num;
				num = (short)1057535661;
				switch (num2 == num)
				{
				}
				num = (short)1257242624;
				short num3 = num;
				num = (short)283115521;
				if (num != 0)
				{
				}
				num = (short)1895038976;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.IsReadOnlyProperty);
			}
			set
			{
				short num = (short)1086949480;
				short num2 = num;
				num = (short)2084014184;
				switch (num2 == num)
				{
				}
				num = (short)711852032;
				short num3 = num;
				num = (short)323223553;
				if (num != 0)
				{
				}
				num = (short)447545344;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.IsReadOnlyProperty, value);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x0006C8AC File Offset: 0x0006AAAC
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x0006C968 File Offset: 0x0006AB68
		[global::System.ComponentModel.Category("Watermark")]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Description("Indicates watermark text displayed on the input control when control is empty.")]
		public string WatermarkText
		{
			get
			{
				short num = (short)517144577;
				if (num != 0)
				{
				}
				num = (short)825663905;
				short num2 = num;
				num = (short)1749066145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)256442368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)806748160;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkTextProperty);
			}
			set
			{
				short num = (short)180292380;
				short num2 = num;
				num = (short)1124928284;
				switch (num2 == num)
				{
				}
				num = (short)1306066944;
				short num3 = num;
				num = (short)1512570881;
				if (num != 0)
				{
				}
				num = (short)693108736;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkTextProperty, value);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0006CA1C File Offset: 0x0006AC1C
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x0006CAD8 File Offset: 0x0006ACD8
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Description("Indicates watermark text brush.")]
		[global::System.ComponentModel.Category("Watermark")]
		public global::System.Windows.Media.Brush WatermarkBrush
		{
			get
			{
				short num = (short)527519704;
				short num2 = num;
				num = (short)904548312;
				switch (num2 == num)
				{
				}
				num = (short)1224015872;
				short num3 = num;
				num = (short)10289153;
				if (num != 0)
				{
				}
				num = (short)171835392;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkBrushProperty);
			}
			set
			{
				short num = (short)27071648;
				short num2 = num;
				num = (short)1345393824;
				switch (num2 == num)
				{
				}
				num = (short)405274624;
				short num3 = num;
				num = (short)1555300353;
				if (num != 0)
				{
				}
				num = (short)769916928;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkBrushProperty, value);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0006CB90 File Offset: 0x0006AD90
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x0006CC48 File Offset: 0x0006AE48
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Category("Watermark")]
		[global::System.ComponentModel.Description("Indicates whether watermark text is displayed if set for the input items.")]
		public bool WatermarkEnabled
		{
			get
			{
				short num = (short)701764578;
				short num2 = num;
				num = (short)1879315426;
				switch (num2 == num)
				{
				}
				num = (short)837681152;
				short num3 = num;
				num = (short)2122448896;
				if (num != 0)
				{
				}
				num = (short)1526530049;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkEnabledProperty);
			}
			set
			{
				short num = (short)1051459585;
				if (num != 0)
				{
				}
				num = (short)1650750157;
				short num2 = num;
				num = (short)1432253133;
				switch (num2 == num)
				{
				default:
				{
					num = (short)723320832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1293811712;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkEnabledProperty, value);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0006CD04 File Offset: 0x0006AF04
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x0006CDBC File Offset: 0x0006AFBC
		[global::System.ComponentModel.DefaultValue(global::System.Windows.HorizontalAlignment.Left)]
		[global::System.ComponentModel.Description("Indicates watermark text alignment.")]
		[global::System.ComponentModel.Category("Watermark")]
		public global::System.Windows.HorizontalAlignment WatermarkAlignment
		{
			get
			{
				short num = (short)441188353;
				if (num != 0)
				{
				}
				num = (short)1908588796;
				short num2 = num;
				num = (short)58441980;
				switch (num2 == num)
				{
				default:
				{
					num = (short)582156288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1523580928;
				if (num != 0)
				{
				}
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkAlignmentProperty);
			}
			set
			{
				short num = (short)710260245;
				short num2 = num;
				num = (short)498054677;
				switch (num2 == num)
				{
				}
				num = (short)626130944;
				short num3 = num;
				num = (short)517537792;
				if (num != 0)
				{
				}
				num = (short)202178561;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkAlignmentProperty, value);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0006CE78 File Offset: 0x0006B078
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x0006CF34 File Offset: 0x0006B134
		[global::System.ComponentModel.Description("Indicates watermark hiding behaviour.")]
		[global::System.ComponentModel.Category("Watermark")]
		public global::DevComponents.WpfEditors.eWatermarkBehavior WatermarkBehavior
		{
			get
			{
				short num = (short)540454969;
				short num2 = num;
				num = (short)1779085369;
				switch (num2 == num)
				{
				}
				num = (short)1205403648;
				short num3 = num;
				num = (short)1469186048;
				if (num != 0)
				{
				}
				num = (short)773062657;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfEditors.eWatermarkBehavior)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkBehaviorProperty);
			}
			set
			{
				short num = (short)81764501;
				short num2 = num;
				num = (short)2009637013;
				switch (num2 == num)
				{
				}
				num = (short)1058537472;
				short num3 = num;
				num = (short)75431936;
				if (num != 0)
				{
				}
				num = (short)753270785;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkBehaviorProperty, value);
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0006CFEC File Offset: 0x0006B1EC
		static EditorInputGroup()
		{
			int a_ = 2;
			short num = (short)1678120534;
			short num2 = num;
			num = (short)1980569174;
			switch (num2 == num)
			{
			}
			num = (short)257949696;
			short num3 = num;
			num = (short)924319744;
			if (num != 0)
			{
			}
			num = (short)1284440065;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup.AutoAdvanceProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軎ꓐ꟒뫔雖뷘귚볜뇞苠蛢", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputGroup), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup.AutoOverwriteProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軎ꓐ꟒뫔飖꿘뻚꿜꣞鏠諢釤苦", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputGroup), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.d)));
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup.SelectNextInputCharactersProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鳎듐뿒냔듖귘闚룜꟞闠ꫢ诤韦鳨鿪껬蟮郰臲铴银跸黺迼賾", a_), typeof(string), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputGroup), new global::System.Windows.UIPropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.c), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.a)));
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup.AllowEmptyStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軎뷐뿒뫔ꃖ鳘뛚규ꯞ飠냢釤蛦鷨軪", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputGroup), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.b)));
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup.IsReadOnlyProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蛎ꋐ臒냔뛖뷘铚돜돞飠", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputGroup), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.a)));
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkTextProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("风냐꟒냔ꗖ듘뫚꿜듞뗠蛢鷤鏦", a_), typeof(string), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputGroup), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("风냐꟒냔ꗖ듘뫚꿜듞ꏠ釢郤铦臨", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputGroup), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("风냐꟒냔ꗖ듘뫚꿜듞ꓠ跢蓤藦藨軪觬", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputGroup), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkAlignmentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("风냐꟒냔ꗖ듘뫚꿜듞ꃠ迢賤胦蟨蛪裬臮藰", a_), typeof(global::System.Windows.HorizontalAlignment), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputGroup), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Left, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkBehaviorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("风냐꟒냔ꗖ듘뫚꿜듞ꏠ蛢跤蛦鿨苪苬鷮", a_), typeof(global::DevComponents.WpfEditors.eWatermarkBehavior), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputGroup), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfEditors.eWatermarkBehavior.HideOnFocus, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.Primitives.EditorInputGroup), global::DevComponents.WpfEditors.Primitives.EditorInputBase.InputCompleteEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.b));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.Primitives.EditorInputGroup), global::DevComponents.WpfEditors.Primitives.EditorInputBase.InputChangedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.a));
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0006D340 File Offset: 0x0006B540
		protected override void OnVisualChildrenChanged(global::System.Windows.DependencyObject visualAdded, global::System.Windows.DependencyObject visualRemoved)
		{
			short num = (short)1143472130;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)783629074;
					short num3 = num;
					num = (short)2141207314;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FA;
					default:
					{
						num = (short)1501364224;
						if (num != 0)
						{
						}
						global::DevComponents.WpfEditors.Primitives.EditorInputBase editorInputBase = visualAdded as global::DevComponents.WpfEditors.Primitives.EditorInputBase;
						editorInputBase.IsReadOnly = this.IsReadOnly;
						editorInputBase.AutoOverwrite = this.AutoOverwrite;
						num = (short)432668673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_FA;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (!(visualAdded is global::DevComponents.WpfEditors.Primitives.EditorInputBase))
				{
					goto IL_123;
				}
				num = (short)1449000960;
				short num4 = num;
				num = (short)1569587200;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FA:
			num = (short)1890123777;
			if (num != 0)
			{
			}
			IL_123:
			this.UpdateIsEmpty();
			base.OnVisualChildrenChanged(visualAdded, visualRemoved);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0006D480 File Offset: 0x0006B680
		protected override void OnFocusedItemChanged(global::DevComponents.WpfEditors.Primitives.EditorElement previousFocus)
		{
			short num = (short)1447165953;
			if (num != 0)
			{
			}
			num = (short)885091503;
			short num2 = num;
			num = (short)1612999855;
			switch (num2 == num)
			{
			default:
			{
				num = (short)120061952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1683750912;
			if (num != 0)
			{
			}
			this.ValidateInput(previousFocus);
			base.OnFocusedItemChanged(previousFocus);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0006D538 File Offset: 0x0006B738
		protected virtual bool ValidateInput(global::DevComponents.WpfEditors.Primitives.EditorElement inputItem)
		{
			short num = (short)338097377;
			short num2 = num;
			num = (short)1803941089;
			switch (num2 == num)
			{
			}
			num = (short)1871839232;
			short num3 = num;
			num = (short)784138241;
			if (num != 0)
			{
			}
			num = (short)1894842368;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0006D5E4 File Offset: 0x0006B7E4
		private static void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1802638082;
			short num2 = num;
			num = (short)459543298;
			switch (num2 == num)
			{
			}
			num = (short)332136448;
			short num3 = num;
			num = (short)617873409;
			if (num != 0)
			{
			}
			num = (short)874381312;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.Primitives.EditorInputGroup)A_0).HandleInputComplete(A_1);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0006D698 File Offset: 0x0006B898
		protected virtual void HandleInputComplete(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1974403078;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					num = (short)2131755013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.AutoAdvance)
					{
						num = (short)928055297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					num = (short)629053557;
					short num3 = num;
					num = (short)506108021;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)936247296;
						if (num != 0)
						{
						}
						this.OnGroupInputComplete();
						num = (short)1638858752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					num = (short)1076559873;
					if (num != 0)
					{
					}
					num = (short)330432514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!this.b())
					{
						num = (short)1386020864;
						short num4 = num;
						num = (short)386138115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				}
				IL_40:
				global::DevComponents.WpfEditors.Primitives.EditorElement inputItem;
				if ((inputItem = base.FocusedItem) == null)
				{
					inputItem = (e.OriginalSource as global::DevComponents.WpfEditors.Primitives.EditorElement);
				}
				if (!this.ValidateInput(inputItem))
				{
					break;
				}
				num = (short)1774845956;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0006D860 File Offset: 0x0006BA60
		protected virtual void OnGroupInputComplete()
		{
			short num = (short)343627705;
			short num2 = num;
			num = (short)739858361;
			switch (num2 == num)
			{
			}
			num = (short)1809514496;
			short num3 = num;
			num = (short)266010624;
			if (num != 0)
			{
			}
			num = (short)2007105537;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0006D908 File Offset: 0x0006BB08
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)798008302;
			short num2 = num;
			num = (short)831366126;
			switch (num2 == num)
			{
			}
			num = (short)1818296320;
			short num3 = num;
			num = (short)501678080;
			if (num != 0)
			{
			}
			num = (short)2033451009;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.Primitives.EditorInputGroup)A_0).OnChildInputChanged(A_1);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0006D9C4 File Offset: 0x0006BBC4
		protected virtual void OnChildInputChanged(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)103288152;
			short num2 = num;
			num = (short)2001014104;
			switch (num2 == num)
			{
			}
			num = (short)1088028672;
			short num3 = num;
			num = (short)580190209;
			if (num != 0)
			{
			}
			num = (short)58654720;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0006DA6C File Offset: 0x0006BC6C
		private bool b()
		{
			short num = (short)1691025408;
			short num2 = num;
			num = (short)865919116;
			short num3 = num;
			num = (short)103014540;
			switch (num3 == num)
			{
			}
			num = (short)1155072001;
			if (num != 0)
			{
			}
			num = (short)967770112;
			if (num != 0)
			{
			}
			return this.b(true);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0006DB20 File Offset: 0x0006BD20
		private bool a()
		{
			short num = (short)481951744;
			short num2 = num;
			num = (short)679870465;
			if (num != 0)
			{
			}
			num = (short)1095760416;
			short num3 = num;
			num = (short)1326709280;
			switch (num3 == num)
			{
			}
			num = (short)1319370752;
			if (num != 0)
			{
			}
			return this.b(false);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0006DBD0 File Offset: 0x0006BDD0
		internal bool b(bool A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			global::DevComponents.WpfEditors.Primitives.EditorElement editorElement;
			short num2;
			global::System.Windows.UIElement uielement;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (editorElement != null)
					{
						num2 = (short)596508679;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					if (base.Items.Contains(editorElement))
					{
						num2 = (short)1129906182;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					num2 = (short)1878654980;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (uielement != null)
					{
						num2 = (short)2122252290;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C5;
				case 4:
					if (!base.Items.Contains(uielement))
					{
						num2 = (short)62193672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_133;
				case 5:
				{
					num2 = (short)1656094720;
					short num3 = num2;
					goto IL_133;
				}
				case 6:
					goto IL_12E;
				case 7:
					num2 = (short)983891969;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_1BC;
				}
				goto IL_34;
				IL_133:
				editorElement = (this.a(uielement, !A_0) as global::DevComponents.WpfEditors.Primitives.EditorElement);
				num2 = (short)1701380096;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_12E:
			return editorElement.Focus();
			IL_1BC:
			IL_1C5:
			uielement = this;
			goto IL_1C7;
			IL_34:
			num2 = (short)556498805;
			short num4 = num2;
			num2 = (short)1332772725;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C7:
				num2 = (short)1733492741;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)577437696;
				if (num2 != 0)
				{
				}
				num2 = (short)287768577;
				if (num2 != 0)
				{
				}
				uielement = (global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.UIElement);
				num2 = (short)1716912131;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0006DDEC File Offset: 0x0006BFEC
		private global::System.Windows.DependencyObject a(global::System.Windows.UIElement A_0, bool A_1)
		{
			short num = (short)903806976;
			switch (num)
			{
			default:
			{
				num = (short)1817051149;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.UIElement uielement;
				global::System.Windows.UIElement uielement2;
				int num6;
				for (;;)
				{
					int num3;
					int num4;
					switch (num2)
					{
					case 0:
						num = (short)337641484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_55F;
					case 2:
						if (uielement.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1089470479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19E;
					case 3:
						if (num3 < 0)
						{
							num = (short)1298006047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement = base.Items[num3];
						num = (short)1164050446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)41811973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (base.Items.Count > 0)
						{
							num = (short)1740701725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C4;
					case 6:
						if (num4 >= base.Items.Count)
						{
							num = (short)2045706240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement2 = base.Items[num4];
						num = (short)877002769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1990459394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!base.Items.Contains(A_0))
						{
							num = (short)175702036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1100152864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_2AB;
					case 10:
					{
						num = (short)823197696;
						short num5 = num;
						num4 = 0;
						num = (short)2137653272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_3FB;
					case 12:
						goto IL_4E7;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_C8;
						}
						continue;
					case 14:
						if (uielement != null)
						{
							num = (short)552271879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19E;
					case 15:
						goto IL_14F;
					case 16:
						if (base.Items.Count > 0)
						{
							num = (short)787349514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C4;
					case 17:
						if (uielement2 != null)
						{
							num = (short)192086037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4EC;
					case 18:
						num = (short)649854984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (A_1)
						{
							num = (short)1558511620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1439105040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_379;
					case 21:
						num = (short)1747386395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						return uielement2;
					case 23:
						if (num6 >= 0)
						{
							num = (short)1343094812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C4;
					case 24:
						goto IL_55F;
					case 25:
						num = (short)1293287450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num6 = this.a(base.Items.IndexOf(A_0), A_1 ? -1 : 1);
						num = (short)1613758487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (uielement2.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)994967574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4EC;
					case 28:
						goto IL_3F6;
					case 29:
						num3 = base.Items.Count - 1;
						num = (short)801767454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_3FB;
					case 31:
						num = (short)738721801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (base.Items.Contains(A_0))
						{
							num = (short)1077215257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C4;
					}
					IL_C8:
					if (A_0 != this)
					{
						num = (short)737673234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_379;
					IL_19E:
					num3--;
					num = (short)1958543371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_379:
					num = (short)922877971;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FB:
					num = (short)227606531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4EC:
					num4++;
					num = (short)212140033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_55F:
					num = (short)1448869894;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_14F:
				num = (short)1229647161;
				short num7 = num;
				num = (short)1760947513;
				switch ((num7 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_50A:
					return base.Items[num6];
				default:
					num = (short)862912512;
					if (num != 0)
					{
					}
					num = (short)944766977;
					if (num != 0)
					{
					}
					return uielement;
				}
				return uielement2;
				IL_2AB:
				goto IL_5C4;
				IL_3F6:
				goto IL_50A;
				IL_4E7:
				IL_5C4:
				return null;
			}
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0006E3C0 File Offset: 0x0006C5C0
		private int a(int A_0, int A_1)
		{
			short num = (short)180092928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				int num3;
				int num4;
				int num5;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						num = (short)1762590721;
						if (num != 0)
						{
						}
						global::System.Windows.UIElement uielement;
						if (uielement.Focusable)
						{
							num = (short)637861895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E2;
					}
					case 1:
						if (A_1 < 0)
						{
							num = (short)1617690632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)419102733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)465567756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_2A2;
					case 4:
						return -1;
					case 5:
					{
						global::System.Windows.UIElement uielement;
						if (uielement != null)
						{
							num = (short)1517289474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E2;
					}
					case 6:
					{
						if (num3 == num4)
						{
							num = (short)584450057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 += num5;
						global::System.Windows.UIElement uielement = base.Items[num4];
						num = (short)590741509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						return num4;
					case 8:
						num3 = 0;
						num5 = -1;
						num = (short)1733820427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num = (short)1844646490;
						short num6 = num;
						num = (short)1254625882;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_288;
						default:
							goto IL_24E;
						}
						break;
					}
					case 10:
						num = (short)1383006208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (A_0 <= 0)
						{
							num = (short)1050148868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E2;
					case 12:
					{
						global::System.Windows.UIElement uielement;
						if (uielement.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1807089674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E2;
					}
					case 13:
						if (A_0 >= num3)
						{
							goto IL_288;
						}
						goto IL_1E2;
					}
					goto IL_67;
					IL_1E2:
					num = (short)604045318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_288:
					num = (short)1841364995;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num4;
				IL_24E:
				num = (short)1170800640;
				if (num != 0)
				{
				}
				return -1;
				IL_2A2:
				num = (short)431161344;
				short num7 = num;
				return -1;
				IL_67:
				num4 = A_0;
				num3 = base.Items.Count - 1;
				num5 = 1;
				num = (short)1720778753;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0006E69C File Offset: 0x0006C89C
		public virtual void UpdateIsEmpty()
		{
			short num = (short)918139661;
			short num2 = num;
			num = (short)1382593293;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B9;
			case 1:
				break;
			default:
			{
				num = (short)916062208;
				short num3 = num;
				break;
			}
			}
			num = (short)1229979648;
			if (num != 0)
			{
			}
			num = (short)162988033;
			if (num != 0)
			{
			}
			num = (short)797114368;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				IL_B9:
				bool isEmpty = true;
				global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
				try
				{
					num = (short)67371009;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							isEmpty = false;
							num = (short)850853901;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_127;
							}
							continue;
						case 2:
							num = (short)730857480;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_2D5;
						case 4:
							isEmpty = false;
							num = (short)533856263;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::DevComponents.WpfEditors.Primitives.EditorInputBase)
							{
								num = (short)244383746;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25C;
						}
						case 6:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::DevComponents.WpfEditors.Primitives.EditorInputGroup)
							{
								num = (short)2144993289;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							goto IL_186;
						case 8:
						{
							global::System.Windows.UIElement uielement;
							if (!((global::DevComponents.WpfEditors.Primitives.EditorInputBase)uielement).IsEmpty)
							{
								num = (short)1690763264;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25C;
						}
						case 9:
							num = (short)720109579;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num = (short)886702083;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							global::System.Windows.UIElement uielement;
							if (!((global::DevComponents.WpfEditors.Primitives.EditorInputGroup)uielement).IsEmpty)
							{
								num = (short)1852833796;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)56295434;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)1948188677;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							goto IL_2B7;
						}
						IL_21D:
						num = (short)915669004;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_127:
						goto IL_21D;
						IL_25C:
						num = (short)1402863622;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_186:
					IL_2B7:
					IL_2D5:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_2F4;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_2E1:
						switch (num4)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)1777008641;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_349;
						case 1:
							disposable.Dispose();
							num = (short)175505410;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_347;
						}
						goto IL_2F4;
					}
					IL_347:
					IL_349:
					goto EndFinally_10;
					IL_2F4:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1884684288;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_2E1;
					EndFinally_10:;
				}
				this.IsEmpty = isEmpty;
				return;
			}
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0006EA18 File Offset: 0x0006CC18
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x0006EAC8 File Offset: 0x0006CCC8
		[global::System.ComponentModel.Browsable(false)]
		public bool IsEmpty
		{
			get
			{
				short num = (short)2818048;
				short num2 = num;
				num = (short)327876609;
				if (num != 0)
				{
				}
				num = (short)1453290545;
				short num3 = num;
				num = (short)1329689649;
				switch (num3 == num)
				{
				}
				num = (short)499777536;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1561526275;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1565396395;
					short num3 = num;
					num = (short)1443433899;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)185925632;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							((global::DevComponents.WpfEditors.Primitives.EditorInputGroup)base.Parent).UpdateIsEmpty();
							num = (short)456589313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_198;
						case 2:
							this.a = value;
							num = (short)833945607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_94;
							}
							continue;
						case 4:
							this.ResetValue();
							goto IL_1C4;
						case 5:
						{
							num = (short)1192558592;
							short num4 = num;
							goto IL_E9;
						}
						case 6:
							if (base.Parent is global::DevComponents.WpfEditors.Primitives.EditorInputGroup)
							{
								num = (short)1901002753;
								if (num != 0)
								{
								}
								num = (short)398917632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_198;
						case 7:
							if (this.a)
							{
								num = (short)1893990404;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E9;
						case 8:
							return;
						}
						IL_94:
						if (this.a != value)
						{
							num = (short)1027670018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
						IL_E9:
						num = (short)233766918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_198:
						this.OnIsEmptyChanged();
						base.InvalidateVisual();
						num = (short)477364232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1C4:
					num = (short)206372869;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0006ECE0 File Offset: 0x0006CEE0
		protected virtual void OnIsEmptyChanged()
		{
			short num = (short)236126208;
			short num2 = num;
			num = (short)597580478;
			short num3 = num;
			num = (short)1166629566;
			switch (num3 == num)
			{
			}
			num = (short)207486977;
			if (num != 0)
			{
			}
			num = (short)811859968;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0006ED88 File Offset: 0x0006CF88
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)241169467;
			short num2 = num;
			num = (short)1010824251;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A4:
				if (!this.WatermarkEnabled)
				{
					goto IL_106;
				}
				num = (short)395051009;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1920335872;
				short num4 = num;
				num = (short)1620770816;
				if (num != 0)
				{
				}
				num = (short)759562240;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				case 1:
					base.InvalidateVisual();
					num = (short)515047426;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_DC;
				}
				goto IL_A4;
			}
			IL_DC:
			num = (short)1039335425;
			if (num != 0)
			{
			}
			IL_106:
			base.OnIsKeyboardFocusWithinChanged(e);
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0006EEA4 File Offset: 0x0006D0A4
		protected virtual bool RenderWatermark
		{
			get
			{
				short num = (short)1756430337;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1025835009;
						if (num != 0)
						{
						}
						if (base.IsEnabled)
						{
							num = (short)948764679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					case 2:
						num = (short)637468678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_2A8;
					case 4:
						goto IL_196;
					case 5:
						if (this.WatermarkBehavior == global::DevComponents.WpfEditors.eWatermarkBehavior.HideOnFocus)
						{
							num = (short)2071396354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)720240640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!base.IsKeyboardFocusWithin)
						{
							num = (short)1000210441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
					{
						num = (short)151126016;
						short num3 = num;
						num = (short)979042315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						return false;
					case 9:
						num = (short)1803747340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)1916370219;
						short num4 = num;
						num = (short)412646699;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)186646528;
							if (num != 0)
							{
							}
							num = (short)878182413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						if (this.IsEmpty)
						{
							num = (short)851509252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 12:
						if (base.IsEnabled)
						{
							num = (short)1105920010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 13:
						if (this.IsEmpty)
						{
							num = (short)789839875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					IL_5C:
					if (!this.WatermarkEnabled)
					{
						num = (short)48627720;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)945946629;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return false;
				IL_196:
				return !string.IsNullOrEmpty(this.WatermarkText);
				IL_2A8:
				return !string.IsNullOrEmpty(this.WatermarkText);
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0006F160 File Offset: 0x0006D360
		protected virtual void ResetValue()
		{
			short num = (short)1758002094;
			short num2 = num;
			num = (short)1812462510;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1029767168;
				if (num != 0)
				{
				}
				num = (short)1076428800;
				short num3 = num;
				num = (short)121438209;
				if (num != 0)
				{
				}
				global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
				try
				{
					num = (short)1575682048;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_F6;
							}
							continue;
						case 1:
							num = (short)407764995;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1021313025;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)1268187143;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_21A;
						case 5:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::DevComponents.WpfEditors.Primitives.EditorInputBase)
							{
								num = (short)1445658633;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
						{
							global::System.Windows.UIElement uielement;
							((global::DevComponents.WpfEditors.Primitives.EditorInputGroup)uielement).IsEmpty = true;
							num = (short)319225860;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::DevComponents.WpfEditors.Primitives.EditorInputGroup)
							{
								num = (short)596836358;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)341114885;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::System.Windows.UIElement uielement;
							((global::DevComponents.WpfEditors.Primitives.EditorInputBase)uielement).IsEmpty = true;
							num = (short)1855913992;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_11A:
						num = (short)1080426498;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_F6:
						goto IL_11A;
					}
					IL_21A:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_238;
					}
					int num4;
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_226:
						switch (num4)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)963706881;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_28A;
						case 1:
							disposable.Dispose();
							num = (short)770965506;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_288;
						}
						goto IL_238;
					}
					IL_288:
					IL_28A:
					break;
					IL_238:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1058406400;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_226;
				}
				break;
			}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0006F414 File Offset: 0x0006D614
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x0006F4C4 File Offset: 0x0006D6C4
		public bool IsUserInput
		{
			get
			{
				short num = (short)585214010;
				short num2 = num;
				num = (short)1364764730;
				switch (num2 == num)
				{
				}
				num = (short)129171457;
				if (num != 0)
				{
				}
				num = (short)759300096;
				short num3 = num;
				num = (short)621084672;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1816218187;
				short num2 = num;
				num = (short)1160333899;
				switch (num2 == num)
				{
				}
				num = (short)1752825856;
				if (num != 0)
				{
				}
				num = (short)1807417344;
				short num3 = num;
				num = (short)1878917121;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0006F574 File Offset: 0x0006D774
		protected override void OnPreviewTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			short num = (short)485883905;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					e.Handled = true;
					num = (short)215941125;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 2:
					if (this.SelectNextInputCharacters.Contains(e.Text))
					{
						num = (short)1762000899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AE;
				case 3:
				{
					num = (short)1170604032;
					short num3 = num;
					num = (short)1087569924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					num = (short)550895617;
					if (num != 0)
					{
					}
					if (this.b())
					{
						num = (short)1256718336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AE;
				case 5:
					goto IL_D5;
				case 6:
				{
					num = (short)1390193857;
					short num4 = num;
					num = (short)153595073;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AE;
					default:
						num = (short)295108608;
						if (num != 0)
						{
						}
						num = (short)1136066562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_41:
				if (this.SelectNextInputCharacters.Length <= 0)
				{
					break;
				}
				num = (short)1169293318;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D5:
			IL_1AE:
			base.OnPreviewTextInput(e);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0006F738 File Offset: 0x0006D938
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			short num = (short)171900929;
			if (num != 0)
			{
			}
			num = (short)1783365632;
			switch (num)
			{
			default:
			{
				num = (short)465960972;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Point origin;
					global::System.Windows.Rect watermarkBounds;
					global::System.Windows.Media.FormattedText formattedText;
					global::System.Windows.Media.Brush brush;
					global::System.Windows.Media.MatrixTransform matrixTransform;
					switch (num2)
					{
					case 0:
						goto IL_3C4;
					case 1:
						goto IL_204;
					case 2:
						if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							num = (short)1579876370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34D;
					case 3:
					{
						num = (short)959250432;
						short num3 = num;
						origin.X += (watermarkBounds.Width - formattedText.Width) / 2.0;
						num = (short)231407622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (brush == null)
						{
							num = (short)534446080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					case 5:
						brush = this.WatermarkBrush;
						num = (short)1432944644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_280;
					case 7:
						origin.X += watermarkBounds.Width - formattedText.Width;
						num = (short)2125529097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (matrixTransform != null)
						{
							num = (short)2037383183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16D;
					case 9:
						goto IL_280;
					case 10:
						goto IL_16D;
					case 11:
						drawingContext.Pop();
						num = (short)874774545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						num = (short)1257621451;
						short num4 = num;
						num = (short)635619275;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C4;
						default:
							num = (short)1173553152;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_105;
							}
							continue;
						}
						break;
					}
					case 13:
						if (matrixTransform != null)
						{
							num = (short)82968587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B;
					case 14:
						if (this.WatermarkAlignment == global::System.Windows.HorizontalAlignment.Right)
						{
							num = (short)227540999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 15:
						drawingContext.PushTransform(matrixTransform);
						num = (short)240386058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_34D;
					case 17:
						goto IL_348;
					case 18:
					{
						double m = -1.0;
						double m2 = 1.0;
						double width = formattedText.Width;
						double offsetY = 0.0;
						matrixTransform = new global::System.Windows.Media.MatrixTransform(m, 0.0, 0.0, m2, width, offsetY);
						num = (short)1561460752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (this.WatermarkAlignment == global::System.Windows.HorizontalAlignment.Center)
						{
							num = (short)513605635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)913965070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_105:
					if (this.RenderWatermark)
					{
						num = (short)737017861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_16D:
					watermarkBounds = this.GetWatermarkBounds();
					origin = new global::System.Windows.Point(watermarkBounds.X, (watermarkBounds.Height - formattedText.Height) / 2.0);
					num = (short)1974009875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_204:
					formattedText = new global::System.Windows.Media.FormattedText(this.WatermarkText, global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture(), global::System.Windows.FlowDirection.LeftToRight, new global::System.Windows.Media.Typeface(base.FontFamily, base.FontStyle, base.FontWeight, base.FontStretch), base.FontSize, brush);
					matrixTransform = null;
					num = (short)724893698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_280:
					drawingContext.DrawText(formattedText, origin);
					num = (short)1922760717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34D:
					num = (short)638517256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C4:
					brush = global::System.Windows.SystemColors.ControlDarkBrush;
					num = (short)812974081;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_348:
				IL_48B:
				base.OnRender(drawingContext);
				return;
			}
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0006FBD8 File Offset: 0x0006DDD8
		protected virtual global::System.Windows.Rect GetWatermarkBounds()
		{
			short num = (short)886046721;
			if (num != 0)
			{
			}
			num = (short)338624512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Windows.Rect result = new global::System.Windows.Rect(base.RenderSize);
				global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
				try
				{
					num = (short)262668291;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_20A;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1812398086;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)1466892293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)1593180164;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_AB;
							}
							continue;
						case 4:
						{
							global::System.Windows.UIElement uielement;
							double num3 = uielement.RenderSize.Width + 4.0;
							result.X += num3;
							result.Width -= num3;
							num = (short)994574336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::DevComponents.WpfEditors.Primitives.LockUpdateCheckBox)
							{
								num = (short)690552840;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
						{
							num = (short)572290184;
							short num4 = num;
							num = (short)187856008;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_228;
							default:
								num = (short)2010578944;
								if (num != 0)
								{
								}
								num = (short)971964423;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							goto IL_228;
						case 8:
							num = (short)661913602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_F1:
						num = (short)2139160577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_AB:
						goto IL_F1;
					}
					IL_20A:
					IL_228:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_247;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_234:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)1013448705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_29B;
						case 2:
							if (disposable != null)
							{
								num = (short)1679949824;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_29D;
						}
						goto IL_247;
					}
					IL_29B:
					IL_29D:
					goto EndFinally_7;
					IL_247:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)563412994;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_234;
					EndFinally_7:;
				}
				num = (short)238354432;
				short num5 = num;
				return result;
			}
			}
		}

		// Token: 0x04000278 RID: 632
		public static readonly global::System.Windows.DependencyProperty AutoAdvanceProperty;

		// Token: 0x04000279 RID: 633
		public static readonly global::System.Windows.DependencyProperty AutoOverwriteProperty;

		// Token: 0x0400027A RID: 634
		public static readonly global::System.Windows.DependencyProperty SelectNextInputCharactersProperty;

		// Token: 0x0400027B RID: 635
		public static readonly global::System.Windows.DependencyProperty AllowEmptyStateProperty;

		// Token: 0x0400027C RID: 636
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty;

		// Token: 0x0400027D RID: 637
		public static readonly global::System.Windows.DependencyProperty WatermarkTextProperty;

		// Token: 0x0400027E RID: 638
		public static readonly global::System.Windows.DependencyProperty WatermarkBrushProperty;

		// Token: 0x0400027F RID: 639
		public static readonly global::System.Windows.DependencyProperty WatermarkEnabledProperty;

		// Token: 0x04000280 RID: 640
		public static readonly global::System.Windows.DependencyProperty WatermarkAlignmentProperty;

		// Token: 0x04000281 RID: 641
		public static readonly global::System.Windows.DependencyProperty WatermarkBehaviorProperty;

		// Token: 0x04000282 RID: 642
		private bool a = true;

		// Token: 0x04000283 RID: 643
		private bool b;
	}
}
