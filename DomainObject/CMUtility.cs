using Spring.Context;
using System;

namespace CMUtility
{
    public class RepositoryFactory
    {
        public RepositoryFactory();

        public static IApplicationContext ApplicationContext { get; set; }

        public object Service(string serviceName);
    }
}