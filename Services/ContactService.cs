using System.Linq.Expressions;
using WebApplication32.Models;
using WebApplication32.Repository;

namespace WebApplication32.Services
{
    public class ContactService : ServicesBase<Contact>, IContactService
    {
        public ContactService(IRepository<Contact> repo) : base(repo)
        {
        }

        public async Task<Contact> DeleteContact(Contact contact)
        {
            return await _repo.Delete(contact);
        }

        public async Task<Contact> GetContact(int id)
        {
            return await _repo.Get(id);
        }

        public async Task<Contact> GetContact(Expression<Func<Contact, bool>> predicate)
        {
            return await _repo.Get(predicate);
        }

        public async Task<List<Contact>> GetContacts()
        {
            return await _repo.GetAll();
        }

        public async Task<List<Contact>> GetContacts(Expression<Func<Contact, bool>> predicate)
        {
            return await _repo.GetAll(predicate);
        }

        public async Task<Contact> PostContact(Contact contact)
        {
            return await _repo.Post(contact);
        }

        public async Task<Contact> PutContact(Contact contact)
        {
            return await _repo.Put(contact);
        }
    }
}
