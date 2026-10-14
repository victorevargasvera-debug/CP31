using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace System.Data.Entity.Hierarchy
{
	// Token: 0x020002C9 RID: 713
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class HierarchyId : global::System.IComparable
	{
		// Token: 0x06002243 RID: 8771 RVA: 0x0005FB41 File Offset: 0x0005DD41
		public HierarchyId()
		{
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x0005FB4C File Offset: 0x0005DD4C
		public HierarchyId(string hierarchyId)
		{
			this._hierarchyId = hierarchyId;
			if (hierarchyId != null)
			{
				string[] array = hierarchyId.Split(new char[]
				{
					'/'
				});
				if (!string.IsNullOrEmpty(array[0]) || !string.IsNullOrEmpty(array[array.Length - 1]))
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The input string '{0}' is not a valid string representation of a HierarchyId node.", new object[]
					{
						hierarchyId
					}), "hierarchyId");
				}
				int num = array.Length - 2;
				int[][] array2 = new int[num][];
				for (int i = 0; i < num; i++)
				{
					string[] array3 = array[i + 1].Split(new char[]
					{
						'.'
					});
					int[] array4 = new int[array3.Length];
					for (int j = 0; j < array3.Length; j++)
					{
						int num2;
						if (!int.TryParse(array3[j], out num2))
						{
							throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The input string '{0}' is not a valid string representation of a HierarchyId node.", new object[]
							{
								hierarchyId
							}), "hierarchyId");
						}
						array4[j] = num2;
					}
					array2[i] = array4;
				}
				this._nodes = array2;
			}
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x0005FC50 File Offset: 0x0005DE50
		public global::System.Data.Entity.Hierarchy.HierarchyId GetAncestor(int n)
		{
			if (this._nodes == null || (int)this.GetLevel() < n)
			{
				return new global::System.Data.Entity.Hierarchy.HierarchyId(null);
			}
			if ((int)this.GetLevel() == n)
			{
				return new global::System.Data.Entity.Hierarchy.HierarchyId("/");
			}
			return new global::System.Data.Entity.Hierarchy.HierarchyId("/" + string.Join("/", this._nodes.Take((int)this.GetLevel() - n).Select(new global::System.Func<int[], string>(global::System.Data.Entity.Hierarchy.HierarchyId.IntArrayToStirng))) + "/");
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0005FCCC File Offset: 0x0005DECC
		public global::System.Data.Entity.Hierarchy.HierarchyId GetDescendant(global::System.Data.Entity.Hierarchy.HierarchyId child1, global::System.Data.Entity.Hierarchy.HierarchyId child2)
		{
			if (this._nodes == null)
			{
				return new global::System.Data.Entity.Hierarchy.HierarchyId(null);
			}
			if (child1 != null && (child1.GetLevel() != this.GetLevel() + 1 || !child1.IsDescendantOf(this)))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "HierarchyId.GetDescendant failed because '{0}' must be a child of 'this'.  '{0}' was '{1}' and 'this' was '{2}'.", new object[]
				{
					"child1",
					child1,
					this.ToString()
				}), "child1");
			}
			if (child2 != null && (child2.GetLevel() != this.GetLevel() + 1 || !child2.IsDescendantOf(this)))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "HierarchyId.GetDescendant failed because '{0}' must be a child of 'this'.  '{0}' was '{1}' and 'this' was '{2}'.", new object[]
				{
					"child2",
					child1,
					this.ToString()
				}), "child2");
			}
			if (child1 == null && child2 == null)
			{
				return new global::System.Data.Entity.Hierarchy.HierarchyId(this.ToString() + 1.ToString() + "/");
			}
			if (child1 == null)
			{
				global::System.Data.Entity.Hierarchy.HierarchyId hierarchyId = new global::System.Data.Entity.Hierarchy.HierarchyId(child2.ToString());
				int[] array = hierarchyId._nodes.Last<int[]>();
				array[array.Length - 1]--;
				return new global::System.Data.Entity.Hierarchy.HierarchyId("/" + string.Join("/", hierarchyId._nodes.Select(new global::System.Func<int[], string>(global::System.Data.Entity.Hierarchy.HierarchyId.IntArrayToStirng))) + "/");
			}
			if (child2 == null)
			{
				global::System.Data.Entity.Hierarchy.HierarchyId hierarchyId2 = new global::System.Data.Entity.Hierarchy.HierarchyId(child1.ToString());
				int[] array2 = hierarchyId2._nodes.Last<int[]>();
				array2[array2.Length - 1]++;
				return new global::System.Data.Entity.Hierarchy.HierarchyId("/" + string.Join("/", hierarchyId2._nodes.Select(new global::System.Func<int[], string>(global::System.Data.Entity.Hierarchy.HierarchyId.IntArrayToStirng))) + "/");
			}
			int[] array3 = child1._nodes.Last<int[]>();
			int[] array4 = child2._nodes.Last<int[]>();
			if (global::System.Data.Entity.Hierarchy.HierarchyId.CompareIntArrays(array3, array4) >= 0)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "HierarchyId.GetDescendant failed because 'child1' must be less than 'child2'.  'child1' was '{0}' and 'child2' was '{1}'.", new object[]
				{
					child1,
					child2
				}), "child1");
			}
			int num = 0;
			while (num < array3.Length && array3[num] >= array4[num])
			{
				num++;
			}
			array3 = array3.Take(num + 1).ToArray<int>();
			if (array3[num] + 1 < array4[num])
			{
				array3[num]++;
			}
			else
			{
				array3 = array3.Concat(new int[]
				{
					1
				}).ToArray<int>();
			}
			return new global::System.Data.Entity.Hierarchy.HierarchyId(string.Concat(new string[]
			{
				"/",
				string.Join("/", this._nodes.Select(new global::System.Func<int[], string>(global::System.Data.Entity.Hierarchy.HierarchyId.IntArrayToStirng))),
				"/",
				global::System.Data.Entity.Hierarchy.HierarchyId.IntArrayToStirng(array3),
				"/"
			}));
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x0005FF89 File Offset: 0x0005E189
		public short GetLevel()
		{
			if (this._nodes == null)
			{
				return 0;
			}
			return (short)this._nodes.Length;
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0005FF9E File Offset: 0x0005E19E
		public static global::System.Data.Entity.Hierarchy.HierarchyId GetRoot()
		{
			return global::System.Data.Entity.Hierarchy.DbHierarchyServices.GetRoot();
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0005FFA8 File Offset: 0x0005E1A8
		public bool IsDescendantOf(global::System.Data.Entity.Hierarchy.HierarchyId parent)
		{
			if (parent == null)
			{
				return true;
			}
			if (this._nodes == null || parent.GetLevel() > this.GetLevel())
			{
				return false;
			}
			for (int i = 0; i < (int)parent.GetLevel(); i++)
			{
				if (global::System.Data.Entity.Hierarchy.HierarchyId.CompareIntArrays(this._nodes[i], parent._nodes[i]) != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00060004 File Offset: 0x0005E204
		public global::System.Data.Entity.Hierarchy.HierarchyId GetReparentedValue(global::System.Data.Entity.Hierarchy.HierarchyId oldRoot, global::System.Data.Entity.Hierarchy.HierarchyId newRoot)
		{
			if (oldRoot == null || newRoot == null)
			{
				return new global::System.Data.Entity.Hierarchy.HierarchyId(null);
			}
			if (!this.IsDescendantOf(oldRoot))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "HierarchyId.GetReparentedValue failed because 'oldRoot' was not an ancestor node of 'this'.  'oldRoot' was '{0}', and 'this' was '{1}'.", new object[]
				{
					oldRoot,
					this.ToString()
				}), "oldRoot");
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("/");
			foreach (int[] array in newRoot._nodes)
			{
				stringBuilder.Append(global::System.Data.Entity.Hierarchy.HierarchyId.IntArrayToStirng(array));
				stringBuilder.Append("/");
			}
			foreach (int[] array2 in this._nodes.Skip((int)oldRoot.GetLevel()))
			{
				stringBuilder.Append(global::System.Data.Entity.Hierarchy.HierarchyId.IntArrayToStirng(array2));
				stringBuilder.Append("/");
			}
			return new global::System.Data.Entity.Hierarchy.HierarchyId(stringBuilder.ToString());
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x00060114 File Offset: 0x0005E314
		public static global::System.Data.Entity.Hierarchy.HierarchyId Parse(string input)
		{
			return new global::System.Data.Entity.Hierarchy.HierarchyId(input);
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x0006011C File Offset: 0x0005E31C
		private static string IntArrayToStirng(global::System.Collections.Generic.IEnumerable<int> array)
		{
			return string.Join<int>(".", array);
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x0006012C File Offset: 0x0005E32C
		private static int CompareIntArrays(int[] array1, int[] array2)
		{
			int num = global::System.Math.Min(array1.Length, array2.Length);
			for (int i = 0; i < num; i++)
			{
				int num2 = array1[i];
				int num3 = array2[i];
				if (num2 < num3)
				{
					return -1;
				}
				if (num2 > num3)
				{
					return 1;
				}
			}
			if (array1.Length > num)
			{
				return 1;
			}
			if (array2.Length > num)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x00060178 File Offset: 0x0005E378
		public static int Compare(global::System.Data.Entity.Hierarchy.HierarchyId hid1, global::System.Data.Entity.Hierarchy.HierarchyId hid2)
		{
			int[][] array = (hid1 == null) ? null : hid1._nodes;
			int[][] array2 = (hid2 == null) ? null : hid2._nodes;
			if (array == null && array2 == null)
			{
				return 0;
			}
			if (array == null)
			{
				return -1;
			}
			if (array2 == null)
			{
				return 1;
			}
			int num = global::System.Math.Min(array.Length, array2.Length);
			for (int i = 0; i < num; i++)
			{
				int[] array3 = array[i];
				int[] array4 = array2[i];
				int num2 = global::System.Data.Entity.Hierarchy.HierarchyId.CompareIntArrays(array3, array4);
				if (num2 != 0)
				{
					return num2;
				}
			}
			if (hid1._nodes.Length > num)
			{
				return 1;
			}
			if (hid2._nodes.Length > num)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x000601FC File Offset: 0x0005E3FC
		public static bool operator <(global::System.Data.Entity.Hierarchy.HierarchyId hid1, global::System.Data.Entity.Hierarchy.HierarchyId hid2)
		{
			return global::System.Data.Entity.Hierarchy.HierarchyId.Compare(hid1, hid2) < 0;
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x00060208 File Offset: 0x0005E408
		public static bool operator >(global::System.Data.Entity.Hierarchy.HierarchyId hid1, global::System.Data.Entity.Hierarchy.HierarchyId hid2)
		{
			return hid2 < hid1;
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x00060211 File Offset: 0x0005E411
		public static bool operator <=(global::System.Data.Entity.Hierarchy.HierarchyId hid1, global::System.Data.Entity.Hierarchy.HierarchyId hid2)
		{
			return global::System.Data.Entity.Hierarchy.HierarchyId.Compare(hid1, hid2) <= 0;
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x00060220 File Offset: 0x0005E420
		public static bool operator >=(global::System.Data.Entity.Hierarchy.HierarchyId hid1, global::System.Data.Entity.Hierarchy.HierarchyId hid2)
		{
			return hid2 <= hid1;
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00060229 File Offset: 0x0005E429
		public static bool operator ==(global::System.Data.Entity.Hierarchy.HierarchyId hid1, global::System.Data.Entity.Hierarchy.HierarchyId hid2)
		{
			return global::System.Data.Entity.Hierarchy.HierarchyId.Compare(hid1, hid2) == 0;
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00060235 File Offset: 0x0005E435
		public static bool operator !=(global::System.Data.Entity.Hierarchy.HierarchyId hid1, global::System.Data.Entity.Hierarchy.HierarchyId hid2)
		{
			return !(hid1 == hid2);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00060241 File Offset: 0x0005E441
		protected bool Equals(global::System.Data.Entity.Hierarchy.HierarchyId other)
		{
			return this == other;
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x0006024A File Offset: 0x0005E44A
		public override int GetHashCode()
		{
			if (this._hierarchyId == null)
			{
				return 0;
			}
			return this._hierarchyId.GetHashCode();
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00060261 File Offset: 0x0005E461
		public override bool Equals(object obj)
		{
			return this.Equals((global::System.Data.Entity.Hierarchy.HierarchyId)obj);
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x0006026F File Offset: 0x0005E46F
		public override string ToString()
		{
			return this._hierarchyId;
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00060278 File Offset: 0x0005E478
		public int CompareTo(object obj)
		{
			global::System.Data.Entity.Hierarchy.HierarchyId hierarchyId = obj as global::System.Data.Entity.Hierarchy.HierarchyId;
			if (hierarchyId != null)
			{
				return global::System.Data.Entity.Hierarchy.HierarchyId.Compare(this, hierarchyId);
			}
			return -1;
		}

		// Token: 0x04000BE7 RID: 3047
		private readonly string _hierarchyId;

		// Token: 0x04000BE8 RID: 3048
		private readonly int[][] _nodes;

		// Token: 0x04000BE9 RID: 3049
		public const string PathSeparator = "/";

		// Token: 0x04000BEA RID: 3050
		private const string InvalidHierarchyIdExceptionMessage = "The input string '{0}' is not a valid string representation of a HierarchyId node.";

		// Token: 0x04000BEB RID: 3051
		private const string GetReparentedValueOldRootExceptionMessage = "HierarchyId.GetReparentedValue failed because 'oldRoot' was not an ancestor node of 'this'.  'oldRoot' was '{0}', and 'this' was '{1}'.";

		// Token: 0x04000BEC RID: 3052
		private const string GetDescendantMostBeChildExceptionMessage = "HierarchyId.GetDescendant failed because '{0}' must be a child of 'this'.  '{0}' was '{1}' and 'this' was '{2}'.";

		// Token: 0x04000BED RID: 3053
		private const string GetDescendantChild1MustLessThanChild2ExceptionMessage = "HierarchyId.GetDescendant failed because 'child1' must be less than 'child2'.  'child1' was '{0}' and 'child2' was '{1}'.";
	}
}
