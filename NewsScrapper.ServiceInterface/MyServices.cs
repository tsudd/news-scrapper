using System;
using ServiceStack;
using NewsScrapper.ServiceModel;

namespace NewsScrapper.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
    
    // public 
}
