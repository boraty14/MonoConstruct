namespace MonoConstruct
{
    internal static class MonoConstructArgs<T1>
    {
        private static T1 _arg1;

        internal static bool IsSet { get; private set; }


        internal static void SetArgs(T1 arg1)
        {
            IsSet = true;
            _arg1 = arg1;
        }

        internal static T1 GetArgs()
        {
            IsSet = false;
            return _arg1;
        }
    }

    internal static class MonoConstructArgs<T1, T2>
    {
        private static T1 _arg1;
        private static T2 _arg2;

        internal static bool IsSet { get; private set; }


        internal static void SetArgs(T1 arg1, T2 arg2)
        {
            IsSet = true;
            _arg1 = arg1;
            _arg2 = arg2;
        }

        internal static (T1 arg1, T2 arg2) GetArgs()
        {
            IsSet = false;
            return (_arg1, _arg2);
        }
    }

    internal static class MonoConstructArgs<T1, T2, T3>
    {
        private static T1 _arg1;
        private static T2 _arg2;
        private static T3 _arg3;

        internal static bool IsSet { get; private set; }


        internal static void SetArgs(T1 arg1, T2 arg2, T3 arg3)
        {
            IsSet = true;
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
        }

        internal static (T1 arg1, T2 arg2, T3 arg3) GetArgs()
        {
            IsSet = false;
            return (_arg1, _arg2, _arg3);
        }
    }

    internal static class MonoConstructArgs<T1, T2, T3, T4>
    {
        private static T1 _arg1;
        private static T2 _arg2;
        private static T3 _arg3;
        private static T4 _arg4;
        internal static bool IsSet { get; private set; }

        internal static void SetArgs(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            IsSet = true;
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
        }

        internal static (T1 arg1, T2 arg2, T3 arg3, T4 arg4) GetArgs()
        {
            IsSet = false;
            return (_arg1, _arg2, _arg3, _arg4);
        }
    }

    internal static class MonoConstructArgs<T1, T2, T3, T4, T5>
    {
        private static T1 _arg1;
        private static T2 _arg2;
        private static T3 _arg3;
        private static T4 _arg4;
        private static T5 _arg5;

        internal static bool IsSet { get; private set; }

        internal static void SetArgs(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            IsSet = true;
            _arg1 = arg1;
            _arg2 = arg2;
            _arg3 = arg3;
            _arg4 = arg4;
            _arg5 = arg5;
        }

        internal static (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) GetArgs()
        {
            IsSet = false;
            return (_arg1, _arg2, _arg3, _arg4, _arg5);
        }
    }
}