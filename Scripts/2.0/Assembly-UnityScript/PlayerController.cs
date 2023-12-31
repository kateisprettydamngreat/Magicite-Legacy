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
	internal sealed class _0024Start_00242162 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242163;

			public _0024(PlayerController self_)
			{
				_0024self__00242163 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
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
							h = MenuScript.pVariant;
						}
					}
					else
					{
						h = MenuScript.pVariant;
					}
					race = MenuScript.pRace;
					_0024self__00242163.UpdateAppearance();
					goto IL_0092;
				case 2:
					_0024self__00242163.gameScript.DecreaseHunger();
					goto IL_0092;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0092:
					result = (Yield(2, new WaitForSeconds(60f)) ? 1 : 0);
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242164;

		public _0024Start_00242162(PlayerController self_)
		{
			_0024self__00242164 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242164);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Leavee_00242165 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242166;

			public _0024(PlayerController self_)
			{
				_0024self__00242166 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242166.fade.fadeOut();
					GameScript.curBiome = GameScript.door[GameScript.curDoor];
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
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
					_0024self__00242166.gameScript.SaveInventory();
					Application.LoadLevel(0);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242167;

		public _0024Leavee_00242165(PlayerController self_)
		{
			_0024self__00242167 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242167);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Offledge_00242168 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242169;

			public _0024(PlayerController self_)
			{
				_0024self__00242169 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!_0024self__00242169.offledge)
					{
						_0024self__00242169.offledge = true;
						result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
						break;
					}
					goto IL_00e7;
				case 2:
					if (Physics.Raycast(_0024self__00242169.ray, out _0024self__00242169.hit, 1.5f))
					{
						if (_0024self__00242169.hit.transform.gameObject.layer == 11)
						{
							_0024self__00242169.grounded = true;
							mode = 0;
							_0024self__00242169.canDoubleJump = true;
						}
						else
						{
							mode = 2;
							_0024self__00242169.grounded = false;
						}
					}
					else
					{
						mode = 2;
						_0024self__00242169.grounded = false;
					}
					_0024self__00242169.offledge = false;
					goto IL_00e7;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00e7:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242170;

		public _0024Offledge_00242168(PlayerController self_)
		{
			_0024self__00242170 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242170);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Dash_00242171 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024759_00242172;

			internal Vector3 _0024_0024760_00242173;

			internal int _0024_0024761_00242174;

			internal Vector3 _0024_0024762_00242175;

			internal int _0024_0024763_00242176;

			internal Vector3 _0024_0024764_00242177;

			internal int _0024_0024765_00242178;

			internal Vector3 _0024_0024766_00242179;

			internal int _0024a_00242180;

			internal PlayerController _0024self__00242181;

			public _0024(int a, PlayerController self_)
			{
				_0024a_00242180 = a;
				_0024self__00242181 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!(_0024self__00242181.gameScript.stamina < 1f))
					{
						_0024self__00242181.GetComponent<AudioSource>().PlayOneShot(_0024self__00242181.audioDash);
						_0024self__00242181.dashing = true;
						_0024self__00242181.gameScript.Stamina();
						_0024self__00242181.gameScript.stamina = _0024self__00242181.gameScript.stamina - 1f;
						_0024self__00242181.gameScript.LoadSTA();
						_0024self__00242181.GetComponent<NetworkView>().RPC("po", RPCMode.All, _0024self__00242181.t.position);
						if (_0024self__00242181.grounded)
						{
							if (_0024a_00242180 != 0)
							{
								int num = (_0024_0024761_00242174 = 18);
								Vector3 vector = (_0024_0024762_00242175 = _0024self__00242181.r.velocity);
								float num2 = (_0024_0024762_00242175.x = _0024_0024761_00242174);
								Vector3 vector3 = (_0024self__00242181.r.velocity = _0024_0024762_00242175);
							}
							else
							{
								int num3 = (_0024_0024759_00242172 = -18);
								Vector3 vector4 = (_0024_0024760_00242173 = _0024self__00242181.r.velocity);
								float num4 = (_0024_0024760_00242173.x = _0024_0024759_00242172);
								Vector3 vector6 = (_0024self__00242181.r.velocity = _0024_0024760_00242173);
							}
						}
						else if (_0024a_00242180 != 0)
						{
							int num5 = (_0024_0024765_00242178 = 15);
							Vector3 vector7 = (_0024_0024766_00242179 = _0024self__00242181.r.velocity);
							float num6 = (_0024_0024766_00242179.x = _0024_0024765_00242178);
							Vector3 vector9 = (_0024self__00242181.r.velocity = _0024_0024766_00242179);
						}
						else
						{
							int num7 = (_0024_0024763_00242176 = -15);
							Vector3 vector10 = (_0024_0024764_00242177 = _0024self__00242181.r.velocity);
							float num8 = (_0024_0024764_00242177.x = _0024_0024763_00242176);
							Vector3 vector12 = (_0024self__00242181.r.velocity = _0024_0024764_00242177);
						}
						result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					UnityEngine.Object.Instantiate(Resources.Load("noSta"), _0024self__00242181.t.position, Quaternion.identity);
					goto IL_02bd;
				case 2:
					_0024self__00242181.dashing = false;
					goto IL_02bd;
				case 1:
					{
						result = 0;
						break;
					}
					IL_02bd:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242182;

		internal PlayerController _0024self__00242183;

		public _0024Dash_00242171(int a, PlayerController self_)
		{
			_0024a_00242182 = a;
			_0024self__00242183 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00242182, _0024self__00242183);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ShieldN_00242184 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242185;

			public _0024(PlayerController self_)
			{
				_0024self__00242185 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242185.GetComponent<NetworkView>().isMine)
					{
						_0024self__00242185.shieldObj.SetActive(value: true);
						result = (Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
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
						_0024self__00242185.shieldObj.SetActive(value: false);
					}
					goto IL_0089;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0089:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242186;

		public _0024ShieldN_00242184(PlayerController self_)
		{
			_0024self__00242186 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242186);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FloatN_00242187 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242188;

			public _0024(PlayerController self_)
			{
				_0024self__00242188 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242188.GetComponent<NetworkView>().isMine)
					{
						_0024self__00242188.particleFloat.SetActive(value: true);
						result = (Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
						break;
					}
					goto IL_00be;
				case 2:
					_0024self__00242188.floatCounter--;
					if (_0024self__00242188.floatCounter < 0)
					{
						_0024self__00242188.floatCounter = 0;
					}
					if (_0024self__00242188.floatCounter == 0)
					{
						_0024self__00242188.particleFloat.SetActive(value: false);
						_0024self__00242188.GetComponent<Rigidbody>().useGravity = true;
						GameScript.isFloating = false;
					}
					goto IL_00be;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00be:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242189;

		public _0024FloatN_00242187(PlayerController self_)
		{
			_0024self__00242189 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242189);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ChargeN_00242190 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerController _0024self__00242191;

			public _0024(PlayerController self_)
			{
				_0024self__00242191 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242191.GetComponent<NetworkView>().isMine)
					{
						_0024self__00242191.particleCharge.SetActive(value: true);
						result = (Yield(2, new WaitForSeconds(10f)) ? 1 : 0);
						break;
					}
					goto IL_00a7;
				case 2:
					_0024self__00242191.chargeBoost -= 4;
					if (_0024self__00242191.chargeBoost < 0)
					{
						_0024self__00242191.chargeBoost = 0;
					}
					if (_0024self__00242191.chargeBoost == 0)
					{
						_0024self__00242191.particleCharge.SetActive(value: false);
					}
					goto IL_00a7;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00a7:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242192;

		public _0024ChargeN_00242190(PlayerController self_)
		{
			_0024self__00242192 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242192);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024mWeaponsN_00242193 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024a_00242194;

			internal PlayerController _0024self__00242195;

			public _0024(int a, PlayerController self_)
			{
				_0024a_00242194 = a;
				_0024self__00242195 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00242195.GetComponent<NetworkView>().isMine)
					{
						_0024self__00242195.mWeapon.SetActive(value: true);
						result = (Yield(2, new WaitForSeconds(20f)) ? 1 : 0);
						break;
					}
					goto IL_008e;
				case 2:
					mBonus -= _0024a_00242194;
					if (mBonus < 0)
					{
						mBonus = 0;
					}
					if (mBonus == 0)
					{
						_0024self__00242195.mWeapon.SetActive(value: false);
					}
					goto IL_008e;
				case 1:
					{
						result = 0;
						break;
					}
					IL_008e:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024a_00242196;

		internal PlayerController _0024self__00242197;

		public _0024mWeaponsN_00242193(int a, PlayerController self_)
		{
			_0024a_00242196 = a;
			_0024self__00242197 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024a_00242196, _0024self__00242197);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Jump_00242198 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024769_00242199;

			internal Vector3 _0024_0024770_00242200;

			internal int _0024_0024771_00242201;

			internal Vector3 _0024_0024772_00242202;

			internal PlayerController _0024self__00242203;

			public _0024(PlayerController self_)
			{
				_0024self__00242203 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00242203.djA = true;
					_0024self__00242203.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/JUMP", typeof(AudioClip)));
					_0024self__00242203.canBoost = true;
					_0024self__00242203.grounded = false;
					mode = 2;
					if (!GameScript.isFloating)
					{
						int num = (_0024_0024771_00242201 = 24);
						Vector3 vector = (_0024_0024772_00242202 = _0024self__00242203.r.velocity);
						float num2 = (_0024_0024772_00242202.y = _0024_0024771_00242201);
						Vector3 vector3 = (_0024self__00242203.r.velocity = _0024_0024772_00242202);
					}
					else
					{
						int num3 = (_0024_0024769_00242199 = 12);
						Vector3 vector4 = (_0024_0024770_00242200 = _0024self__00242203.r.velocity);
						float num4 = (_0024_0024770_00242200.y = _0024_0024769_00242199);
						Vector3 vector6 = (_0024self__00242203.r.velocity = _0024_0024770_00242200);
					}
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00242203.canBoost = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242204;

		public _0024Jump_00242198(PlayerController self_)
		{
			_0024self__00242204 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242204);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DoubleJump_00242205 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024773_00242206;

			internal Vector3 _0024_0024774_00242207;

			internal int _0024_0024775_00242208;

			internal Vector3 _0024_0024776_00242209;

			internal PlayerController _0024self__00242210;

			public _0024(PlayerController self_)
			{
				_0024self__00242210 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!(_0024self__00242210.gameScript.stamina < 1f))
					{
						_0024self__00242210.djA = false;
						_0024self__00242210.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/JUMP2", typeof(AudioClip)));
						_0024self__00242210.canBoost = false;
						_0024self__00242210.canBoost2 = true;
						_0024self__00242210.gameScript.Stamina();
						_0024self__00242210.gameScript.stamina = _0024self__00242210.gameScript.stamina - 1f;
						_0024self__00242210.gameScript.LoadSTA();
						_0024self__00242210.GetComponent<NetworkView>().RPC("po", RPCMode.All, _0024self__00242210.t.position);
						_0024self__00242210.canDoubleJump = false;
						if (!GameScript.isFloating)
						{
							int num = (_0024_0024775_00242208 = 26);
							Vector3 vector = (_0024_0024776_00242209 = _0024self__00242210.r.velocity);
							float num2 = (_0024_0024776_00242209.y = _0024_0024775_00242208);
							Vector3 vector3 = (_0024self__00242210.r.velocity = _0024_0024776_00242209);
						}
						else
						{
							int num3 = (_0024_0024773_00242206 = 12);
							Vector3 vector4 = (_0024_0024774_00242207 = _0024self__00242210.r.velocity);
							float num4 = (_0024_0024774_00242207.y = _0024_0024773_00242206);
							Vector3 vector6 = (_0024self__00242210.r.velocity = _0024_0024774_00242207);
						}
						mode = 2;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					UnityEngine.Object.Instantiate(Resources.Load("noSta"), _0024self__00242210.t.position, Quaternion.identity);
					goto IL_0210;
				case 2:
					_0024self__00242210.canBoost2 = false;
					goto IL_0210;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0210:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerController _0024self__00242211;

		public _0024DoubleJump_00242205(PlayerController self_)
		{
			_0024self__00242211 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00242211);
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
		txtName = new TextMesh[2];
		mask = 2048;
		m = 2048;
		rays = new Ray[4];
		gravity = 10f;
	}

	[RPC]
	public virtual void Boss()
	{
		isBoss = true;
	}

	public virtual void Awake()
	{
		isBoss = false;
		PlayerTriggerScript.isDead = false;
		fade = (FadeInOut)Camera.main.gameObject.GetComponent("FadeInOut");
		aCube = attackCube;
		lUp = levelUpObj;
		t = transform;
		r = GetComponent<Rigidbody>();
		gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
		trigger = (PlayerTriggerScript)transform.Find("p").GetComponent("PlayerTriggerScript");
		GetComponent<Collider>().material.dynamicFriction = 0f;
		GameScript.facingLeft = true;
		@base.GetComponent<Animation>()["i"].layer = 1;
		@base.GetComponent<Animation>()["i"].speed = 2f;
		@base.GetComponent<Animation>()["r"].layer = 1;
		@base.GetComponent<Animation>()["a1"].layer = 2;
		@base.GetComponent<Animation>()["a2"].layer = 2;
		@base.GetComponent<Animation>()["a3"].layer = 2;
		@base.GetComponent<Animation>()["j"].layer = 1;
		@base.GetComponent<Animation>()["dj"].layer = 1;
		@base.GetComponent<Animation>()["a2"].speed = 1.5f;
		@base.GetComponent<Animation>()["a3"].speed = 2f;
		@base.GetComponent<Animation>()["a4"].layer = 2;
		@base.GetComponent<Animation>()["dead"].layer = 1;
		@base.GetComponent<Animation>()["a4"].speed = 2f;
	}

	public virtual void Clair(int a)
	{
		if (a == 1)
		{
			particleClair.SetActive(value: true);
		}
		else
		{
			particleClair.SetActive(value: false);
		}
	}

	public virtual void Rage(int a)
	{
		if (a == 1)
		{
			particleRage.SetActive(value: true);
		}
		else
		{
			particleRage.SetActive(value: false);
		}
	}

	public virtual IEnumerator Start()
	{
		return new _0024Start_00242162(this).GetEnumerator();
	}

	public virtual void Update()
	{
		r1U.origin = transform.position;
		float y = r1U.origin.y + 0.6f;
		Vector3 origin = r1U.origin;
		float num = (origin.y = y);
		Vector3 vector2 = (r1U.origin = origin);
		r1U.direction = Vector3.left;
		r2U.origin = transform.position;
		float y2 = r2U.origin.y + 0.6f;
		Vector3 origin2 = r2U.origin;
		float num2 = (origin2.y = y2);
		Vector3 vector4 = (r2U.origin = origin2);
		r2U.direction = Vector3.right;
		r1D.origin = transform.position;
		float y3 = r1D.origin.y - 0.7f;
		Vector3 origin3 = r1D.origin;
		float num3 = (origin3.y = y3);
		Vector3 vector6 = (r1D.origin = origin3);
		r1D.direction = Vector3.left;
		r2D.origin = transform.position;
		float y4 = r2D.origin.y - 0.7f;
		Vector3 origin4 = r2D.origin;
		float num4 = (origin4.y = y4);
		Vector3 vector8 = (r2D.origin = origin4);
		r2D.direction = Vector3.right;
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
			Vector3 vector10 = (r.velocity = velocity);
		}
		if (!GameScript.takingDamage)
		{
			if (!(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x <= t.position.x + 0.1f))
			{
				if (GameScript.facingLeft)
				{
					GameScript.facingLeft = false;
					p.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
				}
			}
			else if (!(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition).x >= t.position.x - 0.1f) && !GameScript.facingLeft)
			{
				GameScript.facingLeft = true;
				p.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			}
			ray = new Ray(t.position, new Vector3(0f, -1f, 0f));
			if (Physics.Raycast(ray, out hit, 1.5f))
			{
				if (hit.transform.gameObject.layer == 11)
				{
					grounded = true;
					mode = 0;
					canDoubleJump = true;
				}
				else
				{
					mode = 2;
					StartCoroutine_Auto(Offledge());
				}
			}
			else
			{
				mode = 2;
				StartCoroutine_Auto(Offledge());
			}
			if (UnityEngine.Input.GetKey(KeyCode.A) && !cantLeft && !dashing)
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
				Vector3 vector12 = (r.velocity = velocity2);
			}
			if (UnityEngine.Input.GetKeyDown(KeyCode.Q))
			{
				mode = 2;
				MonoBehaviour.print("asdddf");
				StartCoroutine_Auto(Dash(0));
			}
			else if (UnityEngine.Input.GetKeyDown(KeyCode.E))
			{
				mode = 2;
				StartCoroutine_Auto(Dash(1));
			}
			if (UnityEngine.Input.GetKey(KeyCode.D) && !cantRight && !dashing)
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
				Vector3 vector14 = (r.velocity = velocity3);
			}
			if (UnityEngine.Input.GetKeyDown(KeyCode.S) && GameScript.isFloating)
			{
				int num9 = -10;
				Vector3 velocity4 = r.velocity;
				float num10 = (velocity4.y = num9);
				Vector3 vector16 = (r.velocity = velocity4);
			}
			if (UnityEngine.Input.GetKeyDown(KeyCode.W) && GameScript.isFloating)
			{
				int num11 = 10;
				Vector3 velocity5 = r.velocity;
				float num12 = (velocity5.y = num11);
				Vector3 vector18 = (r.velocity = velocity5);
			}
			if (UnityEngine.Input.GetKeyUp(KeyCode.A))
			{
				if (grounded)
				{
					mode = 0;
				}
				int num13 = 0;
				Vector3 velocity6 = r.velocity;
				float num14 = (velocity6.x = num13);
				Vector3 vector20 = (r.velocity = velocity6);
			}
			else if (UnityEngine.Input.GetKeyUp(KeyCode.D))
			{
				if (grounded)
				{
					mode = 0;
				}
				int num15 = 0;
				Vector3 velocity7 = r.velocity;
				float num16 = (velocity7.x = num15);
				Vector3 vector22 = (r.velocity = velocity7);
			}
			if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
			{
				if (grounded)
				{
					StartCoroutine_Auto(Jump());
				}
				else if (canDoubleJump)
				{
					StartCoroutine_Auto(DoubleJump());
				}
			}
			if (UnityEngine.Input.GetKey(KeyCode.Space) && !dashing)
			{
				if (canBoost)
				{
					float y5 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity8 = r.velocity;
					float num17 = (velocity8.y = y5);
					Vector3 vector24 = (r.velocity = velocity8);
				}
				else if (canBoost2)
				{
					float y6 = r.velocity.y + 32f * Time.deltaTime;
					Vector3 velocity9 = r.velocity;
					float num18 = (velocity9.y = y6);
					Vector3 vector26 = (r.velocity = velocity9);
				}
			}
			if (UnityEngine.Input.GetKeyDown(KeyCode.W))
			{
				if (trigger.canLeave)
				{
					StartCoroutine_Auto(Leavee());
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
			MonoBehaviour.print("ISDEADD");
			mode = 99;
		}
		if (mode == 0)
		{
			@base.GetComponent<Animation>().Play("i");
			jA = false;
		}
		else if (mode == 1)
		{
			@base.GetComponent<Animation>().Play("r");
			jA = false;
		}
		else if (mode == 2)
		{
			if (!jA)
			{
				@base.GetComponent<Animation>().Play("j");
				jA = true;
			}
			if (!djA)
			{
				@base.GetComponent<Animation>().Play("dj");
				djA = true;
			}
		}
		else if (mode == 3)
		{
			@base.GetComponent<Animation>().Play("a1");
			jA = false;
		}
		else if (mode == 99)
		{
			@base.GetComponent<Animation>().Play("dead");
		}
		else
		{
			jA = false;
		}
		if (dashing)
		{
			@base.GetComponent<Animation>().Play("j");
		}
	}

	public virtual IEnumerator Leavee()
	{
		return new _0024Leavee_00242165(this).GetEnumerator();
	}

	public virtual IEnumerator Offledge()
	{
		return new _0024Offledge_00242168(this).GetEnumerator();
	}

	public virtual IEnumerator Dash(int a)
	{
		return new _0024Dash_00242171(a, this).GetEnumerator();
	}

	[RPC]
	public virtual IEnumerator ShieldN()
	{
		return new _0024ShieldN_00242184(this).GetEnumerator();
	}

	public virtual void Shield()
	{
		PlayerTriggerScript.ShieldDEF += 4;
		GetComponent<NetworkView>().RPC("ShieldN", RPCMode.All);
	}

	[RPC]
	public virtual IEnumerator FloatN()
	{
		return new _0024FloatN_00242187(this).GetEnumerator();
	}

	public virtual void Float()
	{
		floatCounter++;
		GetComponent<Rigidbody>().useGravity = false;
		int num = 10;
		Vector3 velocity = GetComponent<Rigidbody>().velocity;
		float num2 = (velocity.y = num);
		Vector3 vector2 = (GetComponent<Rigidbody>().velocity = velocity);
		GameScript.isFloating = true;
		GetComponent<NetworkView>().RPC("FloatN", RPCMode.All);
	}

	public virtual void Roar(int a)
	{
		if (a == 1)
		{
			particleRoar.SetActive(value: true);
		}
		else
		{
			particleRoar.SetActive(value: false);
		}
	}

	[RPC]
	public virtual IEnumerator ChargeN()
	{
		return new _0024ChargeN_00242190(this).GetEnumerator();
	}

	public virtual void Charge()
	{
		chargeBoost += 4;
		GetComponent<NetworkView>().RPC("ChargeN", RPCMode.All);
	}

	[RPC]
	public virtual IEnumerator mWeaponsN(int a)
	{
		return new _0024mWeaponsN_00242193(a, this).GetEnumerator();
	}

	public virtual void mWeapons(int a)
	{
		mBonus += a;
		GetComponent<NetworkView>().RPC("mWeaponsN", RPCMode.All, a);
	}

	public virtual IEnumerator Jump()
	{
		return new _0024Jump_00242198(this).GetEnumerator();
	}

	public virtual IEnumerator DoubleJump()
	{
		return new _0024DoubleJump_00242205(this).GetEnumerator();
	}

	public virtual void UpdateHead(int hh)
	{
		h = hh;
		UpdateAppearance();
	}

	public virtual void UpdateBody(int bb)
	{
		b = bb;
		UpdateAppearance();
	}

	public virtual void UpdateOffhand(int oo)
	{
		o = oo;
		UpdateAppearance();
	}

	public virtual void OnLevelWasLoaded(int level)
	{
		gameScript = (GameScript)GameObject.Find("GameManager").GetComponent("GameScript");
		GameScript.cLevel = PlayerPrefs.GetInt("cLevel");
		GameObject gameObject = null;
	}

	public virtual void TD(int dmg)
	{
		if (!PlayerTriggerScript.cantTakeDamage)
		{
			StartCoroutine_Auto(trigger.TD(dmg));
		}
	}

	public virtual void Initialize()
	{
	}

	public virtual void UpdateAppearance()
	{
		head.GetComponent<Renderer>().material = (Material)Resources.Load("r/r" + race, typeof(Material));
		if (helm == 0)
		{
			head2.GetComponent<Renderer>().material = (Material)Resources.Load("h/h" + (h + (MenuScript.pColor - 1) * 14), typeof(Material));
		}
		else
		{
			head2.GetComponent<Renderer>().material = (Material)Resources.Load("h/h" + h, typeof(Material));
		}
		body.GetComponent<Renderer>().material = (Material)Resources.Load("b/b" + b, typeof(Material));
		arm1.GetComponent<Renderer>().material = (Material)Resources.Load("a/a" + b, typeof(Material));
		arm2.GetComponent<Renderer>().material = (Material)Resources.Load("a/a" + b, typeof(Material));
		leg.GetComponent<Renderer>().material = (Material)Resources.Load("l/l" + b, typeof(Material));
		offHand.GetComponent<Renderer>().material = (Material)Resources.Load("o/o" + o, typeof(Material));
	}

	[RPC]
	public virtual void po(Vector3 pos)
	{
		UnityEngine.Object.Instantiate(pop, pos, Quaternion.Euler(0f, 180f, 180f));
	}

	public virtual void K(bool a)
	{
	}

	public virtual void TDp()
	{
		float num = (float)GameScript.MAXHP * 0.2f;
		int dMG = (int)num;
		if (!PlayerTriggerScript.cantTakeDamage)
		{
			StartCoroutine_Auto(trigger.TD(dMG));
		}
	}

	public virtual void Main()
	{
	}
}
