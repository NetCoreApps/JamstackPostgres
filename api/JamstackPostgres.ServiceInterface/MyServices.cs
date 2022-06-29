using System;
using ServiceStack;
using JamstackPostgres.ServiceModel;

namespace JamstackPostgres.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
