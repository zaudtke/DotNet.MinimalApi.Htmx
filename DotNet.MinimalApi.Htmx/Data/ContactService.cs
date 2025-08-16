using LiteDB;

namespace DotNet.MinimalApi.Htmx.Data;

public class ContactService
{
    private readonly LiteDatabase _liteDatabase;
    private const string ContactCollectionName = "Contacts";
    
    public ContactService(LiteDbContext dbContext)
    {
        _liteDatabase = dbContext.Database;
    }
    
    public ValueTask<IEnumerable<Contact>> GetAll() => new (_liteDatabase.GetCollection<Contact>(ContactCollectionName).FindAll());

    public ValueTask<Contact> GetById(int id)
    {
        var contact = _liteDatabase.GetCollection<Contact>(ContactCollectionName).Find(x => x.Id == id).FirstOrDefault();

        return contact is null ? throw new Exception($"Can't find Villain {id} in database") : new ValueTask<Contact>(contact);
    }

    public ValueTask<int> Add(Contact contact) => new(_liteDatabase.GetCollection<Contact>(ContactCollectionName).Insert(contact).AsInt32);

    public ValueTask<bool> Update(Contact contact) => new(_liteDatabase.GetCollection<Contact>(ContactCollectionName).Update(contact));

    public ValueTask<bool> Delete(int id) => new(_liteDatabase.GetCollection<Contact>(ContactCollectionName).Delete(new BsonValue(id)));

    public async ValueTask<IEnumerable<Contact>> SearchByName(string search)
    {
        var collection = _liteDatabase.GetCollection<Contact>(ContactCollectionName);
        _ = collection.EnsureIndex("Name");
        List<Contact> list;
        if (string.IsNullOrEmpty(search))
        {
            var all = await GetAll();
            list = [.. all];
        }
        else
        {
            list = [.. collection.Find(v => v.Name.Contains(search, StringComparison.InvariantCultureIgnoreCase))];
        }

        return list!.FindAll(v => v.Name.Contains(search ?? "", StringComparison.InvariantCultureIgnoreCase));
    }
}