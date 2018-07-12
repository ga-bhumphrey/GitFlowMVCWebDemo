using MVCWebDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebDemo.ViewModels
{
    public class RepositoriesViewModel
    {
        public List<RepositoryModel> RepositoryList = new List<RepositoryModel>();

        public RepositoriesViewModel()
        {
            AddRepos();
        }

        private void AddRepos()
        {
            var repo = new RepositoryModel
            {
                Name = "GitFlowDemo",
                DateCreated = DateTime.Now
            };

            RepositoryList.Add(repo);
        }
    }
}
