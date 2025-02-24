using e.commerce.engineering.domain.Enumerables;

namespace e.commerce.engineering.domain
{
    internal class Administrator
    {
        public int AdministratorId { get; set; }
        public int UserId { get; set; }
        public AdmistratorType AdmistratorType { get; set; }
    }
}
