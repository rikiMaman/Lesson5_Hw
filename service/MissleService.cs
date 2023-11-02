using Missile.model;
namespace Missile.service
{
    public class MissleService
    {
        public MissleService()
        {
        }
        readonly Data _db;
        public MissleService(Data data)
        {
            //הזרקנו ממחלקת data למחלקת MissleService
            this._db = data;
        }
        //מחזיר את מערך הטילים
        public IEnumerable<Missle> GetData()
        {
            return Data.data;
        }
        public bool add(Missle m)
        {
            if (Data.data.Contains(m))
                return false;
            
            Data.data.Add(m);
            return true;
        }
        //החזרת טילים לפי מיקום
        public IEnumerable<Missle> GetDataByCity(string city)
        {
            return Data.data.Where(t => t.Location.City == city).ToList();
        }

        public IEnumerable<string> GetCities()
        {
            return Data.data.Select(x => x.Location.City).ToList();

        }

    }
}
