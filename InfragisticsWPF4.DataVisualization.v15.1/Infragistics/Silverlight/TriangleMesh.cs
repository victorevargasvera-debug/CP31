using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Infragistics.Silverlight
{
	// Token: 0x020000C3 RID: 195
	public class TriangleMesh
	{
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x00026810 File Offset: 0x00024A10
		public global::System.Collections.ObjectModel.Collection<global::Infragistics.Silverlight.Triangle> TriangleList
		{
			get
			{
				if (this.triangleList != null)
				{
					return this.triangleList;
				}
				if (this.pointList == null || this.pointList.Count < 3)
				{
					this.triangleList = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Silverlight.Triangle>();
					return this.triangleList;
				}
				global::Infragistics.Silverlight.HalfEdgeCollection halfEdgeCollection = new global::Infragistics.Silverlight.HalfEdgeCollection();
				global::Infragistics.Silverlight.TriangleMesh.PointTester pointTester = new global::Infragistics.Silverlight.TriangleMesh.PointTester();
				int num = 0;
				global::Infragistics.Silverlight.Triangle[] array = new global::Infragistics.Silverlight.Triangle[4 * this.pointList.Count];
				bool[] array2 = new bool[array.Length];
				global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>
				{
					Capacity = this.pointList.Count
				};
				for (int i = 0; i < this.pointList.Count; i++)
				{
					list.Add(i);
				}
				list.Sort(new global::Infragistics.Silverlight.TriangleMesh.Comparer(this.pointList));
				double x = this.pointList[list[0]].X;
				double x2 = this.pointList[list[this.pointList.Count - 1]].X;
				double num2 = this.pointList[0].Y;
				double num3 = num2;
				for (int j = 1; j < this.pointList.Count; j++)
				{
					num2 = global::System.Math.Min(num2, this.pointList[j].Y);
					num3 = global::System.Math.Max(num3, this.pointList[j].Y);
				}
				double val = x2 - x;
				double val2 = num3 - num2;
				double num4 = global::System.Math.Max(val, val2);
				double num5 = (x2 + x) / 2.0;
				double num6 = (num3 + num2) / 2.0;
				this.s0 = new global::System.Windows.Point(num5 - 20.0 * num4, num6 - num4);
				this.s1 = new global::System.Windows.Point(num5, num6 + 20.0 * num4);
				this.s2 = new global::System.Windows.Point(num5 + 20.0 * num4, num6 - num4);
				array[0] = new global::Infragistics.Silverlight.Triangle
				{
					v0 = this.pointList.Count,
					v1 = this.pointList.Count + 1,
					v2 = this.pointList.Count + 2
				};
				array2[0] = false;
				for (int k = 1; k < array.Length; k++)
				{
					array[k] = new global::Infragistics.Silverlight.Triangle();
					array2[k] = false;
				}
				num++;
				for (int l = 0; l < this.pointList.Count; l++)
				{
					halfEdgeCollection.Clear();
					for (int m = 0; m < num; m++)
					{
						if (!array2[m])
						{
							pointTester.Test(this.point(list[l]), this.point(array[m].v0), this.point(array[m].v1), this.point(array[m].v2));
							array2[m] = pointTester.Complete;
							if (pointTester.Inside)
							{
								global::Infragistics.Silverlight.HalfEdge edge = new global::Infragistics.Silverlight.HalfEdge(array[m].v0, array[m].v1);
								if (halfEdgeCollection.Contains(edge))
								{
									halfEdgeCollection.Remove(edge);
								}
								else
								{
									halfEdgeCollection.Add(edge);
								}
								edge = new global::Infragistics.Silverlight.HalfEdge(array[m].v1, array[m].v2);
								if (halfEdgeCollection.Contains(edge))
								{
									halfEdgeCollection.Remove(edge);
								}
								else
								{
									halfEdgeCollection.Add(edge);
								}
								edge = new global::Infragistics.Silverlight.HalfEdge(array[m].v2, array[m].v0);
								if (halfEdgeCollection.Contains(edge))
								{
									halfEdgeCollection.Remove(edge);
								}
								else
								{
									halfEdgeCollection.Add(edge);
								}
								array[m].v0 = array[num - 1].v0;
								array[m].v1 = array[num - 1].v1;
								array[m].v2 = array[num - 1].v2;
								array2[m] = array2[num - 1];
								num--;
								m--;
							}
						}
					}
					foreach (global::Infragistics.Silverlight.HalfEdge halfEdge in halfEdgeCollection)
					{
						array[num].v0 = halfEdge.Beg;
						array[num].v1 = halfEdge.End;
						array[num].v2 = list[l];
						array2[num] = false;
						num++;
					}
				}
				this.triangleList = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Silverlight.Triangle>();
				for (int n = 0; n < num; n++)
				{
					if (array[n].v0 < this.pointList.Count && array[n].v1 < this.pointList.Count && array[n].v2 < this.pointList.Count)
					{
						this.triangleList.Add(array[n]);
					}
				}
				return this.triangleList;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00026D04 File Offset: 0x00024F04
		public global::Infragistics.Silverlight.HalfEdgeCollection EdgeCollection
		{
			get
			{
				if (this._edgeCollection == null)
				{
					this._edgeCollection = new global::Infragistics.Silverlight.HalfEdgeCollection();
					foreach (global::Infragistics.Silverlight.Triangle triangle in this.TriangleList)
					{
						global::Infragistics.Silverlight.HalfEdge edge = new global::Infragistics.Silverlight.HalfEdge(triangle.v0, triangle.v1);
						if (!this._edgeCollection.Contains(edge))
						{
							this._edgeCollection.Add(edge);
						}
						else
						{
							this._edgeCollection.Remove(edge);
						}
						edge = new global::Infragistics.Silverlight.HalfEdge(triangle.v1, triangle.v2);
						if (!this._edgeCollection.Contains(edge))
						{
							this._edgeCollection.Add(edge);
						}
						else
						{
							this._edgeCollection.Remove(edge);
						}
						edge = new global::Infragistics.Silverlight.HalfEdge(triangle.v2, triangle.v0);
						if (!this._edgeCollection.Contains(edge))
						{
							this._edgeCollection.Add(edge);
						}
						else
						{
							this._edgeCollection.Remove(edge);
						}
					}
				}
				return this._edgeCollection;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00026E1C File Offset: 0x0002501C
		public global::System.Collections.Generic.IList<global::System.Windows.Point> Points
		{
			get
			{
				global::System.Collections.Generic.IList<global::System.Windows.Point> result;
				if ((result = this.pointList) == null)
				{
					result = (this.pointList = new global::System.Collections.Generic.List<global::System.Windows.Point>());
				}
				return result;
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00026E44 File Offset: 0x00025044
		private global::System.Windows.Point point(int i)
		{
			if (i < this.pointList.Count)
			{
				return this.pointList[i];
			}
			if (i == this.pointList.Count)
			{
				return this.s0;
			}
			if (i == this.pointList.Count + 1)
			{
				return this.s1;
			}
			return this.s2;
		}

		// Token: 0x04000300 RID: 768
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Silverlight.Triangle> triangleList;

		// Token: 0x04000301 RID: 769
		private global::Infragistics.Silverlight.HalfEdgeCollection _edgeCollection;

		// Token: 0x04000302 RID: 770
		private global::System.Collections.Generic.IList<global::System.Windows.Point> pointList;

		// Token: 0x04000303 RID: 771
		private global::System.Windows.Point s0;

		// Token: 0x04000304 RID: 772
		private global::System.Windows.Point s1;

		// Token: 0x04000305 RID: 773
		private global::System.Windows.Point s2;

		// Token: 0x020000C4 RID: 196
		private class Comparer : global::System.Collections.Generic.IComparer<int>
		{
			// Token: 0x06000847 RID: 2119 RVA: 0x00026EA6 File Offset: 0x000250A6
			public Comparer(global::System.Collections.Generic.IList<global::System.Windows.Point> points)
			{
				this.points = points;
			}

			// Token: 0x06000848 RID: 2120 RVA: 0x00026EB8 File Offset: 0x000250B8
			public int Compare(int i0, int i1)
			{
				if (this.points[i0].X < this.points[i1].X)
				{
					return -1;
				}
				if (this.points[i0].X == this.points[i1].X)
				{
					if (this.points[i0].Y < this.points[i1].Y)
					{
						return -1;
					}
					if (this.points[i0].Y == this.points[i1].Y)
					{
						return 0;
					}
				}
				return 1;
			}

			// Token: 0x04000306 RID: 774
			private global::System.Collections.Generic.IList<global::System.Windows.Point> points;
		}

		// Token: 0x020000C5 RID: 197
		private class PointTester
		{
			// Token: 0x06000849 RID: 2121 RVA: 0x00026F78 File Offset: 0x00025178
			public bool Test(global::System.Windows.Point P, global::System.Windows.Point P1, global::System.Windows.Point P2, global::System.Windows.Point P3)
			{
				double num = global::System.Math.Abs(P1.Y - P2.Y);
				double num2 = global::System.Math.Abs(P2.Y - P3.Y);
				double num3 = 0.0;
				double num4 = 0.0;
				if (num == 0.0 && num2 == 0.0)
				{
					return false;
				}
				if (num == 0.0 && num2 != 0.0)
				{
					num3 = (P2.X + P1.X) / 2.0;
					num4 = -(P3.X - P2.X) / (P3.Y - P2.Y) * (num3 - (P2.X + P3.X) / 2.0) + (P2.Y + P3.Y) / 2.0;
				}
				if (num != 0.0 && num2 == 0.0)
				{
					num3 = (P3.X + P2.X) / 2.0;
					num4 = -(P2.X - P1.X) / (P2.Y - P1.Y) * (num3 - (P1.X + P2.X) / 2.0) + (P1.Y + P2.Y) / 2.0;
				}
				if (num != 0.0 && num2 != 0.0)
				{
					double num5 = -(P2.X - P1.X) / (P2.Y - P1.Y);
					double num6 = -(P3.X - P2.X) / (P3.Y - P2.Y);
					double num7 = (P1.X + P2.X) / 2.0;
					double num8 = (P2.X + P3.X) / 2.0;
					double num9 = (P1.Y + P2.Y) / 2.0;
					double num10 = (P2.Y + P3.Y) / 2.0;
					num3 = (num5 * num7 - num6 * num8 + num10 - num9) / (num5 - num6);
					num4 = ((num > num2) ? (num5 * (num3 - num7) + num9) : (num6 * (num3 - num8) + num10));
				}
				double num11 = P2.X - num3;
				double num12 = P2.Y - num4;
				double num13 = num11 * num11 + num12 * num12;
				num11 = P.X - num3;
				num12 = P.Y - num4;
				double num14 = num11 * num11 + num12 * num12;
				this.Inside = (num14 <= num13);
				this.Complete = (num3 < P.X && (P.X - num3) * (P.X - num3) > num13);
				return true;
			}

			// Token: 0x170001E8 RID: 488
			// (get) Token: 0x0600084A RID: 2122 RVA: 0x00027270 File Offset: 0x00025470
			// (set) Token: 0x0600084B RID: 2123 RVA: 0x00027278 File Offset: 0x00025478
			public bool Complete { get; private set; }

			// Token: 0x170001E9 RID: 489
			// (get) Token: 0x0600084C RID: 2124 RVA: 0x00027281 File Offset: 0x00025481
			// (set) Token: 0x0600084D RID: 2125 RVA: 0x00027289 File Offset: 0x00025489
			public bool Inside { get; set; }
		}
	}
}
