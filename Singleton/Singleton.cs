using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object Lock = new Object();

        private Singleton()
        {
            
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }

                    }
                }
                return _instance;
            }
        }
    }
}
