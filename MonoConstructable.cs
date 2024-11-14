using UnityEngine;

namespace MonoConstruct
{
    internal abstract class MonoConstructable : MonoBehaviour
    {
    }
    
    public abstract class MonoConstructable<T1> : MonoConstructable
    {
        protected abstract void Init(T1 arg1);

        private void Awake()
        {
            if (!MonoConstructArgs<T1>.IsSet)
            {
                Debug.LogError($"{typeof(T1)} args are not set");
                return;
            }

            var arg = MonoConstructArgs<T1>.GetArgs();
            Init(arg);
            OnAwake();
        }

        protected virtual void OnAwake()
        {
        }
    }

    public abstract class MonoConstructable<T1, T2> : MonoConstructable
    {
        protected abstract void Init(T1 arg1, T2 arg2);

        private void Awake()
        {
            if (!MonoConstructArgs<T1, T2>.IsSet)
            {
                Debug.LogError($"{typeof(T1)} {typeof(T2)} args are not set");
                return;
            }

            var args = MonoConstructArgs<T1, T2>.GetArgs();
            Init(args.arg1, args.arg2);
            OnAwake();
        }

        protected virtual void OnAwake()
        {
        }
    }

    public abstract class MonoConstructable<T1, T2, T3> : MonoConstructable
    {
        protected abstract void Init(T1 arg1, T2 arg2, T3 arg3);

        private void Awake()
        {
            if (!MonoConstructArgs<T1, T2, T3>.IsSet)
            {
                Debug.LogError($"{typeof(T1)} {typeof(T2)} {typeof(T3)} args are not set");
                return;
            }

            var args = MonoConstructArgs<T1, T2, T3>.GetArgs();
            Init(args.arg1, args.arg2, args.arg3);
            OnAwake();
        }

        protected virtual void OnAwake()
        {
        }
    }

    public abstract class MonoConstructable<T1, T2, T3, T4> : MonoConstructable
    {
        protected abstract void Init(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

        private void Awake()
        {
            if (!MonoConstructArgs<T1, T2, T3, T4>.IsSet)
            {
                Debug.LogError($"{typeof(T1)} {typeof(T2)} {typeof(T3)} {typeof(T4)} args are not set");
                return;
            }

            var args = MonoConstructArgs<T1, T2, T3, T4>.GetArgs();
            Init(args.arg1, args.arg2, args.arg3, args.arg4);
            OnAwake();
        }

        protected virtual void OnAwake()
        {
        }
    }

    public abstract class MonoConstructable<T1, T2, T3, T4, T5> : MonoConstructable
    {
        protected abstract void Init(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

        private void Awake()
        {
            if (!MonoConstructArgs<T1, T2, T3, T4, T5>.IsSet)
            {
                Debug.LogError($"{typeof(T1)} {typeof(T2)} {typeof(T3)} {typeof(T4)} {typeof(T5)} args are not set");
                return;
            }

            var args = MonoConstructArgs<T1, T2, T3, T4, T5>.GetArgs();
            Init(args.arg1, args.arg2, args.arg3, args.arg4, args.arg5);
            OnAwake();
        }

        protected virtual void OnAwake()
        {
        }
    }
}
