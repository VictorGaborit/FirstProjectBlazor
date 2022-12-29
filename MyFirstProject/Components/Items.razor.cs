using Microsoft.AspNetCore.Components;
using MyFirstProject.Models;
using MyFirstProject.Services;
using System.Text.RegularExpressions;

namespace MyFirstProject.Components
{
    public partial class Items
    {
        [Inject]
        public IDataService DataService { get; set; }

        [Inject]
        public IWebHostEnvironment WebHostEnvironment { get; set; }

        string Text { get; set; }

        [Parameter]
        public List<Item> ListItems { get; set; }

        [Parameter]
        public List<Item> ItemsTrouve { get; set; }

        private void search()
        {
            string mot = Text;
            ItemsTrouve = ListItems.Where(item => item.Name.Contains(mot) || item.DisplayName.Contains(mot)).ToList();
        }
    }
}
