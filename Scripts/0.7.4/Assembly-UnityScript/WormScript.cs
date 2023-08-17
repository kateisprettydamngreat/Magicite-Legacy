using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class WormScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00242569 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00242570;

			internal WormScript _0024self__00242571;

			public _0024(WormScript self_)
			{
				_0024self__00242571 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected O, but got Unknown
				//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ff: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242571.HP = _0024self__00242571.maxHP;
					_0024self__00242571.drops = new int[3] { 7, 18, 0 };
					_0024self__00242571.t = ((Component)_0024self__00242571).transform;
					((MonoBehaviour)_0024self__00242571).StartCoroutine_Auto(_0024self__00242571.Initialize());
					if (_0024self__00242571.isHead)
					{
						_0024i_00242570 = default(int);
						_0024self__00242571.mainHead.animation.Play();
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_011e;
				case 2:
					_0024i_00242570 = 0;
					goto IL_0112;
				case 3:
					_0024i_00242570++;
					goto IL_0112;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0112:
					if (_0024i_00242570 < 7)
					{
						_0024self__00242571.parts[_0024i_00242570].animation.Play("wBody");
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_011e;
					IL_011e:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal WormScript _0024self__00242572;

		public _0024Start_00242569(WormScript self_)
		{
			_0024self__00242572 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242572);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Initialize_00242573 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WormScript _0024self__00242574;

			public _0024(WormScript self_)
			{
				_0024self__00242574 = self_;
			}

			public override bool MoveNext()
			{
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d1: Expected O, but got Unknown
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (_0024self__00242574.isHead)
					{
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00242574).networkView.RPC("SetHead", (RPCMode)2, new object[0]);
							_0024self__00242574.speed = 10f;
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
						}
						else
						{
							_0024self__00242574.mainHead.renderer.material = _0024self__00242574.leadHead;
							_0024self__00242574.speed = 10f;
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
						}
						break;
					}
					goto IL_0108;
				case 2:
					((MonoBehaviour)_0024self__00242574).StartCoroutine_Auto(_0024self__00242574.Attack());
					goto IL_0108;
				case 3:
					_0024self__00242574.mainHead.animation.Play("wHead");
					((MonoBehaviour)_0024self__00242574).StartCoroutine_Auto(_0024self__00242574.Attack());
					goto IL_0108;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0108:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal WormScript _0024self__00242575;

		public _0024Initialize_00242573(WormScript self_)
		{
			_0024self__00242575 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242575);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Attack_00242576 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WormScript _0024self__00242577;

			public _0024(WormScript self_)
			{
				_0024self__00242577 = self_;
			}

			public override bool MoveNext()
			{
				//IL_017a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0184: Expected O, but got Unknown
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_0135: Unknown result type (might be due to invalid IL or missing references)
				//IL_013a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_0162: Expected O, but got Unknown
				//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Expected O, but got Unknown
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bf: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (Object.op_Implicit((Object)(object)_0024self__00242577.player))
					{
						if (MenuScript.multiplayer > 0)
						{
							if (MenuScript.multiplayer == 1)
							{
								_0024self__00242577.time = Random.Range(8, 11);
								_0024self__00242577.curVector = _0024self__00242577.player.transform.position - _0024self__00242577.t.position;
								_0024self__00242577.attacking = true;
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(_0024self__00242577.time)) ? 1 : 0);
							}
							else
							{
								result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(_0024self__00242577.time)) ? 1 : 0);
							}
						}
						else
						{
							_0024self__00242577.time = Random.Range(8, 11);
							_0024self__00242577.curVector = _0024self__00242577.player.transform.position - _0024self__00242577.t.position;
							_0024self__00242577.attacking = true;
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(_0024self__00242577.time)) ? 1 : 0);
						}
						break;
					}
					goto case 3;
				case 2:
					_0024self__00242577.attacking = false;
					goto case 3;
				case 4:
					_0024self__00242577.attacking = false;
					goto case 3;
				case 3:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal WormScript _0024self__00242578;

		public _0024Attack_00242576(WormScript self_)
		{
			_0024self__00242578 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00242578);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TD_00242579 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242580;

			internal int _0024dmg_00242581;

			internal WormScript _0024self__00242582;

			public _0024(int dmg, WormScript self_)
			{
				_0024dmg_00242581 = dmg;
				_0024self__00242582 = self_;
			}

			public override bool MoveNext()
			{
				//IL_014f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Expected O, but got Unknown
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Expected O, but got Unknown
				//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Expected O, but got Unknown
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_0122: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00242582.takingDamage)
					{
						if (MenuScript.multiplayer <= 0)
						{
							_0024self__00242582.takingDamage = true;
							_0024self__00242582.HP -= _0024dmg_00242581;
							_0024n2_00242580 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242582.t.position, Quaternion.identity);
							_0024n2_00242580.SendMessage("SD", (object)_0024dmg_00242581);
							result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
							break;
						}
						((Component)_0024self__00242582).networkView.RPC("TDN", (RPCMode)6, new object[1] { _0024dmg_00242581 });
						((Component)_0024self__00242582).networkView.RPC("TDN2", (RPCMode)2, new object[1] { _0024dmg_00242581 });
					}
					goto IL_016a;
				case 2:
					if (_0024self__00242582.HP < 1)
					{
						_0024self__00242582.Die();
						goto IL_016a;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242582.takingDamage = false;
					goto IL_016a;
				case 1:
					{
						result = 0;
						break;
					}
					IL_016a:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242583;

		internal WormScript _0024self__00242584;

		public _0024TD_00242579(int dmg, WormScript self_)
		{
			_0024dmg_00242583 = dmg;
			_0024self__00242584 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242583, _0024self__00242584);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN_00242585 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024dmg_00242586;

			internal WormScript _0024self__00242587;

			public _0024(int dmg, WormScript self_)
			{
				_0024dmg_00242586 = dmg;
				_0024self__00242587 = self_;
			}

			public override bool MoveNext()
			{
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242587.takingDamage = true;
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242587.HP -= _0024dmg_00242586;
					if (_0024self__00242587.HP < 1)
					{
						_0024self__00242587.Die();
					}
					else
					{
						_0024self__00242587.takingDamage = false;
					}
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242588;

		internal WormScript _0024self__00242589;

		public _0024TDN_00242585(int dmg, WormScript self_)
		{
			_0024dmg_00242588 = dmg;
			_0024self__00242589 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242588, _0024self__00242589);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024TDN2_00242590 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024n2_00242591;

			internal int _0024dmg_00242592;

			internal WormScript _0024self__00242593;

			public _0024(int dmg, WormScript self_)
			{
				_0024dmg_00242592 = dmg;
				_0024self__00242593 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Expected O, but got Unknown
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_005d: Expected O, but got Unknown
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Expected O, but got Unknown
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Expected O, but got Unknown
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024n2_00242591 = (GameObject)Object.Instantiate((Object)(GameObject)Resources.Load("TD", typeof(GameObject)), _0024self__00242593.t.position, Quaternion.identity);
					_0024n2_00242591.SendMessage("SD", (object)_0024dmg_00242592);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					if (_0024self__00242593.HP < 1)
					{
						goto IL_00dc;
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(4, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242593.takingDamage = false;
					goto IL_00dc;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00dc:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024dmg_00242594;

		internal WormScript _0024self__00242595;

		public _0024TDN2_00242590(int dmg, WormScript self_)
		{
			_0024dmg_00242594 = dmg;
			_0024self__00242595 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024dmg_00242594, _0024self__00242595);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024K_00242596 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00242597;

			internal int _0024_0024981_00242598;

			internal Vector3 _0024_0024982_00242599;

			internal int _0024_0024983_00242600;

			internal Vector3 _0024_0024984_00242601;

			internal int _0024_0024985_00242602;

			internal Vector3 _0024_0024986_00242603;

			internal int _0024_0024987_00242604;

			internal Vector3 _0024_0024988_00242605;

			internal bool _0024l_00242606;

			internal WormScript _0024self__00242607;

			public _0024(bool l, WormScript self_)
			{
				_0024l_00242606 = l;
				_0024self__00242607 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0247: Unknown result type (might be due to invalid IL or missing references)
				//IL_0251: Expected O, but got Unknown
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Unknown result type (might be due to invalid IL or missing references)
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_0195: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_021f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0224: Unknown result type (might be due to invalid IL or missing references)
				//IL_0225: Unknown result type (might be due to invalid IL or missing references)
				//IL_022c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0231: Unknown result type (might be due to invalid IL or missing references)
				//IL_023b: Expected O, but got Unknown
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0121: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Unknown result type (might be due to invalid IL or missing references)
				//IL_015f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00242607).networkView.RPC("KN", (RPCMode)2, new object[1] { _0024l_00242606 });
						goto IL_027e;
					}
					_0024self__00242607.knocking = true;
					_0024wasK_00242597 = default(bool);
					if (((Component)_0024self__00242607).rigidbody.isKinematic)
					{
						_0024wasK_00242597 = true;
						((Component)_0024self__00242607).rigidbody.isKinematic = false;
					}
					if (_0024l_00242606)
					{
						int num = (_0024_0024981_00242598 = -15);
						Vector3 val = (_0024_0024982_00242599 = ((Component)_0024self__00242607).rigidbody.velocity);
						float num2 = (_0024_0024982_00242599.x = _0024_0024981_00242598);
						Vector3 val3 = (((Component)_0024self__00242607).rigidbody.velocity = _0024_0024982_00242599);
						int num3 = (_0024_0024983_00242600 = 10);
						Vector3 val4 = (_0024_0024984_00242601 = ((Component)_0024self__00242607).rigidbody.velocity);
						float num4 = (_0024_0024984_00242601.y = _0024_0024983_00242600);
						Vector3 val6 = (((Component)_0024self__00242607).rigidbody.velocity = _0024_0024984_00242601);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024985_00242602 = 15);
						Vector3 val7 = (_0024_0024986_00242603 = ((Component)_0024self__00242607).rigidbody.velocity);
						float num6 = (_0024_0024986_00242603.x = _0024_0024985_00242602);
						Vector3 val9 = (((Component)_0024self__00242607).rigidbody.velocity = _0024_0024986_00242603);
						int num7 = (_0024_0024987_00242604 = 10);
						Vector3 val10 = (_0024_0024988_00242605 = ((Component)_0024self__00242607).rigidbody.velocity);
						float num8 = (_0024_0024988_00242605.y = _0024_0024987_00242604);
						Vector3 val12 = (((Component)_0024self__00242607).rigidbody.velocity = _0024_0024988_00242605);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242607.knocking = false;
					if (_0024wasK_00242597)
					{
						((Component)_0024self__00242607).rigidbody.isKinematic = true;
					}
					goto IL_027e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_027e:
					((GenericGeneratorEnumerator<YieldInstruction>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00242608;

		internal WormScript _0024self__00242609;

		public _0024K_00242596(bool l, WormScript self_)
		{
			_0024l_00242608 = l;
			_0024self__00242609 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00242608, _0024self__00242609);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024KN_00242610 : GenericGenerator<YieldInstruction>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			internal bool _0024wasK_00242611;

			internal int _0024_0024989_00242612;

			internal Vector3 _0024_0024990_00242613;

			internal int _0024_0024991_00242614;

			internal Vector3 _0024_0024992_00242615;

			internal int _0024_0024993_00242616;

			internal Vector3 _0024_0024994_00242617;

			internal int _0024_0024995_00242618;

			internal Vector3 _0024_0024996_00242619;

			internal bool _0024l_00242620;

			internal WormScript _0024self__00242621;

			public _0024(bool l, WormScript self_)
			{
				_0024l_00242620 = l;
				_0024self__00242621 = self_;
			}

			public override bool MoveNext()
			{
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0217: Expected O, but got Unknown
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				//IL_015b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0194: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01be: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0201: Expected O, but got Unknown
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_0113: Unknown result type (might be due to invalid IL or missing references)
				//IL_0118: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Unknown result type (might be due to invalid IL or missing references)
				//IL_012f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00242621.knocking = true;
					_0024wasK_00242611 = default(bool);
					if (((Component)_0024self__00242621).rigidbody.isKinematic)
					{
						_0024wasK_00242611 = true;
						((Component)_0024self__00242621).rigidbody.isKinematic = false;
					}
					if (_0024l_00242620)
					{
						int num = (_0024_0024989_00242612 = -15);
						Vector3 val = (_0024_0024990_00242613 = ((Component)_0024self__00242621).rigidbody.velocity);
						float num2 = (_0024_0024990_00242613.x = _0024_0024989_00242612);
						Vector3 val3 = (((Component)_0024self__00242621).rigidbody.velocity = _0024_0024990_00242613);
						int num3 = (_0024_0024991_00242614 = 10);
						Vector3 val4 = (_0024_0024992_00242615 = ((Component)_0024self__00242621).rigidbody.velocity);
						float num4 = (_0024_0024992_00242615.y = _0024_0024991_00242614);
						Vector3 val6 = (((Component)_0024self__00242621).rigidbody.velocity = _0024_0024992_00242615);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(2, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					else
					{
						int num5 = (_0024_0024993_00242616 = 15);
						Vector3 val7 = (_0024_0024994_00242617 = ((Component)_0024self__00242621).rigidbody.velocity);
						float num6 = (_0024_0024994_00242617.x = _0024_0024993_00242616);
						Vector3 val9 = (((Component)_0024self__00242621).rigidbody.velocity = _0024_0024994_00242617);
						int num7 = (_0024_0024995_00242618 = 10);
						Vector3 val10 = (_0024_0024996_00242619 = ((Component)_0024self__00242621).rigidbody.velocity);
						float num8 = (_0024_0024996_00242619.y = _0024_0024995_00242618);
						Vector3 val12 = (((Component)_0024self__00242621).rigidbody.velocity = _0024_0024996_00242619);
						result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(3, (YieldInstruction)new WaitForEndOfFrame()) ? 1 : 0);
					}
					break;
				case 2:
				case 3:
					result = (((GenericGeneratorEnumerator<YieldInstruction>)this).Yield(4, (YieldInstruction)new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00242621.knocking = false;
					if (_0024wasK_00242611)
					{
						((Component)_0024self__00242621).rigidbody.isKinematic = true;
					}
					((GenericGeneratorEnumerator<YieldInstruction>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal bool _0024l_00242622;

		internal WormScript _0024self__00242623;

		public _0024KN_00242610(bool l, WormScript self_)
		{
			_0024l_00242622 = l;
			_0024self__00242623 = self_;
		}

		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return (IEnumerator<YieldInstruction>)(object)new _0024(_0024l_00242622, _0024self__00242623);
		}
	}

	public bool isBase;

	public bool isHead;

	public GameObject head;

	public float speed;

	public float space;

	public float time;

	public GameObject mainHead;

	public Material leadHead;

	public GameObject[] parts;

	public GameObject[] parts2;

	private bool knocking;

	private Transform t;

	private bool moving;

	private GameObject player;

	private Vector3 curVector;

	private bool attacking;

	private Vector3 a;

	private Vector3 b;

	private int HP;

	private int maxHP;

	private int GOLD;

	public int[] drops;

	private bool takingDamage;

	public WormScript()
	{
		parts = (GameObject[])(object)new GameObject[5];
		parts2 = (GameObject[])(object)new GameObject[7];
		maxHP = 1;
		GOLD = 20;
		drops = new int[3];
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00242569(this).GetEnumerator();
	}

	public override void SetPlayer(GameObject g)
	{
		player = g;
		int num = default(int);
		if (!isBase)
		{
			return;
		}
		for (num = 0; num < parts2.Length; num++)
		{
			if (Object.op_Implicit((Object)(object)parts2[num]))
			{
				parts2[num].SendMessage("SetPlayer", (object)g);
			}
		}
		((MonoBehaviour)this).StartCoroutine_Auto(Attack());
	}

	[RPC]
	public override void SetHead()
	{
		mainHead.renderer.material = leadHead;
		mainHead.animation.Play("wHead");
	}

	public override IEnumerator Initialize()
	{
		return new _0024Initialize_00242573(this).GetEnumerator();
	}

	public override IEnumerator Attack()
	{
		return new _0024Attack_00242576(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)head))
		{
			if (MenuScript.multiplayer > 0)
			{
				head = ((Component)this).gameObject;
				isHead = true;
				((MonoBehaviour)this).StartCoroutine_Auto(Initialize());
			}
			else
			{
				head = ((Component)this).gameObject;
				isHead = true;
				((MonoBehaviour)this).StartCoroutine_Auto(Initialize());
			}
		}
		if (isHead)
		{
			if (!Object.op_Implicit((Object)(object)player) || !attacking)
			{
				return;
			}
			if (MenuScript.multiplayer > 0)
			{
				if (MenuScript.multiplayer == 1)
				{
					t.Translate(((Vector3)(ref curVector)).normalized * speed * Time.deltaTime);
				}
			}
			else
			{
				t.Translate(((Vector3)(ref curVector)).normalized * speed * Time.deltaTime);
			}
		}
		else if (MenuScript.multiplayer > 0)
		{
			if (MenuScript.multiplayer == 1)
			{
				if (!(Mathf.Abs(head.transform.position.x - t.position.x) <= space))
				{
					t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
				}
				if (!(Mathf.Abs(head.transform.position.y - t.position.y) <= space))
				{
					t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
				}
			}
		}
		else
		{
			if (!(Mathf.Abs(head.transform.position.x - t.position.x) <= space))
			{
				t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
			}
			if (!(Mathf.Abs(head.transform.position.y - t.position.y) <= space))
			{
				t.position = Vector3.Lerp(t.position, head.transform.position, speed * Time.deltaTime);
			}
		}
	}

	public override IEnumerator TD(int dmg)
	{
		return new _0024TD_00242579(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN(int dmg)
	{
		return new _0024TDN_00242585(dmg, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator TDN2(int dmg)
	{
		return new _0024TDN2_00242590(dmg, this).GetEnumerator();
	}

	public override void Die()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		GameObject val = null;
		int num = default(int);
		Item item = null;
		if (MenuScript.multiplayer > 0)
		{
			for (num = 0; num < GOLD; num++)
			{
				Network.Instantiate(Resources.Load("c"), t.position, Quaternion.identity, 0);
			}
		}
		else
		{
			for (num = 0; num < GOLD; num++)
			{
				Object.Instantiate(Resources.Load("c"), t.position, Quaternion.identity);
			}
		}
		if (drops[0] > 0 && Random.Range(0, 2) == 0)
		{
			int num2 = Random.Range(1, 3);
			item = new Item(drops[0], 1, new int[6], 0f, null);
			for (num = 0; num < num2; num++)
			{
				if (MenuScript.multiplayer > 0)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
					val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
					val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
					val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
				}
				else
				{
					val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
					val.SendMessage("Set", (object)item);
				}
			}
		}
		if (drops[1] > 0 && Random.Range(0, 4) == 0)
		{
			int num3 = Random.Range(1, 3);
			item = new Item(drops[1], 1, new int[6], 0f, null);
			for (num = 0; num < num3; num++)
			{
				if (MenuScript.multiplayer > 0)
				{
					val = (GameObject)Network.Instantiate(Resources.Load("item"), t.position, Quaternion.identity, 0);
					val.networkView.RPC("SetID", (RPCMode)6, new object[1] { item.id });
					val.networkView.RPC("SetD", (RPCMode)6, new object[1] { item.d });
					val.networkView.RPC("SetE", (RPCMode)6, new object[1] { item.e });
				}
				else
				{
					val = (GameObject)Object.Instantiate(Resources.Load("item"), t.position, Quaternion.identity);
					val.SendMessage("Set", (object)item);
				}
			}
		}
		if (MenuScript.multiplayer == 0)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (Network.isServer)
		{
			Network.RemoveRPCs(((Component)this).networkView.viewID);
			Network.Destroy(((Component)this).networkView.viewID);
		}
	}

	public override void OnTriggerEnter(Collider c)
	{
		if (((Component)c).gameObject.layer == 8)
		{
			((Component)c).SendMessage("TD", (object)18);
		}
	}

	public override IEnumerator K(bool l)
	{
		return new _0024K_00242596(l, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator KN(bool l)
	{
		return new _0024KN_00242610(l, this).GetEnumerator();
	}

	public override void Main()
	{
	}
}
