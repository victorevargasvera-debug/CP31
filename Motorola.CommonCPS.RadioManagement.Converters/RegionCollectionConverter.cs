using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200007B RID: 123
	public class RegionCollectionConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00013A44 File Offset: 0x00011C44
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)243924992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				object result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName> observableCollection;
					for (;;)
					{
						IL_2F:
						switch (num2)
						{
						case 0:
							goto IL_24F;
						case 1:
							try
							{
								num = (short)1489436676;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_173;
									case 2:
										num = (short)1456406528;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)840040450;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName region = enumerator.Current;
										list.Add(region.ToResourceString());
										num = (short)919273473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_F7;
										}
										continue;
									}
									IL_F9:
									num = (short)901513219;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_F7:
									goto IL_F9;
								}
								IL_173:;
							}
							finally
							{
								num = (short)1843396610;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName> enumerator;
									switch (num2)
									{
									case 0:
									{
										enumerator.Dispose();
										num = (short)1274042937;
										short num3 = num;
										num = (short)1932089913;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_18E;
										default:
											num = (short)1753677824;
											if (num != 0)
											{
											}
											num = (short)1262419969;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										goto IL_232;
									case 2:
										goto IL_18E;
									}
									goto IL_1AB;
									IL_18E:
									switch (0)
									{
									case 0:
										IL_1AB:
										if (enumerator == null)
										{
											goto IL_234;
										}
										num = (short)1994588160;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
								}
								IL_232:
								IL_234:;
							}
							result = list;
							num = (short)370737152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_97;
						case 3:
							result = list;
							num = (short)1418854402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (observableCollection == null)
							{
								num = (short)579731459;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName> enumerator = observableCollection.GetEnumerator();
							num = (short)556859393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_4A;
					}
					IL_97:
					IL_24F:
					goto IL_256;
					IL_4A:
					observableCollection = (value as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName>);
					num = (short)926089220;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_2F;
				}
				catch (global::System.Exception)
				{
					result = list;
				}
				IL_256:
				num = (short)561119233;
				if (num != 0)
				{
				}
				num = (short)763297792;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00013D30 File Offset: 0x00011F30
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)50747055;
			short num2 = num;
			num = (short)271996591;
			switch (num2 == num)
			{
			}
			num = (short)870711296;
			if (num != 0)
			{
			}
			num = (short)433848321;
			if (num != 0)
			{
			}
			num = (short)2014380032;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
