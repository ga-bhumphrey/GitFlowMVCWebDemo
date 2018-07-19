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

        //Constructor
        public RepositoriesViewModel()
        {
            AddRepos();
        }

        //Adds the repos to the list.
        private void AddRepos()
        {
            var repo = new RepositoryModel
            {
                Name = "GitFlowDemo",
                DateCreated = DateTime.Now
            };

            var repo2 = new RepositoryModel
            {
                Name = "GitHubFlowDemo",
                DateCreated = DateTime.Now
            };

            //Repo one
            RepositoryList.Add(repo);
            //Repo two
            RepositoryList.Add(repo2);
        }
    }
}
