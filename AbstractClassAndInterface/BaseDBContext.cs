using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndInterface
{
    public abstract class BaseDBContext
    {
        protected virtual void OnConfiguring()
        {
        }

        protected virtual void OnModelCreating()
        {
        }
    }
}
