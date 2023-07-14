using System;

namespace BulkyBookWeb.Migrations
{
    public class MigrationBuilder
    {
        internal void CreateTable(string name, Func<object, object> columns, Action<object> constraints)
        {
            throw new NotImplementedException();
        }

        internal void DropTable(string name)
        {
            throw new NotImplementedException();
        }
    }
}