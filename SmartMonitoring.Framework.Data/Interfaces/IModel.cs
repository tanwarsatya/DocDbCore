using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMonitoring.Framework.Models.Interfaces
{
    public interface IModel
    {
        string Id { get; set; }

        string type { get; }
    }

    public interface IModel<out T>  : IModel
    {
        T Value { get; }
    }
}
