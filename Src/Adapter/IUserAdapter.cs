namespace Adapter;

public interface IUserAdapter<T>
{
    User GetUser(T human);
}
