using UnityEngine;

namespace MonoConstruct
{
    public static class MonoConstructor
    {
        public static MonoConstructable<T1> Instantiate<T1>(this MonoConstructable<T1> monoConstructable, T1 arg1,
            Transform transform = null)
        {
            MonoConstructArgs<T1>.SetArgs(arg1);
            var newGameObject = Object.Instantiate(monoConstructable, transform);
            return newGameObject;
        }

        public static MonoConstructable<T1, T2> Instantiate<T1, T2>(this MonoConstructable<T1, T2> monoConstructable,
            T1 arg1, T2 arg2, Transform transform = null)
        {
            MonoConstructArgs<T1, T2>.SetArgs(arg1, arg2);
            var newGameObject = Object.Instantiate(monoConstructable, transform);
            return newGameObject;
        }

        public static MonoConstructable<T1, T2, T3> Instantiate<T1, T2, T3>(
            this MonoConstructable<T1, T2, T3> monoConstructable, T1 arg1, T2 arg2, T3 arg3, Transform transform = null)
        {
            MonoConstructArgs<T1, T2, T3>.SetArgs(arg1, arg2, arg3);
            var newGameObject = Object.Instantiate(monoConstructable, transform);
            return newGameObject;
        }

        public static MonoConstructable<T1, T2, T3, T4> Instantiate<T1, T2, T3, T4>(
            this MonoConstructable<T1, T2, T3, T4> monoConstructable, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            Transform transform = null)
        {
            MonoConstructArgs<T1, T2, T3, T4>.SetArgs(arg1, arg2, arg3, arg4);
            var newGameObject = Object.Instantiate(monoConstructable, transform);
            return newGameObject;
        }

        public static MonoConstructable<T1, T2, T3, T4, T5> Instantiate<T1, T2, T3, T4, T5>(
            this MonoConstructable<T1, T2, T3, T4, T5> monoConstructable, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            Transform transform = null)
        {
            MonoConstructArgs<T1, T2, T3, T4, T5>.SetArgs(arg1, arg2, arg3, arg4, arg5);
            var newGameObject = Object.Instantiate(monoConstructable, transform);
            return newGameObject;
        }
    }
}