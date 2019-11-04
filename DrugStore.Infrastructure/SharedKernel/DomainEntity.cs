namespace DrugStore.Infrastructure.SharedKernel
{
    public abstract class DomainEntity<T>
    {
        public T ID { get; set; }

        /// <summary>
        /// True if domain entity has an identity
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return ID.Equals(default(T));
        }
    }
}