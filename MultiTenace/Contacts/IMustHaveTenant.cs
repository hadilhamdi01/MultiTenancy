namespace MultiTenace.Contacts
{
    public interface IMustHaveTenant
    {
        public string TenantId { get; set; }
    }
}
