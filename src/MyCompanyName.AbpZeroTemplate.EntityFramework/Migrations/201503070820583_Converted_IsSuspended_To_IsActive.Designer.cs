// <auto-generated />

using System.CodeDom.Compiler;
using System.Data.Entity.Migrations.Infrastructure;
using System.Resources;

namespace Taskever.Migrations
{
    [GeneratedCode("EntityFramework.Migrations", "6.1.2-31219")]
    public sealed partial class Converted_IsSuspended_To_IsActive : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(Converted_IsSuspended_To_IsActive));
        
        string IMigrationMetadata.Id
        {
            get { return "201503070820583_Converted_IsSuspended_To_IsActive"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
