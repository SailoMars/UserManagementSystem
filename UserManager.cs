public class UserManager
{
    private List<string> _users = new List<string>();

    public void AddUser(string username)
    {
        _users.Add(username);
    }
    private int _count = 0;
}
