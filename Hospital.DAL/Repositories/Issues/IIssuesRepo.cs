namespace Hospital.DAL
{
    public interface IIssuesRepo:IGenericRepo<Issue>
    {
        Issue? GetIssueByName(string name);

    }
}
