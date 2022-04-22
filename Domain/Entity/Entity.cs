namespace Domain.Entity;

public abstract class Entity
{
    protected Entity()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; }
}