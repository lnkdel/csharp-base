namespace DesignPatterns
{
    // 懒汉 类加载时不初始化
    // 饿汉 类加载时完成初始化

    /// <summary>
    /// 懒汉 线程不安全
    /// </summary>
    public class SingletonLazyUnSafety
    {
        private static SingletonLazyUnSafety instance;
        private SingletonLazyUnSafety() { }
        public static SingletonLazyUnSafety GetInstance()
        {
            if (instance == null)
            {
                instance = new SingletonLazyUnSafety();
            }
            return instance;
        }
    }

    /// <summary>
    /// 懒汉 线程安全
    /// </summary>
    public class SingletonLazySafety
    {
        private static SingletonLazySafety instance;
        private static readonly object syncObject = new object();
        private SingletonLazySafety() { }
        public static SingletonLazySafety GetInstance()
        {
            if (instance == null)
            {
                lock (syncObject)
                {
                    if (instance == null)
                    {
                        instance = new SingletonLazySafety();
                    }
                }
            }
            return instance;
        }
    }

    /// <summary>
    /// 饿汉
    /// </summary>
    public class SingletonHungry
    {
        private static SingletonHungry instance = new SingletonHungry();
        private SingletonHungry() { }
        public static SingletonHungry GetInstance()
        {
            return instance;
        }
    }
}
