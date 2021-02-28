using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public interface IResult
    {
        //Temel voidleri IResult yapısı ile süslüyoruz 
        bool Success { get; }
        string Message { get; }
        
    }
}
