using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validator;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Services
{
    public class CategoryService : IManager<Category>
    {
        //readonly
        //readonly anahtar kelimesi, bir sınıf üyesinin yalnızca oluşturulduğu zaman ve yapıcı metodda değer atanabileceği anlamına gelir. Bu nedenle, _categoryRepository alanını readonly olarak işaretlemek, alanın yalnızca sınıfın kurucu metodunda atanabileceğini ve daha sonra başka bir yerde değiştirilemeyeceğini belirtir.

        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository catRepo)
        {
            _categoryRepository = catRepo;
        }
        public void Add(Category entity)
        {
            CategoryValidator cval = new();
            ValidationResult result = cval.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }

            _categoryRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            //isActive=true olan Kategori silinemez.

            var cat = _categoryRepository.GetByID(id);

            if (cat.IsActive)
            {
                throw new Exception("Aktif olan bir kategori silinemez.");
            }
            _categoryRepository.Delete(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category? GetByID(Guid id)
        {
            return _categoryRepository.GetByID(id);
        }

        public bool IfEntityExists(Category entity)
        {
            return _categoryRepository.IfEntityExists(c => c.CategoryName == entity.CategoryName);
        }

        public void Update(Category entity)
        {
            if (entity != null)
            {
                _categoryRepository.Update(entity);
            }
        }
    }
}
