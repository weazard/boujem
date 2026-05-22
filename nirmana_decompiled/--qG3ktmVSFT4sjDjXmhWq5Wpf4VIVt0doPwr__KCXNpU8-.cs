using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public static class _0023_003DqG3ktmVSFT4sjDjXmhWq5Wpf4VIVt0doPwr__KCXNpU8_003D
{
	private sealed class _0023_003Dq9C_0024LOZtihyvhh0whJ61SMw_003D_003D<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D> : IEnumerator<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D>, IEnumerable<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D>, IEnumerable, IEnumerator, IDisposable
	{
		private int _0023_003Dq6oezmn2hAYMGrltax7cfDA_003D_003D;

		private _0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D _0023_003DqfqhvuhA1ypejHU8bF4_0024YvA_003D_003D;

		private int _0023_003DqqkG_0024KuKBJI4aKvWYLbJOYa0_R8SZ2dhIzFhd1guJG_Y_003D;

		private IEnumerable<Maybe<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D>> _0023_003Dq2v41SAQQpyaV1usMYY4F4w_003D_003D;

		public IEnumerable<Maybe<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D>> _0023_003Dqp1HL6C0w_lewmopYH_0024YgpQ_003D_003D;

		private IEnumerator<Maybe<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D>> _0023_003DqwCEnMGnmKf5PYKVatDTTPw_003D_003D;

		[DebuggerHidden]
		public _0023_003Dq9C_0024LOZtihyvhh0whJ61SMw_003D_003D(int _0023_003Dqua1WXzEG6DzCXS0Ob766EQ_003D_003D)
		{
			_0023_003Dq6oezmn2hAYMGrltax7cfDA_003D_003D = _0023_003Dqua1WXzEG6DzCXS0Ob766EQ_003D_003D;
			_0023_003DqqkG_0024KuKBJI4aKvWYLbJOYa0_R8SZ2dhIzFhd1guJG_Y_003D = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void _0023_003Dqo_0024VtRAwnQ6pIV0p72XdXltMWejKcYxjuoF847AJnlIc_003D()
		{
			int num = _0023_003Dq6oezmn2hAYMGrltax7cfDA_003D_003D;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_0023_003DqBy_crn9GysEfcbEjyisbHw_003D_003D();
				}
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qo$VtRAwnQ6pIV0p72XdXltMWejKcYxjuoF847AJnlIc=
			this._0023_003Dqo_0024VtRAwnQ6pIV0p72XdXltMWejKcYxjuoF847AJnlIc_003D();
		}

		private bool MoveNext()
		{
			try
			{
				switch (_0023_003Dq6oezmn2hAYMGrltax7cfDA_003D_003D)
				{
				default:
					return false;
				case 0:
					_0023_003Dq6oezmn2hAYMGrltax7cfDA_003D_003D = -1;
					_0023_003DqwCEnMGnmKf5PYKVatDTTPw_003D_003D = _0023_003Dq2v41SAQQpyaV1usMYY4F4w_003D_003D.GetEnumerator();
					_0023_003Dq6oezmn2hAYMGrltax7cfDA_003D_003D = -3;
					break;
				case 1:
					_0023_003Dq6oezmn2hAYMGrltax7cfDA_003D_003D = -3;
					break;
				}
				while (_0023_003DqwCEnMGnmKf5PYKVatDTTPw_003D_003D.MoveNext())
				{
					Maybe<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D> current = _0023_003DqwCEnMGnmKf5PYKVatDTTPw_003D_003D.Current;
					if (current._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
					{
						_0023_003DqfqhvuhA1ypejHU8bF4_0024YvA_003D_003D = current._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D();
						_0023_003Dq6oezmn2hAYMGrltax7cfDA_003D_003D = 1;
						return true;
					}
				}
				_0023_003DqBy_crn9GysEfcbEjyisbHw_003D_003D();
				_0023_003DqwCEnMGnmKf5PYKVatDTTPw_003D_003D = null;
				return false;
			}
			catch
			{
				//try-fault
				_0023_003Dqo_0024VtRAwnQ6pIV0p72XdXltMWejKcYxjuoF847AJnlIc_003D();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _0023_003DqBy_crn9GysEfcbEjyisbHw_003D_003D()
		{
			_0023_003Dq6oezmn2hAYMGrltax7cfDA_003D_003D = -1;
			if (_0023_003DqwCEnMGnmKf5PYKVatDTTPw_003D_003D != null)
			{
				_0023_003DqwCEnMGnmKf5PYKVatDTTPw_003D_003D.Dispose();
			}
		}

		[DebuggerHidden]
		private _0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D _0023_003Dqzi_0024KYFmFJ_xvWPG0yQwx45bGRzTTGmBPfh4b0CtfK6_43rIFrVUSTB4IghJ50jJsw1OwPFf_VxOWSDsGtAdvLw_003D_003D()
		{
			return _0023_003DqfqhvuhA1ypejHU8bF4_0024YvA_003D_003D;
		}

		_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D IEnumerator<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qzi$KYFmFJ_xvWPG0yQwx45bGRzTTGmBPfh4b0CtfK6_43rIFrVUSTB4IghJ50jJsw1OwPFf_VxOWSDsGtAdvLw==
			return this._0023_003Dqzi_0024KYFmFJ_xvWPG0yQwx45bGRzTTGmBPfh4b0CtfK6_43rIFrVUSTB4IghJ50jJsw1OwPFf_VxOWSDsGtAdvLw_003D_003D();
		}

		[DebuggerHidden]
		private void _0023_003DqJ7XNmXDrJDR_Kv818k8c2aNf5QM2xCjnBZzSZZXKRtkHJVxQ0MtDUlrJQermj8_0024x()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qJ7XNmXDrJDR_Kv818k8c2aNf5QM2xCjnBZzSZZXKRtkHJVxQ0MtDUlrJQermj8$x
			this._0023_003DqJ7XNmXDrJDR_Kv818k8c2aNf5QM2xCjnBZzSZZXKRtkHJVxQ0MtDUlrJQermj8_0024x();
		}

		[DebuggerHidden]
		private object _0023_003DqKdg3GqwcWJKMB5BxeoWNLKfmp_4e5I_rLATTw4j9Qh9QWuuZmu64hRwGpb_0024q7R5i()
		{
			return _0023_003DqfqhvuhA1ypejHU8bF4_0024YvA_003D_003D;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qKdg3GqwcWJKMB5BxeoWNLKfmp_4e5I_rLATTw4j9Qh9QWuuZmu64hRwGpb$q7R5i
			return this._0023_003DqKdg3GqwcWJKMB5BxeoWNLKfmp_4e5I_rLATTw4j9Qh9QWuuZmu64hRwGpb_0024q7R5i();
		}

		[DebuggerHidden]
		private IEnumerator<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D> _0023_003Dq3tVevp4c0peSF_00246LvqardYTvwuWjrn7a8JCpqQ4gdMFT5_NS6gkvPRU0NIkUeiQ9ffeocGFuwPd2tvhLBSV99w_003D_003D()
		{
			_0023_003Dq9C_0024LOZtihyvhh0whJ61SMw_003D_003D<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D> _0023_003Dq9C_0024LOZtihyvhh0whJ61SMw_003D_003D2;
			if (_0023_003Dq6oezmn2hAYMGrltax7cfDA_003D_003D == -2 && _0023_003DqqkG_0024KuKBJI4aKvWYLbJOYa0_R8SZ2dhIzFhd1guJG_Y_003D == Environment.CurrentManagedThreadId)
			{
				_0023_003Dq6oezmn2hAYMGrltax7cfDA_003D_003D = 0;
				_0023_003Dq9C_0024LOZtihyvhh0whJ61SMw_003D_003D2 = this;
			}
			else
			{
				_0023_003Dq9C_0024LOZtihyvhh0whJ61SMw_003D_003D2 = new _0023_003Dq9C_0024LOZtihyvhh0whJ61SMw_003D_003D<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D>(0);
			}
			_0023_003Dq9C_0024LOZtihyvhh0whJ61SMw_003D_003D2._0023_003Dq2v41SAQQpyaV1usMYY4F4w_003D_003D = _0023_003Dqp1HL6C0w_lewmopYH_0024YgpQ_003D_003D;
			return _0023_003Dq9C_0024LOZtihyvhh0whJ61SMw_003D_003D2;
		}

		IEnumerator<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D> IEnumerable<_0023_003DqdP4YFd6e76Go0ph_0024yRmNCw_003D_003D>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=q3tVevp4c0peSF$6LvqardYTvwuWjrn7a8JCpqQ4gdMFT5_NS6gkvPRU0NIkUeiQ9ffeocGFuwPd2tvhLBSV99w==
			return this._0023_003Dq3tVevp4c0peSF_00246LvqardYTvwuWjrn7a8JCpqQ4gdMFT5_NS6gkvPRU0NIkUeiQ9ffeocGFuwPd2tvhLBSV99w_003D_003D();
		}

		[DebuggerHidden]
		private IEnumerator _0023_003DqS2_SopkUrVuK2CNeWeen7UyyLVOlNMuxIpU_0024IIbR5JAyMQZOeT6Y0hvFnKr6vJM_0024()
		{
			return _0023_003Dq3tVevp4c0peSF_00246LvqardYTvwuWjrn7a8JCpqQ4gdMFT5_NS6gkvPRU0NIkUeiQ9ffeocGFuwPd2tvhLBSV99w_003D_003D();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qS2_SopkUrVuK2CNeWeen7UyyLVOlNMuxIpU$IIbR5JAyMQZOeT6Y0hvFnKr6vJM$
			return this._0023_003DqS2_SopkUrVuK2CNeWeen7UyyLVOlNMuxIpU_0024IIbR5JAyMQZOeT6Y0hvFnKr6vJM_0024();
		}
	}

	private sealed class _0023_003DqQthKJ6ePOIdhZ6xt4W7MA1S9a_0024_3kOTI_x7v4ZlCPnE_003D<_0023_003Dqe1nt2oHTNJt1F5VOukAR_0024g_003D_003D, _0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D> : IEnumerator<_0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D>, IEnumerable<_0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D>, IEnumerable, IEnumerator, IDisposable
	{
		private int _0023_003DqTlKAw4oX8YoERLDgoBXLKA_003D_003D;

		private _0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D _0023_003DqVv6fjPcexDLVvvSAcySuyQ_003D_003D;

		private int _0023_003Dqw25SAow0lrJNnsJZlB0ip16mF54u_3KWjfqMcmb11sY_003D;

		private IEnumerable<_0023_003Dqe1nt2oHTNJt1F5VOukAR_0024g_003D_003D> _0023_003DqcvePTCeXKvTKvepJ2fzQcg_003D_003D;

		public IEnumerable<_0023_003Dqe1nt2oHTNJt1F5VOukAR_0024g_003D_003D> _0023_003Dq4cP6BjgQl82Eh9XRpnJphA_003D_003D;

		private Func<_0023_003Dqe1nt2oHTNJt1F5VOukAR_0024g_003D_003D, Maybe<_0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D>> _0023_003DqbVdiHyQBscbhV4wM5driVw_003D_003D;

		public Func<_0023_003Dqe1nt2oHTNJt1F5VOukAR_0024g_003D_003D, Maybe<_0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D>> _0023_003DqTWySKbTGgmVGCnBz8JtlDw_003D_003D;

		private IEnumerator<_0023_003Dqe1nt2oHTNJt1F5VOukAR_0024g_003D_003D> _0023_003DqGmmrFOioRGfC7SAWRQBVVg_003D_003D;

		[DebuggerHidden]
		public _0023_003DqQthKJ6ePOIdhZ6xt4W7MA1S9a_0024_3kOTI_x7v4ZlCPnE_003D(int _0023_003DqktzgwPF9A8KJszw3Gp9l0A_003D_003D)
		{
			_0023_003DqTlKAw4oX8YoERLDgoBXLKA_003D_003D = _0023_003DqktzgwPF9A8KJszw3Gp9l0A_003D_003D;
			_0023_003Dqw25SAow0lrJNnsJZlB0ip16mF54u_3KWjfqMcmb11sY_003D = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void _0023_003DqQVYoHWrK_X3uU8BEnjzTDEOSnBokVnzm74FoOKxLQgM_003D()
		{
			int num = _0023_003DqTlKAw4oX8YoERLDgoBXLKA_003D_003D;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_0023_003DqPE5F9RAvdb2XlG4bSaI4WQ_003D_003D();
				}
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qQVYoHWrK_X3uU8BEnjzTDEOSnBokVnzm74FoOKxLQgM=
			this._0023_003DqQVYoHWrK_X3uU8BEnjzTDEOSnBokVnzm74FoOKxLQgM_003D();
		}

		private bool MoveNext()
		{
			try
			{
				switch (_0023_003DqTlKAw4oX8YoERLDgoBXLKA_003D_003D)
				{
				default:
					return false;
				case 0:
					_0023_003DqTlKAw4oX8YoERLDgoBXLKA_003D_003D = -1;
					_0023_003DqGmmrFOioRGfC7SAWRQBVVg_003D_003D = _0023_003DqcvePTCeXKvTKvepJ2fzQcg_003D_003D.GetEnumerator();
					_0023_003DqTlKAw4oX8YoERLDgoBXLKA_003D_003D = -3;
					break;
				case 1:
					_0023_003DqTlKAw4oX8YoERLDgoBXLKA_003D_003D = -3;
					break;
				}
				while (_0023_003DqGmmrFOioRGfC7SAWRQBVVg_003D_003D.MoveNext())
				{
					_0023_003Dqe1nt2oHTNJt1F5VOukAR_0024g_003D_003D current = _0023_003DqGmmrFOioRGfC7SAWRQBVVg_003D_003D.Current;
					Maybe<_0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D> maybe = _0023_003DqbVdiHyQBscbhV4wM5driVw_003D_003D(current);
					if (maybe._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
					{
						_0023_003DqVv6fjPcexDLVvvSAcySuyQ_003D_003D = maybe._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D();
						_0023_003DqTlKAw4oX8YoERLDgoBXLKA_003D_003D = 1;
						return true;
					}
				}
				_0023_003DqPE5F9RAvdb2XlG4bSaI4WQ_003D_003D();
				_0023_003DqGmmrFOioRGfC7SAWRQBVVg_003D_003D = null;
				return false;
			}
			catch
			{
				//try-fault
				_0023_003DqQVYoHWrK_X3uU8BEnjzTDEOSnBokVnzm74FoOKxLQgM_003D();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _0023_003DqPE5F9RAvdb2XlG4bSaI4WQ_003D_003D()
		{
			_0023_003DqTlKAw4oX8YoERLDgoBXLKA_003D_003D = -1;
			if (_0023_003DqGmmrFOioRGfC7SAWRQBVVg_003D_003D != null)
			{
				_0023_003DqGmmrFOioRGfC7SAWRQBVVg_003D_003D.Dispose();
			}
		}

		[DebuggerHidden]
		private _0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D _0023_003DqTTnbT35ECLvSny0ZexocoCCezj3AbHbrljD8lRCFRduQPmtCy2ZSOW2z4YJsJOSOhaEmTsd7j_IBqmjDWONp4A_003D_003D()
		{
			return _0023_003DqVv6fjPcexDLVvvSAcySuyQ_003D_003D;
		}

		_0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D IEnumerator<_0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qTTnbT35ECLvSny0ZexocoCCezj3AbHbrljD8lRCFRduQPmtCy2ZSOW2z4YJsJOSOhaEmTsd7j_IBqmjDWONp4A==
			return this._0023_003DqTTnbT35ECLvSny0ZexocoCCezj3AbHbrljD8lRCFRduQPmtCy2ZSOW2z4YJsJOSOhaEmTsd7j_IBqmjDWONp4A_003D_003D();
		}

		[DebuggerHidden]
		private void _0023_003Dques9uiIRukNdXvXXF8fTp_HZcrbYtZaMWmBN5db1v_0024u9kDP2DJQsvor58OTyOcq4()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=ques9uiIRukNdXvXXF8fTp_HZcrbYtZaMWmBN5db1v$u9kDP2DJQsvor58OTyOcq4
			this._0023_003Dques9uiIRukNdXvXXF8fTp_HZcrbYtZaMWmBN5db1v_0024u9kDP2DJQsvor58OTyOcq4();
		}

		[DebuggerHidden]
		private object _0023_003DqSZ_mb8hO1wajINPhNwc75aaP2LoUMOj5VefZJLfnscY5u2wTsgTZYuGTbzpRL91B()
		{
			return _0023_003DqVv6fjPcexDLVvvSAcySuyQ_003D_003D;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qSZ_mb8hO1wajINPhNwc75aaP2LoUMOj5VefZJLfnscY5u2wTsgTZYuGTbzpRL91B
			return this._0023_003DqSZ_mb8hO1wajINPhNwc75aaP2LoUMOj5VefZJLfnscY5u2wTsgTZYuGTbzpRL91B();
		}

		[DebuggerHidden]
		private IEnumerator<_0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D> _0023_003Dq3tVevp4c0peSF_00246LvqardYTvwuWjrn7a8JCpqQ4gdMFexjtObf_0024MSNtHFKYvIV_Vg8CaeoscU4nHU_00243Vpb_0024X_0024w_003D_003D()
		{
			_0023_003DqQthKJ6ePOIdhZ6xt4W7MA1S9a_0024_3kOTI_x7v4ZlCPnE_003D<_0023_003Dqe1nt2oHTNJt1F5VOukAR_0024g_003D_003D, _0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D> _0023_003DqQthKJ6ePOIdhZ6xt4W7MA1S9a_0024_3kOTI_x7v4ZlCPnE_003D2;
			if (_0023_003DqTlKAw4oX8YoERLDgoBXLKA_003D_003D == -2 && _0023_003Dqw25SAow0lrJNnsJZlB0ip16mF54u_3KWjfqMcmb11sY_003D == Environment.CurrentManagedThreadId)
			{
				_0023_003DqTlKAw4oX8YoERLDgoBXLKA_003D_003D = 0;
				_0023_003DqQthKJ6ePOIdhZ6xt4W7MA1S9a_0024_3kOTI_x7v4ZlCPnE_003D2 = this;
			}
			else
			{
				_0023_003DqQthKJ6ePOIdhZ6xt4W7MA1S9a_0024_3kOTI_x7v4ZlCPnE_003D2 = new _0023_003DqQthKJ6ePOIdhZ6xt4W7MA1S9a_0024_3kOTI_x7v4ZlCPnE_003D<_0023_003Dqe1nt2oHTNJt1F5VOukAR_0024g_003D_003D, _0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D>(0);
			}
			_0023_003DqQthKJ6ePOIdhZ6xt4W7MA1S9a_0024_3kOTI_x7v4ZlCPnE_003D2._0023_003DqcvePTCeXKvTKvepJ2fzQcg_003D_003D = _0023_003Dq4cP6BjgQl82Eh9XRpnJphA_003D_003D;
			_0023_003DqQthKJ6ePOIdhZ6xt4W7MA1S9a_0024_3kOTI_x7v4ZlCPnE_003D2._0023_003DqbVdiHyQBscbhV4wM5driVw_003D_003D = _0023_003DqTWySKbTGgmVGCnBz8JtlDw_003D_003D;
			return _0023_003DqQthKJ6ePOIdhZ6xt4W7MA1S9a_0024_3kOTI_x7v4ZlCPnE_003D2;
		}

		IEnumerator<_0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D> IEnumerable<_0023_003DqvInKVHeW5cd2a2GnRkDXfA_003D_003D>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=q3tVevp4c0peSF$6LvqardYTvwuWjrn7a8JCpqQ4gdMFexjtObf$MSNtHFKYvIV_Vg8CaeoscU4nHU$3Vpb$X$w==
			return this._0023_003Dq3tVevp4c0peSF_00246LvqardYTvwuWjrn7a8JCpqQ4gdMFexjtObf_0024MSNtHFKYvIV_Vg8CaeoscU4nHU_00243Vpb_0024X_0024w_003D_003D();
		}

		[DebuggerHidden]
		private IEnumerator _0023_003Dqt263VWNLgvzAEBuNp8Bt5R7eMQIGgZStfmxRW0MK2tXIGL7uvwAf0ilGTF2_WD4U()
		{
			return _0023_003Dq3tVevp4c0peSF_00246LvqardYTvwuWjrn7a8JCpqQ4gdMFexjtObf_0024MSNtHFKYvIV_Vg8CaeoscU4nHU_00243Vpb_0024X_0024w_003D_003D();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qt263VWNLgvzAEBuNp8Bt5R7eMQIGgZStfmxRW0MK2tXIGL7uvwAf0ilGTF2_WD4U
			return this._0023_003Dqt263VWNLgvzAEBuNp8Bt5R7eMQIGgZStfmxRW0MK2tXIGL7uvwAf0ilGTF2_WD4U();
		}
	}

	public static Maybe<V> _0023_003Dqfjn_0024ooPv9m98_0024N4BBnAapQ_003D_003D<K, V>(this IDictionary<K, V> _0023_003DqrEy2QQPm4w3u_Mj6zsajdg_003D_003D, K _0023_003DqU7NaS4yo22cfkL39t87x4Q_003D_003D)
	{
		if (_0023_003DqrEy2QQPm4w3u_Mj6zsajdg_003D_003D.TryGetValue(_0023_003DqU7NaS4yo22cfkL39t87x4Q_003D_003D, out var value))
		{
			return value;
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	public static Maybe<T> _0023_003DqTs78paxwX3FqU5vsbfhrAQ_003D_003D<T>(this IList<T> _0023_003DqUxQpUAHzRMZv9Y6wKyIDLQ_003D_003D, int _0023_003DqzkDuCpvKq_0024sE2LmixP36Kg_003D_003D)
	{
		if (_0023_003DqzkDuCpvKq_0024sE2LmixP36Kg_003D_003D >= 0 && _0023_003DqzkDuCpvKq_0024sE2LmixP36Kg_003D_003D < _0023_003DqUxQpUAHzRMZv9Y6wKyIDLQ_003D_003D.Count)
		{
			return _0023_003DqUxQpUAHzRMZv9Y6wKyIDLQ_003D_003D[_0023_003DqzkDuCpvKq_0024sE2LmixP36Kg_003D_003D];
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	[IteratorStateMachine(typeof(_0023_003Dq9C_0024LOZtihyvhh0whJ61SMw_003D_003D))]
	public static IEnumerable<T> _0023_003Dq5hHyuktzBrdfA9QtxRiIuQ_003D_003D<T>(this IEnumerable<Maybe<T>> _0023_003DqHcKqauRZeQw1iyiZCPEswg_003D_003D)
	{
		return new _0023_003Dq9C_0024LOZtihyvhh0whJ61SMw_003D_003D<T>(-2)
		{
			_0023_003Dqp1HL6C0w_lewmopYH_0024YgpQ_003D_003D = _0023_003DqHcKqauRZeQw1iyiZCPEswg_003D_003D
		};
	}

	[IteratorStateMachine(typeof(_0023_003DqQthKJ6ePOIdhZ6xt4W7MA1S9a_0024_3kOTI_x7v4ZlCPnE_003D))]
	public static IEnumerable<R> _0023_003DqFuoHSS7a46SbL1gdd7wwIw_003D_003D<T, R>(this IEnumerable<T> _0023_003DqweAJqg3Pqt10AMCQ_0024qSCWQ_003D_003D, Func<T, Maybe<R>> _0023_003DqqZQ00woK5Ys0Ln0OLMhdaQ_003D_003D)
	{
		return new _0023_003DqQthKJ6ePOIdhZ6xt4W7MA1S9a_0024_3kOTI_x7v4ZlCPnE_003D<T, R>(-2)
		{
			_0023_003Dq4cP6BjgQl82Eh9XRpnJphA_003D_003D = _0023_003DqweAJqg3Pqt10AMCQ_0024qSCWQ_003D_003D,
			_0023_003DqTWySKbTGgmVGCnBz8JtlDw_003D_003D = _0023_003DqqZQ00woK5Ys0Ln0OLMhdaQ_003D_003D
		};
	}
}
