using HoneyDoService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneyDoService.Services
{
    public class HoneyDoItemManager : IDataRepository<HoneyDoItem>
    {
        readonly HoneyDoItemContext _honeyDoItemContext;

        public HoneyDoItemManager(HoneyDoItemContext context)
        {
            _honeyDoItemContext = context;
        }

        public IEnumerable<HoneyDoItem> GetAll()
        {
            return _honeyDoItemContext.HoneyDoItems.ToList();
        }

        public HoneyDoItem Get(int id)
        {
            return _honeyDoItemContext.HoneyDoItems.FirstOrDefault(e => e.Id == id);
        }

        public void Add(HoneyDoItem entity)
        {
            _honeyDoItemContext.HoneyDoItems.Add(entity);
            _honeyDoItemContext.SaveChanges();
        }

        public void Update(HoneyDoItem honeyDoItem, HoneyDoItem entity)
        {
            honeyDoItem.Description = entity.Description;
            honeyDoItem.AssignedTo = entity.AssignedTo;
            honeyDoItem.Priority = entity.Priority;
            honeyDoItem.Category = entity.Category;
            honeyDoItem.DueDate = entity.DueDate;
            honeyDoItem.Recurrence = entity.Recurrence;
            honeyDoItem.Completed = entity.Completed;

            _honeyDoItemContext.SaveChanges();
        }

        public void Delete(HoneyDoItem honeyDoItem)
        {
            _honeyDoItemContext.HoneyDoItems.Remove(honeyDoItem);
            _honeyDoItemContext.SaveChanges();
        }
    }
}
