using Abp.Domain.Entities;

namespace TwoContexts.EntityFrameworkCore.SecondContext.Models
{
    public partial class MyTable : Entity
    {
        public long Id { get; set; }
        public string Testcol { get; set; }
    }
}
