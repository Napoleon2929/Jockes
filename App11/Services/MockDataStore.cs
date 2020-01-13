using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App11.Models;

namespace App11.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Дети", Description="Анекдоты про детей" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Как-то мужик...", Description="Анекдоты про мужика" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Новые русские", Description="Анекдоты про новых русских" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Отдых", Description="Анекдоты про отдых" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Семья", Description="Анекдоты про семью" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Школа", Description="Анекдоты про школу" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Студенты", Description="Анекдоты про студентов" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Разные ситуации", Description="Анекдоты про разные ситуации" }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}