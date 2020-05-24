using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionBuilder
{
    public static class PersonBulderExtension
    {
        public static PersonBuilder WorkAs
            (this PersonBuilder builder, string Position)
            => builder.Do(p => p.Position = Position);

    }
}
