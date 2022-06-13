using System.Linq.Expressions;
using WebApplication32.Models;

namespace WebApplication32.Services
{
    public interface IContactService
    {
        Task<List<Contact>> GetContacts();
        Task<List<Contact>> GetContacts(Expression<Func<Contact, bool>> predicate);
        Task<Contact> GetContact(int id);
        Task<Contact> GetContact(Expression<Func<Contact, bool>> predicate);
        Task<Contact> PostContact(Contact contact);
        Task<Contact> PutContact(Contact contact);
        Task<Contact> DeleteContact(Contact contact);
    }
}
