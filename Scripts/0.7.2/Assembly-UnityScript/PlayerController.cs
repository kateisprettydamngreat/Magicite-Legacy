using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class PlayerController : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_00241831 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00241832;

			public _0024(PlayerController self_)
			{
				_0024self__00241832 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (armor > 0)
					{
						b = armor;
					}
					else
					{
						b = MenuScript.pBody;
					}
					if (h != 0)
					{
						if (helm > 0)
						{
							h = helm;
						}
						else
						{
							h = MenuScript.pHead;
						}
					}
					else
					{
						h = MenuScript.pHead;
					}
					race = MenuScript.pRace;
					_0024self__00241832.UpdateAppearance();
					goto IL_0092;
				case 2:
					_0024self__00241832.gameScript.DecreaseHunger();
					goto IL_0092;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0092:
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(60f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00241833;

		public _0024Start_00241831(PlayerController self_)
		{
			_0024self__00241833 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241833);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Leavee_00241834 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00241835;

			public _0024(PlayerController self_)
			{
				_0024self__00241835 = self_;
			}

			public override bool MoveNext()
			{
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241835.fade.fadeOut();
					GameScript.curBiome = GameScript.door[GameScript.curDoor];
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					if (GameScript.isTown)
					{
						GameScript.isTown = false;
					}
					else if (GameScript.districtLevel == 21)
					{
						GameScript.isTown = false;
					}
					else
					{
						GameScript.isTown = true;
					}
					_0024self__00241835.gameScript.SaveInventory();
					Application.LoadLevel(1);
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00241836;

		public _0024Leavee_00241834(PlayerController self_)
		{
			_0024self__00241836 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241836);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Offledge_00241837 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00241838;

			public _0024(PlayerController self_)
			{
				_0024self__00241838 = self_;
			}

			public override bool MoveNext()
			{
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!_0024self__00241838.offledge)
					{
						_0024self__00241838.offledge = true;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
						break;
					}
					goto IL_00e7;
				case 2:
					if (Physics.Raycast(_0024self__00241838.ray, ref _0024self__00241838.hit, 1.5f))
					{
						if (((Component)((RaycastHit)(ref _0024self__00241838.hit)).transform).gameObject.layer == 11)
						{
							_0024self__00241838.grounded = true;
							mode = 0;
							_0024self__00241838.canDoubleJump = true;
						}
						else
						{
							mode = 2;
							_0024self__00241838.grounded = false;
						}
					}
					else
					{
						mode = 2;
						_0024self__00241838.grounded = false;
					}
					_0024self__00241838.offledge = false;
					goto IL_00e7;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00e7:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00241839;

		public _0024Offledge_00241837(PlayerController self_)
		{
			_0024self__00241839 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241839);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Dash_00241840 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024700_00241841;

			internal Vector3 _0024_0024701_00241842;

			internal int _0024_0024702_00241843;

			internal Vector3 _0024_0024703_00241844;

			internal int _0024_0024704_00241845;

			internal Vector3 _0024_0024705_00241846;

			internal int _0024_0024706_00241847;

			internal Vector3 _0024_0024707_00241848;

			internal int _0024a_00241849;

			internal PlayerController _0024self__00241850;

			public _0024(int a, PlayerController self_)
			{
				_0024a_00241849 = a;
				_0024self__00241850 = self_;
			}

			public override bool MoveNext()
			{
				//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0258: Unknown result type (might be due to invalid IL or missing references)
				//IL_025d: Unknown result type (might be due to invalid IL or missing references)
				//IL_025e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0260: Unknown result type (might be due to invalid IL or missing references)
				//IL_0265: Unknown result type (might be due to invalid IL or missing references)
				//IL_028c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0291: Unknown result type (might be due to invalid IL or missing references)
				//IL_0292: Unknown result type (might be due to invalid IL or missing references)
				//IL_0299: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0202: Unknown result type (might be due to invalid IL or missing references)
				//IL_0229: Unknown result type (might be due to invalid IL or missing references)
				//IL_022e: Unknown result type (might be due to invalid IL or missing references)
				//IL_022f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0236: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_018f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0194: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_012a: Unknown result type (might be due to invalid IL or missing references)
				//IL_012f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_0136: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Unknown result type (might be due to invalid IL or missing references)
				//IL_015f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0166: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ad: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!(_0024self__00241850.gameScript.stamina < 1f))
					{
						((Component)_0024self__00241850).audio.PlayOneShot(_0024self__00241850.audioDash);
						_0024self__00241850.dashing = true;
						_0024self__00241850.gameScript.Stamina();
						_0024self__00241850.gameScript.stamina = _0024self__00241850.gameScript.stamina - 1f;
						_0024self__00241850.gameScript.LoadSTA();
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00241850).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00241850.t.position });
						}
						else
						{
							_0024self__00241850.po(_0024self__00241850.t.position);
						}
						if (_0024self__00241850.grounded)
						{
							if (_0024a_00241849 != 0)
							{
								int num = (_0024_0024702_00241843 = 18);
								Vector3 val = (_0024_0024703_00241844 = _0024self__00241850.r.velocity);
								float num2 = (_0024_0024703_00241844.x = _0024_0024702_00241843);
								Vector3 val3 = (_0024self__00241850.r.velocity = _0024_0024703_00241844);
							}
							else
							{
								int num3 = (_0024_0024700_00241841 = -18);
								Vector3 val4 = (_0024_0024701_00241842 = _0024self__00241850.r.velocity);
								float num4 = (_0024_0024701_00241842.x = _0024_0024700_00241841);
								Vector3 val6 = (_0024self__00241850.r.velocity = _0024_0024701_00241842);
							}
						}
						else if (_0024a_00241849 != 0)
						{
							int num5 = (_0024_0024706_00241847 = 15);
							Vector3 val7 = (_0024_0024707_00241848 = _0024self__00241850.r.velocity);
							float num6 = (_0024_0024707_00241848.x = _0024_0024706_00241847);
							Vector3 val9 = (_0024self__00241850.r.velocity = _0024_0024707_00241848);
						}
						else
						{
							int num7 = (_0024_0024704_00241845 = -15);
							Vector3 val10 = (_0024_0024705_00241846 = _0024self__00241850.r.velocity);
							float num8 = (_0024_0024705_00241846.x = _0024_0024704_00241845);
							Vector3 val12 = (_0024self__00241850.r.velocity = _0024_0024705_00241846);
						}
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00241850.t.position, Quaternion.identity);
					goto IL_02e8;
				case 2:
					_0024self__00241850.dashing = false;
					goto IL_02e8;
				case 1:
					{
						result = 0;
						break;
					}
					IL_02e8:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241851;

		internal PlayerController _0024self__00241852;

		public _0024Dash_00241840(int a, PlayerController self_)
		{
			_0024a_00241851 = a;
			_0024self__00241852 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241851, _0024self__00241852);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShieldN_00241853 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00241854;

			public _0024(PlayerController self_)
			{
				_0024self__00241854 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00241854).networkView.isMine)
					{
						_0024self__00241854.shieldObj.SetActive(true);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
						break;
					}
					goto IL_0089;
				case 2:
					PlayerTriggerScript.ShieldDEF -= 4;
					if (PlayerTriggerScript.ShieldDEF < 0)
					{
						PlayerTriggerScript.ShieldDEF = 0;
					}
					if (PlayerTriggerScript.ShieldDEF == 0)
					{
						_0024self__00241854.shieldObj.SetActive(false);
					}
					goto IL_0089;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0089:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00241855;

		public _0024ShieldN_00241853(PlayerController self_)
		{
			_0024self__00241855 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241855);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Shield_00241856 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00241857;

			public _0024(PlayerController self_)
			{
				_0024self__00241857 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					PlayerTriggerScript.ShieldDEF += 4;
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00241857).networkView.RPC("ShieldN", (RPCMode)2, new object[0]);
						goto IL_00ac;
					}
					_0024self__00241857.shieldObj.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
					break;
				case 2:
					PlayerTriggerScript.ShieldDEF -= 4;
					if (PlayerTriggerScript.ShieldDEF < 0)
					{
						PlayerTriggerScript.ShieldDEF = 0;
					}
					if (PlayerTriggerScript.ShieldDEF == 0)
					{
						_0024self__00241857.shieldObj.SetActive(false);
					}
					goto IL_00ac;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00ac:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00241858;

		public _0024Shield_00241856(PlayerController self_)
		{
			_0024self__00241858 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241858);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FloatN_00241859 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00241860;

			public _0024(PlayerController self_)
			{
				_0024self__00241860 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00241860).networkView.isMine)
					{
						_0024self__00241860.particleFloat.SetActive(true);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
						break;
					}
					goto IL_00be;
				case 2:
					_0024self__00241860.floatCounter--;
					if (_0024self__00241860.floatCounter < 0)
					{
						_0024self__00241860.floatCounter = 0;
					}
					if (_0024self__00241860.floatCounter == 0)
					{
						_0024self__00241860.particleFloat.SetActive(false);
						((Component)_0024self__00241860).rigidbody.useGravity = true;
						GameScript.isFloating = false;
					}
					goto IL_00be;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00be:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00241861;

		public _0024FloatN_00241859(PlayerController self_)
		{
			_0024self__00241861 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241861);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Float_00241862 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024708_00241863;

			internal Vector3 _0024_0024709_00241864;

			internal PlayerController _0024self__00241865;

			public _0024(PlayerController self_)
			{
				_0024self__00241865 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_005d: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_00de: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
				{
					_0024self__00241865.floatCounter++;
					((Component)_0024self__00241865).rigidbody.useGravity = false;
					int num = (_0024_0024708_00241863 = 10);
					Vector3 val = (_0024_0024709_00241864 = ((Component)_0024self__00241865).rigidbody.velocity);
					float num2 = (_0024_0024709_00241864.y = _0024_0024708_00241863);
					Vector3 val3 = (((Component)_0024self__00241865).rigidbody.velocity = _0024_0024709_00241864);
					GameScript.isFloating = true;
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00241865).networkView.RPC("FloatN", (RPCMode)2, new object[0]);
						goto IL_015a;
					}
					_0024self__00241865.particleFloat.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				}
				case 2:
					_0024self__00241865.floatCounter--;
					if (_0024self__00241865.floatCounter < 0)
					{
						_0024self__00241865.floatCounter = 0;
					}
					if (_0024self__00241865.floatCounter == 0)
					{
						_0024self__00241865.particleFloat.SetActive(false);
						((Component)_0024self__00241865).rigidbody.useGravity = true;
						GameScript.isFloating = false;
					}
					goto IL_015a;
				case 1:
					{
						result = 0;
						break;
					}
					IL_015a:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00241866;

		public _0024Float_00241862(PlayerController self_)
		{
			_0024self__00241866 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241866);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeN_00241867 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00241868;

			public _0024(PlayerController self_)
			{
				_0024self__00241868 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00241868).networkView.isMine)
					{
						_0024self__00241868.particleCharge.SetActive(true);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
						break;
					}
					goto IL_00a7;
				case 2:
					_0024self__00241868.chargeBoost -= 4;
					if (_0024self__00241868.chargeBoost < 0)
					{
						_0024self__00241868.chargeBoost = 0;
					}
					if (_0024self__00241868.chargeBoost == 0)
					{
						_0024self__00241868.particleCharge.SetActive(false);
					}
					goto IL_00a7;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00a7:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00241869;

		public _0024ChargeN_00241867(PlayerController self_)
		{
			_0024self__00241869 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241869);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Charge_00241870 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00241871;

			public _0024(PlayerController self_)
			{
				_0024self__00241871 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241871.chargeBoost += 4;
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00241871).networkView.RPC("ChargeN", (RPCMode)2, new object[0]);
						goto IL_00d6;
					}
					_0024self__00241871.particleCharge.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241871.chargeBoost -= 4;
					if (_0024self__00241871.chargeBoost < 0)
					{
						_0024self__00241871.chargeBoost = 0;
					}
					if (_0024self__00241871.chargeBoost == 0)
					{
						_0024self__00241871.particleCharge.SetActive(false);
					}
					goto IL_00d6;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00d6:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00241872;

		public _0024Charge_00241870(PlayerController self_)
		{
			_0024self__00241872 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241872);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024mWeaponsN_00241873 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241874;

			internal PlayerController _0024self__00241875;

			public _0024(int a, PlayerController self_)
			{
				_0024a_00241874 = a;
				_0024self__00241875 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (((Component)_0024self__00241875).networkView.isMine)
					{
						_0024self__00241875.mWeapon.SetActive(true);
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
						break;
					}
					goto IL_008e;
				case 2:
					mBonus -= _0024a_00241874;
					if (mBonus < 0)
					{
						mBonus = 0;
					}
					if (mBonus == 0)
					{
						_0024self__00241875.mWeapon.SetActive(false);
					}
					goto IL_008e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_008e:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241876;

		internal PlayerController _0024self__00241877;

		public _0024mWeaponsN_00241873(int a, PlayerController self_)
		{
			_0024a_00241876 = a;
			_0024self__00241877 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241876, _0024self__00241877);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024mWeapons_00241878 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00241879;

			internal PlayerController _0024self__00241880;

			public _0024(int a, PlayerController self_)
			{
				_0024a_00241879 = a;
				_0024self__00241880 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					mBonus += _0024a_00241879;
					if (MenuScript.multiplayer > 0)
					{
						((Component)_0024self__00241880).networkView.RPC("mWeaponsN", (RPCMode)2, new object[1] { _0024a_00241879 });
						goto IL_00c4;
					}
					_0024self__00241880.mWeapon.SetActive(true);
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
					break;
				case 2:
					mBonus -= _0024a_00241879;
					if (mBonus < 0)
					{
						mBonus = 0;
					}
					if (mBonus == 0)
					{
						_0024self__00241880.mWeapon.SetActive(false);
					}
					goto IL_00c4;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00c4:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00241881;

		internal PlayerController _0024self__00241882;

		public _0024mWeapons_00241878(int a, PlayerController self_)
		{
			_0024a_00241881 = a;
			_0024self__00241882 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024a_00241881, _0024self__00241882);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Jump_00241883 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024710_00241884;

			internal Vector3 _0024_0024711_00241885;

			internal int _0024_0024712_00241886;

			internal Vector3 _0024_0024713_00241887;

			internal PlayerController _0024self__00241888;

			public _0024(PlayerController self_)
			{
				_0024self__00241888 = self_;
			}

			public override bool MoveNext()
			{
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected O, but got Unknown
				//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_011d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0122: Unknown result type (might be due to invalid IL or missing references)
				//IL_0123: Unknown result type (might be due to invalid IL or missing references)
				//IL_012a: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					_0024self__00241888.djA = true;
					((Component)_0024self__00241888).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP", typeof(AudioClip)));
					_0024self__00241888.canBoost = true;
					_0024self__00241888.grounded = false;
					mode = 2;
					if (!GameScript.isFloating)
					{
						int num = (_0024_0024712_00241886 = 24);
						Vector3 val = (_0024_0024713_00241887 = _0024self__00241888.r.velocity);
						float num2 = (_0024_0024713_00241887.y = _0024_0024712_00241886);
						Vector3 val3 = (_0024self__00241888.r.velocity = _0024_0024713_00241887);
					}
					else
					{
						int num3 = (_0024_0024710_00241884 = 12);
						Vector3 val4 = (_0024_0024711_00241885 = _0024self__00241888.r.velocity);
						float num4 = (_0024_0024711_00241885.y = _0024_0024710_00241884);
						Vector3 val6 = (_0024self__00241888.r.velocity = _0024_0024711_00241885);
					}
					result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241888.canBoost = false;
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00241889;

		public _0024Jump_00241883(PlayerController self_)
		{
			_0024self__00241889 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241889);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DoubleJump_00241890 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024714_00241891;

			internal Vector3 _0024_0024715_00241892;

			internal int _0024_0024716_00241893;

			internal Vector3 _0024_0024717_00241894;

			internal PlayerController _0024self__00241895;

			public _0024(PlayerController self_)
			{
				_0024self__00241895 = self_;
			}

			public override bool MoveNext()
			{
				//IL_022b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Expected O, but got Unknown
				//IL_0113: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Unknown result type (might be due to invalid IL or missing references)
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_017b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0180: Unknown result type (might be due to invalid IL or missing references)
				//IL_0181: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0200: Expected O, but got Unknown
				int result;
				switch (base._state)
				{
				default:
					if (!(_0024self__00241895.gameScript.stamina < 1f))
					{
						_0024self__00241895.djA = false;
						((Component)_0024self__00241895).audio.PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
						_0024self__00241895.canBoost = false;
						_0024self__00241895.canBoost2 = true;
						_0024self__00241895.gameScript.Stamina();
						_0024self__00241895.gameScript.stamina = _0024self__00241895.gameScript.stamina - 1f;
						_0024self__00241895.gameScript.LoadSTA();
						if (MenuScript.multiplayer > 0)
						{
							((Component)_0024self__00241895).networkView.RPC("po", (RPCMode)2, new object[1] { _0024self__00241895.t.position });
						}
						else
						{
							_0024self__00241895.po(_0024self__00241895.t.position);
						}
						_0024self__00241895.canDoubleJump = false;
						if (!GameScript.isFloating)
						{
							int num = (_0024_0024716_00241893 = 26);
							Vector3 val = (_0024_0024717_00241894 = _0024self__00241895.r.velocity);
							float num2 = (_0024_0024717_00241894.y = _0024_0024716_00241893);
							Vector3 val3 = (_0024self__00241895.r.velocity = _0024_0024717_00241894);
						}
						else
						{
							int num3 = (_0024_0024714_00241891 = 12);
							Vector3 val4 = (_0024_0024715_00241892 = _0024self__00241895.r.velocity);
							float num4 = (_0024_0024715_00241892.y = _0024_0024714_00241891);
							Vector3 val6 = (_0024self__00241895.r.velocity = _0024_0024715_00241892);
						}
						mode = 2;
						result = (((GenericGeneratorEnumerator<WaitForSeconds>)this).Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					Object.Instantiate(Resources.Load("noSta"), _0024self__00241895.t.position, Quaternion.identity);
					goto IL_023b;
				case 2:
					_0024self__00241895.canBoost2 = false;
					goto IL_023b;
				case 1:
					{
						result = 0;
						break;
					}
					IL_023b:
					((GenericGeneratorEnumerator<WaitForSeconds>)this).YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00241896;

		public _0024DoubleJump_00241890(PlayerController self_)
		{
			_0024self__00241896 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self__00241896);
		}
	}

	public GameObject blood;

	public GameObject particleRoar;

	public GameObject particleFloat;

	[NonSerialized]
	public static int mBonus;

	private int floatCounter;

	public GameObject mWeapon;

	public GameObject shieldObj;

	public GameObject particleClair;

	private int chargeBoost;

	public GameObject particleCharge;

	public GameObject particleRage;

	[NonSerialized]
	public static bool isBoss;

	[NonSerialized]
	public static int mode;

	[NonSerialized]
	public static int interact;

	[NonSerialized]
	public static bool facingRight;

	[NonSerialized]
	public static GameObject aCube;

	[NonSerialized]
	public static GameObject lUp;

	[NonSerialized]
	public static int b;

	[NonSerialized]
	public static int h;

	[NonSerialized]
	public static int race;

	[NonSerialized]
	public static int o;

	[NonSerialized]
	public static int helm;

	[NonSerialized]
	public static int armor;

	[NonSerialized]
	public static int offhand;

	private bool charging;

	private bool offledge;

	public AudioClip themeCave;

	public AudioClip themeTown;

	public GameObject levelUpObj;

	public GameObject attackCube;

	public GameObject pop;

	public GameObject @base;

	public GameObject p;

	public GameObject head;

	public GameObject head2;

	public GameObject body;

	public GameObject arm1;

	public GameObject arm2;

	public GameObject leg;

	public GameObject weapon;

	public GameObject offHand;

	public TextMesh[] txtName;

	public AudioClip audioDash;

	public bool attacking;

	public bool cantMove;

	public bool running;

	private bool moving;

	private int cc;

	private bool jA;

	private bool djA;

	private GameScript gameScript;

	private bool canMove;

	private Vector3 newPos;

	private Vector3 newPos2;

	private Ray ray;

	private RaycastHit hit;

	private int mask;

	private LayerMask m;

	private bool dead;

	private PlayerTriggerScript trigger;

	private bool dashing;

	private int jumping;

	private Ray[] rays;

	private float gravity;

	private bool grounded;

	private Transform t;

	private Rigidbody r;

	private FadeInOut fade;

	private bool canDoubleJump;

	private bool canBoost;

	private bool canBoost2;

	private Ray r1U;

	private Ray r2U;

	private Ray r1D;

	private Ray r2D;

	private bool cantLeft;

	private bool cantRight;

	private int itemPurchasing;

	public PlayerController()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		txtName = (TextMesh[])(object)new TextMesh[2];
		mask = 2048;
		m = LayerMask.op_Implicit(2048);
		rays = (Ray[])(object)new Ray[4];
		gravity = 10f;
	}

	[RPC]
	public override void Boss()
	{
		isBoss = true;
	}

	public override void Awake()
	{
		isBoss = false;
		PlayerTriggerScript.isDead = false;
		fade = (FadeInOut)(object)((Component)Camera.main).gameObject.GetComponent("FadeInOut");
		aCube = attackCube;
		lUp = levelUpObj;
		t = ((Component)this).transform;
		r = ((Component)this).rigidbody;
		gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
		trigger = (PlayerTriggerScript)(object)((Component)((Component)this).transform.Find("p")).GetComponent("PlayerTriggerScript");
		((Component)this).collider.material.dynamicFriction = 0f;
		GameScript.facingLeft = true;
		@base.animation["i"].layer = 1;
		@base.animation["i"].speed = 2f;
		@base.animation["r"].layer = 1;
		@base.animation["a1"].layer = 2;
		@base.animation["a2"].layer = 2;
		@base.animation["a3"].layer = 2;
		@base.animation["j"].layer = 1;
		@base.animation["dj"].layer = 1;
		@base.animation["a2"].speed = 1.5f;
		@base.animation["a3"].speed = 2f;
		@base.animation["a4"].layer = 2;
		@base.animation["dead"].layer = 1;
		@base.animation["a4"].speed = 2f;
	}

	public override void Clair(int a)
	{
		if (a == 1)
		{
			particleClair.SetActive(true);
		}
		else
		{
			particleClair.SetActive(false);
		}
	}

	public override void Rage(int a)
	{
		if (a == 1)
		{
			particleRage.SetActive(true);
		}
		else
		{
			particleRage.SetActive(false);
		}
	}

	public override IEnumerator Start()
	{
		return new _0024Start_00241831(this).GetEnumerator();
	}

	public override void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		((Ray)(ref r1U)).origin = ((Component)this).transform.position;
		float y = ((Ray)(ref r1U)).origin.y + 0.6f;
		Vector3 origin = ((Ray)(ref r1U)).origin;
		float num = (origin.y = y);
		Vector3 val2 = (((Ray)(ref r1U)).origin = origin);
		((Ray)(ref r1U)).direction = Vector3.left;
		((Ray)(ref r2U)).origin = ((Component)this).transform.position;
		float y2 = ((Ray)(ref r2U)).origin.y + 0.6f;
		Vector3 origin2 = ((Ray)(ref r2U)).origin;
		float num2 = (origin2.y = y2);
		Vector3 val4 = (((Ray)(ref r2U)).origin = origin2);
		((Ray)(ref r2U)).direction = Vector3.right;
		((Ray)(ref r1D)).origin = ((Component)this).transform.position;
		float y3 = ((Ray)(ref r1D)).origin.y - 0.7f;
		Vector3 origin3 = ((Ray)(ref r1D)).origin;
		float num3 = (origin3.y = y3);
		Vector3 val6 = (((Ray)(ref r1D)).origin = origin3);
		((Ray)(ref r1D)).direction = Vector3.left;
		((Ray)(ref r2D)).origin = ((Component)this).transform.position;
		float y4 = ((Ray)(ref r2D)).origin.y - 0.7f;
		Vector3 origin4 = ((Ray)(ref r2D)).origin;
		float num4 = (origin4.y = y4);
		Vector3 val8 = (((Ray)(ref r2D)).origin = origin4);
		((Ray)(ref r2D)).direction = Vector3.right;
		if (Physics.Raycast(r1U, 1.2f, mask) || Physics.Raycast(r1D, 1.2f, mask))
		{
			cantLeft = true;
		}
		else
		{
			cantLeft = false;
		}
		if (Physics.Raycast(r2U, 1.2f, mask) || Physics.Raycast(r2D, 1.2f, mask))
		{
			cantRight = true;
		}
		else
		{
			cantRight = false;
		}
		if (!(r.velocity.y >= -25f))
		{
			int num5 = -25;
			Vector3 velocity = r.velocity;
			float num6 = (velocity.y = num5);
			Vector3 val10 = (r.velocity = velocity);
		}
		if (!GameScript.takingDamage)
		{
			if (!(Camera.main.ScreenToWorldPoint(Input.mousePosition).x <= t.position.x + 0.1f))
			{
				if (GameScript.facingLeft)
				{
					GameScript.facingLeft = false;
					p.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
				}
			}
			else if (!(Camera.main.ScreenToWorldPoint(Input.mousePosition).x >= t.position.x - 0.1f) && !GameScript.facingLeft)
			{
				GameScript.facingLeft = true;
				p.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			}
			ray = new Ray(t.position, new Vector3(0f, -1f, 0f));
			if (Physics.Raycast(ray, ref hit, 1.5f))
			{
				if (((Component)((RaycastHit)(ref hit)).transform).gameObject.layer == 11)
				{
					grounded = true;
					mode = 0;
					canDoubleJump = true;
				}
				else
				{
					mode = 2;
					((MonoBehaviour)this).StartCoroutine_Auto(Offledge());
				}
			}
			else
			{
				mode = 2;
				((MonoBehaviour)this).StartCoroutine_Auto(Offledge());
			}
			if (Input.GetKey((KeyCode)97) && !cantLeft && !dashing)
			{
				if (grounded)
				{
					mode = 1;
				}
				else
				{
					mode = 2;
				}
				float x = 0f - GameScript.SPD - (float)chargeBoost;
				Vector3 velocity2 = r.velocity;
				float num7 = (velocity2.x = x);
				Vector3 val12 = (r.velocity = velocity2);
			}
			if (Input.GetKeyDown((KeyCode)113))
			{
				mode = 2;
				MonoBehaviour.print((object)"asdddf");
				((MonoBehaviour)this).StartCoroutine_Auto(Dash(0));
			}
			else if (Input.GetKeyDown((KeyCode)101))
			{
				mode = 2;
				((MonoBehaviour)this).StartCoroutine_Auto(Dash(1));
			}
			if (Input.GetKey((KeyCode)100) && !cantRight && !dashing)
			{
				if (grounded)
				{
					mode = 1;
				}
				else
				{
					mode = 2;
				}
				float x2 = GameScript.SPD + (float)chargeBoost;
				Vector3 velocity3 = r.velocity;
				float num8 = (velocity3.x = x2);
				Vector3 val14 = (r.velocity = velocity3);
			}
			if (Input.GetKeyDown((KeyCode)115) && GameScript.isFloating)
			{
				int num9 = -10;
				Vector3 velocity4 = r.velocity;
				float num10 = (velocity4.y = num9);
				Vector3 val16 = (r.velocity = velocity4);
			}
			if (Input.GetKeyDown((KeyCode)119) && GameScript.isFloating)
			{
				int num11 = 10;
				Vector3 velocity5 = r.velocity;
				float num12 = (velocity5.y = num11);
				Vector3 val18 = (r.velocity = velocity5);
			}
			if (Input.GetKeyUp((KeyCode)97))
			{
				if (grounded)
				{
					mode = 0;
				}
				int num13 = 0;
				Vector3 velocity6 = r.velocity;
				float num14 = (velocity6.x = num13);
				Vector3 val20 = (r.velocity = velocity6);
			}
			else if (Input.GetKeyUp((KeyCode)100))
			{
				if (grounded)
				{
					mode = 0;
				}
				int num15 = 0;
				Vector3 velocity7 = r.velocity;
				float num16 = (velocity7.x = num15);
				Vector3 val22 = (r.velocity = velocity7);
			}
			if (Input.GetKeyDown((KeyCode)32))
			{
				if (grounded)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(Jump());
				}
				else if (canDoubleJump)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(DoubleJump());
				}
			}
			if (Input.GetKey((KeyCode)32) && !dashing)
			{
				if (canBoost)
				{
					float y5 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity8 = r.velocity;
					float num17 = (velocity8.y = y5);
					Vector3 val24 = (r.velocity = velocity8);
				}
				else if (canBoost2)
				{
					float y6 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity9 = r.velocity;
					float num18 = (velocity9.y = y6);
					Vector3 val26 = (r.velocity = velocity9);
				}
			}
			if (Input.GetKeyDown((KeyCode)119))
			{
				if (trigger.canLeave)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(Leavee());
				}
				if (GameScript.canInteract && !GameScript.interacting)
				{
					gameScript.Interact();
				}
				if (GameScript.isShopping && PlayerTriggerScript.itemPurchasing != 0)
				{
					gameScript.Purchase(PlayerTriggerScript.itemPurchasing);
				}
			}
		}
		if (GameScript.HP <= 0)
		{
			MonoBehaviour.print((object)"ISDEADD");
			mode = 99;
		}
		if (mode == 0)
		{
			@base.animation.Play("i");
			jA = false;
		}
		else if (mode == 1)
		{
			@base.animation.Play("r");
			jA = false;
		}
		else if (mode == 2)
		{
			if (!jA)
			{
				@base.animation.Play("j");
				jA = true;
			}
			if (!djA)
			{
				@base.animation.Play("dj");
				djA = true;
			}
		}
		else if (mode == 3)
		{
			@base.animation.Play("a1");
			jA = false;
		}
		else if (mode == 99)
		{
			@base.animation.Play("dead");
		}
		else
		{
			jA = false;
		}
		if (dashing)
		{
			@base.animation.Play("j");
		}
	}

	public override IEnumerator Leavee()
	{
		return new _0024Leavee_00241834(this).GetEnumerator();
	}

	public override IEnumerator Offledge()
	{
		return new _0024Offledge_00241837(this).GetEnumerator();
	}

	public override IEnumerator Dash(int a)
	{
		return new _0024Dash_00241840(a, this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator ShieldN()
	{
		return new _0024ShieldN_00241853(this).GetEnumerator();
	}

	public override IEnumerator Shield()
	{
		return new _0024Shield_00241856(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator FloatN()
	{
		return new _0024FloatN_00241859(this).GetEnumerator();
	}

	public override IEnumerator Float()
	{
		return new _0024Float_00241862(this).GetEnumerator();
	}

	public override void Roar(int a)
	{
		if (a == 1)
		{
			particleRoar.SetActive(true);
		}
		else
		{
			particleRoar.SetActive(false);
		}
	}

	[RPC]
	public override IEnumerator ChargeN()
	{
		return new _0024ChargeN_00241867(this).GetEnumerator();
	}

	public override IEnumerator Charge()
	{
		return new _0024Charge_00241870(this).GetEnumerator();
	}

	[RPC]
	public override IEnumerator mWeaponsN(int a)
	{
		return new _0024mWeaponsN_00241873(a, this).GetEnumerator();
	}

	public override IEnumerator mWeapons(int a)
	{
		return new _0024mWeapons_00241878(a, this).GetEnumerator();
	}

	public override IEnumerator Jump()
	{
		return new _0024Jump_00241883(this).GetEnumerator();
	}

	public override IEnumerator DoubleJump()
	{
		return new _0024DoubleJump_00241890(this).GetEnumerator();
	}

	public override void UpdateHead(int hh)
	{
		h = hh;
		UpdateAppearance();
	}

	public override void UpdateBody(int bb)
	{
		b = bb;
		UpdateAppearance();
	}

	public override void UpdateOffhand(int oo)
	{
		o = oo;
		UpdateAppearance();
	}

	public override void OnLevelWasLoaded(int level)
	{
		gameScript = (GameScript)(object)GameObject.Find("GameManager").GetComponent("GameScript");
		GameScript.cLevel = PlayerPrefs.GetInt("cLevel");
		GameObject val = null;
	}

	public override void TD(int dmg)
	{
		if (!PlayerTriggerScript.cantTakeDamage)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(trigger.TD(dmg));
		}
	}

	public override void Initialize()
	{
	}

	public override void UpdateAppearance()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		head.renderer.material = (Material)Resources.Load("r/r" + (object)race, typeof(Material));
		if (helm == 0)
		{
			head2.renderer.material = (Material)Resources.Load("h/h" + (object)(h + (MenuScript.pColor - 1) * 14), typeof(Material));
		}
		else
		{
			head2.renderer.material = (Material)Resources.Load("h/h" + (object)h, typeof(Material));
		}
		body.renderer.material = (Material)Resources.Load("b/b" + (object)b, typeof(Material));
		arm1.renderer.material = (Material)Resources.Load("a/a" + (object)b, typeof(Material));
		arm2.renderer.material = (Material)Resources.Load("a/a" + (object)b, typeof(Material));
		leg.renderer.material = (Material)Resources.Load("l/l" + (object)b, typeof(Material));
		offHand.renderer.material = (Material)Resources.Load("o/o" + (object)o, typeof(Material));
	}

	[RPC]
	public override void po(Vector3 pos)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate((Object)(object)pop, pos, Quaternion.Euler(0f, 180f, 180f));
	}

	public override void K(bool a)
	{
	}

	public override void TDp()
	{
		float num = (float)GameScript.MAXHP * 0.2f;
		int dMG = (int)num;
		if (!PlayerTriggerScript.cantTakeDamage)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(trigger.TD(dMG));
		}
	}

	public override void Main()
	{
	}
}
