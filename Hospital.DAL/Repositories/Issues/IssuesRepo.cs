

namespace Hospital.DAL
{
    public class IssuesRepo:GenericRepo<Issue>, IIssuesRepo

    {
        private readonly HospitalContext _context;

        public IssuesRepo(HospitalContext context):base(context)
        {
            _context = context;
        }

        public Issue? GetIssueByName(string name)
        {
            return _context.Set<Issue>().FirstOrDefault(i => i.Name == name);
        }
    }
}
