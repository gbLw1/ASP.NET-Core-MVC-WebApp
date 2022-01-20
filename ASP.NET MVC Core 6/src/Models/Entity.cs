namespace src.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}