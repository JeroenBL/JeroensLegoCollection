using BlazingLego.Data.Models;

namespace BlazingLego.Data.Services;

public class LegoService {

    private readonly ApplicationDbContext _db;

    public LegoService(ApplicationDbContext db)
    {
        _db = db;
    }

    public LegoSet Create(LegoSet legoSet)
    {
        var newLegoSet = _db.LegoSet.Add(legoSet);       
        _db.SaveChanges();

        return newLegoSet.Entity;
    }

    public void Delete(int id)
    {
        var legoSet = _db.LegoSet.Find(id);
        if (legoSet != null)
        {
            _db.LegoSet.Remove(legoSet);
            _db.SaveChanges();
        };
    }

    public LegoSet Get(int id)
    {
        return _db.LegoSet.Find(id);
    }

    public LegoSet Update(LegoSet legoSet)
    {
        var dbLegoSet = _db.LegoSet.Find(legoSet.Id);
        if (dbLegoSet != null)
        {
            dbLegoSet = legoSet;
            _db.SaveChanges();
        }

        return dbLegoSet;
    }

    public List<LegoSet> ListAll()
    {
        return _db.LegoSet.ToList();
    }
}