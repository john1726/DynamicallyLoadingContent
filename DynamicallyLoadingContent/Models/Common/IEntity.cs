using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicallyLoadingContent.Models.Common
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}