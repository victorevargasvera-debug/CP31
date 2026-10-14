using System;
using System.Collections.Generic;
using System.Threading;

namespace Gibraltar
{
	// Token: 0x020000BD RID: 189
	internal static class StringReference
	{
		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00010620 File Offset: 0x0000E820
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0001062C File Offset: 0x0000E82C
		public static bool Disabled
		{
			get
			{
				return global::Gibraltar.StringReference.s_DisableCache;
			}
			set
			{
				global::Gibraltar.StringReference.s_DisableCache = value;
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00010638 File Offset: 0x0000E838
		public static void SwapReference(ref string baseline)
		{
			baseline = global::Gibraltar.StringReference.GetReference(baseline);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00010644 File Offset: 0x0000E844
		public static string GetReference(string baseline)
		{
			if (global::Gibraltar.StringReference.s_DisableCache)
			{
				return baseline;
			}
			if (baseline == null)
			{
				return null;
			}
			if (baseline.Length == 0)
			{
				return string.Empty;
			}
			string result = baseline;
			try
			{
				object obj = global::Gibraltar.StringReference.s_Lock;
				global::Gibraltar.StringReference.WeakStringCollection weakStringCollection = null;
				try
				{
					global::System.Threading.Monitor.Enter(obj);
					int hashCode = baseline.GetHashCode();
					if (global::Gibraltar.StringReference.s_StringReferences.TryGetValue(hashCode, out weakStringCollection))
					{
						if (weakStringCollection != null)
						{
							global::System.Threading.Monitor.Enter(weakStringCollection);
							global::System.Threading.Monitor.Exit(obj);
							obj = null;
							weakStringCollection.PackAndOrAdd(ref result);
						}
						else
						{
							global::Gibraltar.StringReference.s_StringReferences[hashCode] = new global::Gibraltar.StringReference.WeakStringCollection(baseline);
						}
					}
					else
					{
						global::Gibraltar.StringReference.s_StringReferences.Add(hashCode, new global::Gibraltar.StringReference.WeakStringCollection(baseline));
						global::Gibraltar.StringReference.s_PeakReferenceSize = global::System.Math.Max((long)global::Gibraltar.StringReference.s_StringReferences.Count, global::Gibraltar.StringReference.s_PeakReferenceSize);
					}
				}
				finally
				{
					if (obj != null)
					{
						global::System.Threading.Monitor.Exit(obj);
					}
					if (weakStringCollection != null)
					{
						global::System.Threading.Monitor.Exit(weakStringCollection);
					}
				}
			}
			catch (global::System.Exception obj2)
			{
				global::System.GC.KeepAlive(obj2);
			}
			return result;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00010750 File Offset: 0x0000E950
		public static void Pack()
		{
			if (global::Gibraltar.StringReference.s_DisableCache)
			{
				return;
			}
			try
			{
				object obj = global::Gibraltar.StringReference.s_Lock;
				global::System.Collections.Generic.List<int> list;
				global::System.Collections.Generic.KeyValuePair<int, global::Gibraltar.StringReference.WeakStringCollection>[] array;
				lock (obj)
				{
					int count = global::Gibraltar.StringReference.s_StringReferences.Count;
					if (count == 0)
					{
						return;
					}
					list = new global::System.Collections.Generic.List<int>(count / 4 + 1);
					array = new global::System.Collections.Generic.KeyValuePair<int, global::Gibraltar.StringReference.WeakStringCollection>[global::Gibraltar.StringReference.s_StringReferences.Count];
					int num = 0;
					foreach (global::System.Collections.Generic.KeyValuePair<int, global::Gibraltar.StringReference.WeakStringCollection> keyValuePair in global::Gibraltar.StringReference.s_StringReferences)
					{
						array[num++] = keyValuePair;
					}
				}
				foreach (global::System.Collections.Generic.KeyValuePair<int, global::Gibraltar.StringReference.WeakStringCollection> keyValuePair2 in array)
				{
					global::Gibraltar.StringReference.WeakStringCollection value = keyValuePair2.Value;
					if (value == null)
					{
						list.Add(keyValuePair2.Key);
					}
					else
					{
						global::Gibraltar.StringReference.WeakStringCollection obj2 = value;
						lock (obj2)
						{
							if (value.Pack() <= 0)
							{
								list.Add(keyValuePair2.Key);
							}
						}
					}
				}
				obj = global::Gibraltar.StringReference.s_Lock;
				lock (obj)
				{
					foreach (int key in list)
					{
						global::Gibraltar.StringReference.WeakStringCollection weakStringCollection;
						if (global::Gibraltar.StringReference.s_StringReferences.TryGetValue(key, out weakStringCollection))
						{
							if (weakStringCollection != null)
							{
								global::Gibraltar.StringReference.WeakStringCollection obj2 = weakStringCollection;
								lock (obj2)
								{
									if (weakStringCollection.Count <= 0)
									{
										global::Gibraltar.StringReference.s_StringReferences.Remove(key);
									}
									continue;
								}
							}
							global::Gibraltar.StringReference.s_StringReferences.Remove(key);
						}
					}
					if (global::Gibraltar.StringReference.s_PeakReferenceSize > 10240L && (double)global::Gibraltar.StringReference.s_StringReferences.Count / (double)((global::Gibraltar.StringReference.s_PeakReferenceSize == 0L) ? 1L : global::Gibraltar.StringReference.s_PeakReferenceSize) < 0.66)
					{
						global::Gibraltar.StringReference.s_PeakReferenceSize = (long)(global::Gibraltar.StringReference.s_StringReferences = new global::System.Collections.Generic.Dictionary<int, global::Gibraltar.StringReference.WeakStringCollection>(global::Gibraltar.StringReference.s_StringReferences)).Count;
					}
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.StringReference.s_Lock);
				}
			}
			catch (global::System.Exception obj3)
			{
				global::System.GC.KeepAlive(obj3);
			}
		}

		// Token: 0x0400019B RID: 411
		private const int DefaultCollectionSize = 1024;

		// Token: 0x0400019C RID: 412
		private const int MinimumRebuildSize = 10240;

		// Token: 0x0400019D RID: 413
		private const double FreeSpaceRebuildRatio = 0.66;

		// Token: 0x0400019E RID: 414
		private static readonly object s_Lock = new object();

		// Token: 0x0400019F RID: 415
		private static global::System.Collections.Generic.Dictionary<int, global::Gibraltar.StringReference.WeakStringCollection> s_StringReferences = new global::System.Collections.Generic.Dictionary<int, global::Gibraltar.StringReference.WeakStringCollection>(1024);

		// Token: 0x040001A0 RID: 416
		private static volatile bool s_DisableCache;

		// Token: 0x040001A1 RID: 417
		private static long s_PeakReferenceSize;

		// Token: 0x02000492 RID: 1170
		public class WeakStringCollection
		{
			// Token: 0x0600330A RID: 13066 RVA: 0x000B9788 File Offset: 0x000B7988
			public WeakStringCollection(string firstString)
			{
				this.m_FirstString = new global::System.WeakReference(firstString);
				this.m_ExtraStrings = null;
				this.m_ExtraCount = 0;
			}

			// Token: 0x17000EB5 RID: 3765
			// (get) Token: 0x0600330B RID: 13067 RVA: 0x000B97AC File Offset: 0x000B79AC
			public int Count
			{
				get
				{
					int result;
					lock (this)
					{
						result = this.m_ExtraCount + 1;
					}
					return result;
				}
			}

			// Token: 0x0600330C RID: 13068 RVA: 0x000B97E8 File Offset: 0x000B79E8
			public int Pack()
			{
				string text = null;
				return this.PackAndOrAdd(ref text);
			}

			// Token: 0x0600330D RID: 13069 RVA: 0x000B9804 File Offset: 0x000B7A04
			public int PackAndOrAdd(ref string newString)
			{
				int result;
				lock (this)
				{
					bool flag = newString != null;
					int num = -1;
					if (global::Gibraltar.StringReference.WeakStringCollection.CheckWeakReference(ref this.m_FirstString, ref newString))
					{
						result = this.m_ExtraCount + 1;
					}
					else
					{
						if (this.m_FirstString != null)
						{
							num++;
						}
						if (this.m_ExtraCount <= 0 && (!flag || num < 0))
						{
							if (flag)
							{
								this.m_FirstString = new global::System.WeakReference(newString);
								num++;
							}
							this.m_ExtraCount = num;
							result = this.m_ExtraCount + 1;
						}
						else
						{
							string text = null;
							for (int i = 0; i < this.m_ExtraCount; i++)
							{
								if (flag)
								{
									if (global::Gibraltar.StringReference.WeakStringCollection.CheckWeakReference(ref this.m_ExtraStrings[i], ref newString))
									{
										flag = false;
									}
								}
								else
								{
									global::Gibraltar.StringReference.WeakStringCollection.CheckWeakReference(ref this.m_ExtraStrings[i], ref text);
								}
								if (this.m_ExtraStrings[i] != null)
								{
									if (num < i)
									{
										if (num < 0)
										{
											this.m_FirstString = this.m_ExtraStrings[i];
										}
										else
										{
											this.m_ExtraStrings[num] = this.m_ExtraStrings[i];
										}
									}
									num++;
								}
							}
							int num2 = num + (flag ? 4 : 3);
							num2 -= num2 % 4;
							if (num2 <= 0)
							{
								this.m_ExtraStrings = null;
							}
							else if (this.m_ExtraStrings == null || num2 > this.m_ExtraStrings.Length || (newString == null && this.m_ExtraStrings.Length - num2 > 8))
							{
								global::System.WeakReference[] array = new global::System.WeakReference[num2];
								if (this.m_ExtraStrings != null)
								{
									for (int j = 0; j < num; j++)
									{
										array[j] = this.m_ExtraStrings[j];
									}
								}
								this.m_ExtraStrings = array;
							}
							else
							{
								for (int k = (num < 0) ? 0 : num; k < this.m_ExtraCount; k++)
								{
									this.m_ExtraStrings[k] = null;
								}
							}
							if (flag)
							{
								if (num < 0)
								{
									this.m_FirstString = new global::System.WeakReference(newString);
								}
								else if (this.m_ExtraStrings != null)
								{
									this.m_ExtraStrings[num] = new global::System.WeakReference(newString);
								}
								num++;
							}
							else if (num < 0)
							{
								this.m_FirstString = null;
							}
							this.m_ExtraCount = num;
							result = this.m_ExtraCount + 1;
						}
					}
				}
				return result;
			}

			// Token: 0x0600330E RID: 13070 RVA: 0x000B9AAC File Offset: 0x000B7CAC
			private static bool CheckWeakReference(ref global::System.WeakReference reference, ref string newString)
			{
				if (reference == null)
				{
					return false;
				}
				if (newString != null)
				{
					string text = reference.Target as string;
					if (text == null)
					{
						reference = null;
					}
					else if (newString == text)
					{
						newString = text;
						return true;
					}
				}
				else if (!reference.IsAlive)
				{
					reference = null;
				}
				return false;
			}

			// Token: 0x04001369 RID: 4969
			private global::System.WeakReference m_FirstString;

			// Token: 0x0400136A RID: 4970
			private global::System.WeakReference[] m_ExtraStrings;

			// Token: 0x0400136B RID: 4971
			private int m_ExtraCount;
		}
	}
}
