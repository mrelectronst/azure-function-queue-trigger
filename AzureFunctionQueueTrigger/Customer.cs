namespace AzureFunctionQueueTrigger
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get => $"{FirstName} {LastName}"; }

        public string Phone { get; set; }
    }
}