using _02.Data;
using _03.DataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CarvillaContextDb db = new CarvillaContextDb();
        public void Add(T entity)
        {
            db.Add(entity);
            db.SaveChanges();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
        public int ImageUpload(IFormFile formFile,string pathLocation)
        {
			string[] fileExtentions = { "jpg", "png" };
			string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/{pathLocation}");
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			FileInfo fileInfo = new FileInfo(formFile.FileName);
			foreach (var item in fileExtentions)
			{
				if (fileInfo.Extension == string.Concat(".", item))
				{
					string fileName = formFile.FileName;
					string fileNameWithPath = Path.Combine(path, fileName);
					using var stream = new FileStream(fileNameWithPath, FileMode.Create);

					formFile.CopyTo(stream);
					return 1;
				}
			}
			return 0;
		}
    }
}
