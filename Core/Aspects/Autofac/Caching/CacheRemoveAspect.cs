using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Microsoft.Extensions.DependencyInjection;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;


namespace Core.Aspects.Autofac.Caching
{
   public class CacheRemoveAspect :MethodInterception
    {
        string _pattern;
        ICacheManager _cacheManager;
        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
